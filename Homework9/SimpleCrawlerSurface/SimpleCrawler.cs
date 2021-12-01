using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace SimpleCrawlerSurface
{
    class SimpleCrawler
    {
        private ConcurrentBag<String> successInfo = new ConcurrentBag<String>();
        private ConcurrentBag<String> failureInfo = new ConcurrentBag<String>();
        public ConcurrentBag<String> SuccessInfo { get => successInfo; }
        public ConcurrentBag<String> FailureInfo { get => failureInfo; }

        private ConcurrentQueue<string> waitingurls = new ConcurrentQueue<string>();
        public ConcurrentQueue<string> WaitingUrls { get => waitingurls; }
        private ConcurrentDictionary<string, bool> crawledurls = new ConcurrentDictionary<string, bool>();
        public ConcurrentDictionary<string, bool> CrawledUrls { get => crawledurls; }

        private int count = 0;
        public void Crawl()
        {
            while (true)
            {
                string current = null;
                if (count >= 10) break;
                while (!waitingurls.TryDequeue(out current)) Thread.Sleep(1);    
                string html = DownLoad(current); // 下载
                crawledurls.TryAdd(current, true); 
                count++;
                Parse(current, html);//解析,并加入新的链接               
            }
        }

        public string DownLoad(string url)
        {
            if (!(url.EndsWith(".html") || url.EndsWith(".aspx") || url.EndsWith(".jsp"))) return "";
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                successInfo.Add(url);                
                return html;
            }
            catch (Exception ex)
            {
                failureInfo.Add(ex.Message);
                return "";
            }
        }

        private void Parse(string url, string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'](?<Address>[^""'#>]+)[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Groups["Address"].Value;
                if (strRef.StartsWith(@"/")) strRef = url + strRef.Substring(1);
                if (strRef.Length == 0) continue;
                waitingurls.Enqueue(strRef);
            }
        }
    }
}
