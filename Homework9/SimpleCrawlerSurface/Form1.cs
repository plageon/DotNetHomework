using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace SimpleCrawlerSurface
{
    public partial class Form1 : Form
    {
        SimpleCrawler myCrawler;
        public Form1()
        {
            InitializeComponent();
            myCrawler = new SimpleCrawler();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Crawl_Click(object sender, EventArgs e)
        {
            string startUrl = textBox_Url.Text;
            if (startUrl.Length == 0) startUrl = "https://www.runoob.com/";
            myCrawler.WaitingUrls.Enqueue(startUrl);
            // myCrawler.Crawl();
            List<Task> taskpool = new List<Task>()  ;
            for (int i = 0; i < 1; i++) taskpool.Add(new Task(() => myCrawler.Crawl()));
            foreach (Task task in taskpool) task.Start();

            successBindingSource.DataSource = myCrawler.SuccessInfo;
            failureBindingSource.DataSource = myCrawler.FailureInfo;
        }
    }
}
