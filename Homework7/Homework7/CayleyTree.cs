using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class CayleyTree : Form
    {
        private Graphics graphics;
        double th1, th2, per1, per2;
        Pen pen;
        public CayleyTree()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics != null) graphics.Clear(Color.White);
            graphics = this.CreateGraphics();
            per1 = Double.Parse(LeftPer.Text);
            per2 = Double.Parse(RightPer.Text);
            th1 = Double.Parse(LeftAngle.Text) * Math.PI / 180;
            th2 = Double.Parse(RightAngle.Text) * Math.PI / 180;
            switch (PenColor.SelectedItem.ToString())
            {
                case "Black":pen = Pens.Black;break;
                case "Red":pen = Pens.Red;break;
                case "Blue":pen = Pens.Blue;break;
                case "Silver":pen = Pens.Silver;break;
                case "Gray":pen = Pens.Gray;break;
                default:pen = Pens.Black;break;
            }
            drawCayleyTree(pen,Int32.Parse(RecursiveDepth.Text), 210, 330, Double.Parse(Length.Text), -Math.PI / 2);
        }

        void drawLine(Pen pen,double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (float)x0, (float)y0, (float)x1, (float)y1);
        }
        void drawCayleyTree(Pen pen,int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(pen,x0, y0, x1, y1);
            drawCayleyTree(pen, n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(pen, n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PenColor.SelectedItem.ToString())
            {
                case "Black": pictureBox1.BackColor = Color.Black; break;
                case "Red": pictureBox1.BackColor = Color.Red; break;
                case "Blue": pictureBox1.BackColor = Color.Blue; break;
                case "Silver": pictureBox1.BackColor = Color.Silver; break;
                case "Gray": pictureBox1.BackColor = Color.Gray; break;
                default: pictureBox1.BackColor = Color.Black; break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
