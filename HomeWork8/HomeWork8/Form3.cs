using System;
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
    public delegate void OrderDetailClickDelegateHander(string ObjName, int count,double price);
    public partial class Form3 : Form
    {
        public event OrderDetailClickDelegateHander OrderDetailEvent;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OrderDetailEvent != null)
                OrderDetailEvent(textBox1.Text,Int32.Parse(textBox2.Text),Double.Parse(textBox3.Text));

            this.Close();
        }
    }
}
