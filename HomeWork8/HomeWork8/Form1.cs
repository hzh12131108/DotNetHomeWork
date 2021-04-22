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
    public partial class Form1 : Form
    {
       
        OrderService os = new OrderService();
        int ClickedOrder;//被选定的订单
        int ClickedOrderdetail;//被选定的订单明细
        
        public Form1()
        {
            os.AddOrder(new Order(12, "hzh"));
            os.AddOrder(new Order(13, "shq"));
            os.AddOrder(new Order(14, "aaa"));
            os.OrderList[0].AddOrderDetails(new OrderDetails("c#", 3, 123));
            os.OrderList[1].AddOrderDetails(new OrderDetails("java", 4, 989));
            InitializeComponent();
            bindingSource1.DataSource = os.OrderList;
        }


        
        //添加空白订单
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2(this);
            addForm.ClickEvent += new ClickDelegateHander(getmessage);
            addForm.ShowDialog();
            
        }
        public void getmessage(int a,string b)
        {
            os.AddOrder(new Order(a, b));
            bindingSource1.ResetBindings(false);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //点击订单显示订单明细
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            bindingSource2.DataSource = os.OrderList[e.RowIndex - 1].OrderDetailsLits;
        }


        //删除订单操作
        private void deleteOrderPressed_Click(object sender, EventArgs e)
        {
            os.OrderList.RemoveAt(ClickedOrder);
            bindingSource1.ResetBindings(false);
        }
         private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
         {
            ClickedOrder = e.RowIndex;
         }

        //对相应订单添加订单明细
        private void changeOrderPressed_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.OrderDetailEvent += new OrderDetailClickDelegateHander(addDetail);
            form3.ShowDialog();
            
        }
        public void addDetail(string name,int count,double price)
        {
            os.OrderList[ClickedOrder].AddOrderDetails(new OrderDetails(name, count, price));
            bindingSource2.ResetBindings(false);
        }

        //删除对应订单的明细
        private void button1_Click_1(object sender, EventArgs e)
        {
            os.OrderList[ClickedOrder].OrderDetailsLits.RemoveAt(ClickedOrderdetail);
            bindingSource2.ResetBindings(false);
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickedOrderdetail = e.RowIndex;
        }

        //将订单列表导出成文件
        private void exportPressed_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "请选择保存路径：";
            saveFileDialog1.InitialDirectory = @"c:\";
            saveFileDialog1.Filter = "XML文件(*.xml)|*.xml";
            
            if(saveFileDialog1.ShowDialog()==DialogResult.Yes)
            {
                os.Export(saveFileDialog1.FileName);
            }
        }
        //将xml文件加入列表
        private void importPressed_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "请选择文件：";
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "XML文件(*.xml)|*.xml";
            
            if(openFileDialog1.ShowDialog() == DialogResult.Yes)
            {
                os.Import(openFileDialog1.FileName);
                bindingSource1.ResetBindings(false);
            }
        }
        //多种方式查询订单
        private void findOrderPressed_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "订单号":
                    os.InquireOrder(1, textBox1.Text);
                    bindingSource1.DataSource = os.QueryList;
                    bindingSource1.ResetBindings(false);
                    break;
                case "顾客名称":
                    os.InquireOrder(2, textBox1.Text);
                    bindingSource1.DataSource = os.QueryList;
                    bindingSource1.ResetBindings(false);
                    break;
                case "订单价格":
                    os.InquireOrder(4, textBox1.Text);
                    bindingSource1.DataSource = os.QueryList;
                    bindingSource1.ResetBindings(false);
                    break;
                default:
                    break;



            }
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
