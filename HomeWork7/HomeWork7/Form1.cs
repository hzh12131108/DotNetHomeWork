using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private Graphics graphics = null;
        private Color penColor;
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = splitContainer1.Panel2.CreateGraphics();
            else
            {
                graphics.Clear(this.BackColor);
                graphics.Dispose();
                graphics = splitContainer1.Panel2.CreateGraphics();
            }
            
            drawCayleyTree((int)depth.Value, 150, 310, (double)mainLength.Value, -Math.PI / 2);
            
        }
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            
            drawCayleyTree(n - 1, x1, y1, (double)rightLengthRatio.Value * leng, th + (double)rightAngle.Value*Math.PI/180);
            drawCayleyTree(n - 1, x1, y1, (double)leftLengthRatio.Value*leng, th - (double)leftAngle.Value*Math.PI/180);
            
           
            
          
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            Pen myPen = new Pen(penColor);
            graphics.DrawLine(myPen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if(dr == DialogResult.OK)
                penColor = colorDialog1.Color;
        }
        /* private Graphics graphics;
double th1 = 30 * Math.PI / 180;
double th2 = 20 * Math.PI / 180;
double per1 = 0.6;
double per2 = 0.7;
private void button1_Click(object sender, EventArgs e)
{
    if (graphics == null)
        graphics = this.CreateGraphics();
    drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
}

void drawCayleyTree(int n,double x0,double y0,double leng,double th)
{
    if (n == 0)
        return;
    double x1 = x0 + leng * Math.Cos(th);
    double y1 = y0 + leng * Math.Sin(th);
    drawLine(x0, y0, x1, y1);
    drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
    drawCayleyTree(n - 1, x1, y1, per2, th - th2);

}
void drawLine(double x0,double y0,double x1,double y1)
{
    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
}*/
    }
}
