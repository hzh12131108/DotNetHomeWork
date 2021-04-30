using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork9
{
    public partial class Form1 : Form
    {
        SimpleCrawler myCrawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string startUrl = textBox1.Text;
            myCrawler.urls.Add(startUrl, false);
            Thread th = new Thread(myCrawler.Crawl);
            richTextBox1.Text = "正在爬取！";
            th.Start();
            th.Join();
            richTextBox1.Text = myCrawler.message.ToString();

        }
    }
}
