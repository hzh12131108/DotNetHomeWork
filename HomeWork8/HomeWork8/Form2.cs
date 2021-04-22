using System;
using HomeWork5;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork8
{
    public delegate void ClickDelegateHander(int OrderID, string clientName);
    public partial class Form2 : Form
    {
        public event ClickDelegateHander ClickEvent;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 myForm1)
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClickEvent != null)
                ClickEvent(Int32.Parse(textBox1.Text), textBox4.Text);
           
            this.Close();
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
