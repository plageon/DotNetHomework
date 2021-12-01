
namespace Homework7
{
    partial class CayleyTree
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PenColor = new System.Windows.Forms.ComboBox();
            this.RightAngle = new System.Windows.Forms.TextBox();
            this.LeftAngle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RightPer = new System.Windows.Forms.TextBox();
            this.LeftPer = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.TextBox();
            this.RecursiveDepth = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.PenColor);
            this.groupBox1.Controls.Add(this.RightAngle);
            this.groupBox1.Controls.Add(this.LeftAngle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RightPer);
            this.groupBox1.Controls.Add(this.LeftPer);
            this.groupBox1.Controls.Add(this.Length);
            this.groupBox1.Controls.Add(this.RecursiveDepth);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(942, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 489);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PenColor
            // 
            this.PenColor.FormattingEnabled = true;
            this.PenColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Silver",
            "Gray"});
            this.PenColor.Location = new System.Drawing.Point(134, 265);
            this.PenColor.Name = "PenColor";
            this.PenColor.Size = new System.Drawing.Size(153, 23);
            this.PenColor.TabIndex = 14;
            this.PenColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RightAngle
            // 
            this.RightAngle.Location = new System.Drawing.Point(134, 222);
            this.RightAngle.Name = "RightAngle";
            this.RightAngle.Size = new System.Drawing.Size(153, 25);
            this.RightAngle.TabIndex = 13;
            this.RightAngle.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // LeftAngle
            // 
            this.LeftAngle.Location = new System.Drawing.Point(134, 181);
            this.LeftAngle.Name = "LeftAngle";
            this.LeftAngle.Size = new System.Drawing.Size(153, 25);
            this.LeftAngle.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "PenColor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "RightAngle:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "LeftAngle:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "RightPer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "LeftPer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "MainLength:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Depth:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RightPer
            // 
            this.RightPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPer.Location = new System.Drawing.Point(134, 141);
            this.RightPer.Name = "RightPer";
            this.RightPer.Size = new System.Drawing.Size(153, 25);
            this.RightPer.TabIndex = 4;
            this.RightPer.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // LeftPer
            // 
            this.LeftPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPer.Location = new System.Drawing.Point(134, 100);
            this.LeftPer.Name = "LeftPer";
            this.LeftPer.Size = new System.Drawing.Size(153, 25);
            this.LeftPer.TabIndex = 3;
            this.LeftPer.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Length
            // 
            this.Length.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Length.Location = new System.Drawing.Point(134, 64);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(153, 25);
            this.Length.TabIndex = 2;
            this.Length.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RecursiveDepth
            // 
            this.RecursiveDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecursiveDepth.ForeColor = System.Drawing.Color.Black;
            this.RecursiveDepth.Location = new System.Drawing.Point(134, 28);
            this.RecursiveDepth.Name = "RecursiveDepth";
            this.RecursiveDepth.Size = new System.Drawing.Size(153, 25);
            this.RecursiveDepth.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(17, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 489);
            this.panel1.TabIndex = 2;
            // 
            // CayleyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CayleyTree";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RightAngle;
        private System.Windows.Forms.TextBox LeftAngle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RightPer;
        private System.Windows.Forms.TextBox LeftPer;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox RecursiveDepth;
        private System.Windows.Forms.ComboBox PenColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

