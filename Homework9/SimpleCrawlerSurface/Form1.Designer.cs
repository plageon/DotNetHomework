
namespace SimpleCrawlerSurface
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Crawl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.successBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.failureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FailureListBox = new System.Windows.Forms.ListBox();
            this.SuccessListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.failureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Url);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 60);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_Url
            // 
            this.textBox_Url.Location = new System.Drawing.Point(332, 27);
            this.textBox_Url.Name = "textBox_Url";
            this.textBox_Url.Size = new System.Drawing.Size(315, 25);
            this.textBox_Url.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter a url that ends with (html/jsp/aspx) :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Crawl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 32);
            this.panel2.TabIndex = 1;
            // 
            // button_Crawl
            // 
            this.button_Crawl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_Crawl.Location = new System.Drawing.Point(461, 3);
            this.button_Crawl.Name = "button_Crawl";
            this.button_Crawl.Size = new System.Drawing.Size(75, 23);
            this.button_Crawl.TabIndex = 0;
            this.button_Crawl.Text = "Crawl";
            this.button_Crawl.UseVisualStyleBackColor = true;
            this.button_Crawl.Click += new System.EventHandler(this.Button_Crawl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FailureListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(510, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Failure Result";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SuccessListBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 366);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Success Result";
            // 
            // successBindingSource
            // 
            this.successBindingSource.DataSource = typeof(System.Collections.Specialized.StringCollection);
            // 
            // failureBindingSource
            // 
            this.failureBindingSource.DataSource = typeof(System.Collections.Specialized.StringCollection);
            // 
            // FailureListBox
            // 
            this.FailureListBox.DataSource = this.failureBindingSource;
            this.FailureListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FailureListBox.FormattingEnabled = true;
            this.FailureListBox.ItemHeight = 15;
            this.FailureListBox.Location = new System.Drawing.Point(3, 29);
            this.FailureListBox.Name = "FailureListBox";
            this.FailureListBox.Size = new System.Drawing.Size(507, 334);
            this.FailureListBox.TabIndex = 0;
            // 
            // SuccessListBox
            // 
            this.SuccessListBox.DataSource = this.successBindingSource;
            this.SuccessListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SuccessListBox.FormattingEnabled = true;
            this.SuccessListBox.ItemHeight = 15;
            this.SuccessListBox.Location = new System.Drawing.Point(3, 29);
            this.SuccessListBox.Name = "SuccessListBox";
            this.SuccessListBox.Size = new System.Drawing.Size(498, 334);
            this.SuccessListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "SimpleCrawler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.successBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.failureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Crawl;
        private System.Windows.Forms.TextBox textBox_Url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource failureBindingSource;
        private System.Windows.Forms.BindingSource successBindingSource;
        private System.Windows.Forms.ListBox FailureListBox;
        private System.Windows.Forms.ListBox SuccessListBox;
    }
}

