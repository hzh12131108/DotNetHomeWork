namespace HomeWork8
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
            this.importPressed = new System.Windows.Forms.Button();
            this.exportPressed = new System.Windows.Forms.Button();
            this.changeOrderPressed = new System.Windows.Forms.Button();
            this.deleteOrderPressed = new System.Windows.Forms.Button();
            this.findOrderPressed = new System.Windows.Forms.Button();
            this.addOrderPressed = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allOrderDetailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // importPressed
            // 
            this.importPressed.Location = new System.Drawing.Point(686, 68);
            this.importPressed.Name = "importPressed";
            this.importPressed.Size = new System.Drawing.Size(102, 33);
            this.importPressed.TabIndex = 5;
            this.importPressed.Text = "导入订单";
            this.importPressed.UseVisualStyleBackColor = true;
            this.importPressed.Click += new System.EventHandler(this.importPressed_Click);
            // 
            // exportPressed
            // 
            this.exportPressed.Location = new System.Drawing.Point(551, 68);
            this.exportPressed.Name = "exportPressed";
            this.exportPressed.Size = new System.Drawing.Size(102, 33);
            this.exportPressed.TabIndex = 4;
            this.exportPressed.Text = "导出订单";
            this.exportPressed.UseVisualStyleBackColor = true;
            this.exportPressed.Click += new System.EventHandler(this.exportPressed_Click);
            // 
            // changeOrderPressed
            // 
            this.changeOrderPressed.Location = new System.Drawing.Point(278, 68);
            this.changeOrderPressed.Name = "changeOrderPressed";
            this.changeOrderPressed.Size = new System.Drawing.Size(102, 33);
            this.changeOrderPressed.TabIndex = 3;
            this.changeOrderPressed.Text = "添加明细";
            this.changeOrderPressed.UseVisualStyleBackColor = true;
            this.changeOrderPressed.Click += new System.EventHandler(this.changeOrderPressed_Click);
            // 
            // deleteOrderPressed
            // 
            this.deleteOrderPressed.Location = new System.Drawing.Point(148, 68);
            this.deleteOrderPressed.Name = "deleteOrderPressed";
            this.deleteOrderPressed.Size = new System.Drawing.Size(102, 33);
            this.deleteOrderPressed.TabIndex = 2;
            this.deleteOrderPressed.Text = "删除订单";
            this.deleteOrderPressed.UseVisualStyleBackColor = true;
            this.deleteOrderPressed.Click += new System.EventHandler(this.deleteOrderPressed_Click);
            // 
            // findOrderPressed
            // 
            this.findOrderPressed.Location = new System.Drawing.Point(490, 12);
            this.findOrderPressed.Name = "findOrderPressed";
            this.findOrderPressed.Size = new System.Drawing.Size(102, 33);
            this.findOrderPressed.TabIndex = 1;
            this.findOrderPressed.Text = "查询订单";
            this.findOrderPressed.UseVisualStyleBackColor = true;
            this.findOrderPressed.Click += new System.EventHandler(this.findOrderPressed_Click);
            // 
            // addOrderPressed
            // 
            this.addOrderPressed.Location = new System.Drawing.Point(21, 68);
            this.addOrderPressed.Name = "addOrderPressed";
            this.addOrderPressed.Size = new System.Drawing.Size(102, 33);
            this.addOrderPressed.TabIndex = 0;
            this.addOrderPressed.Text = "添加订单";
            this.addOrderPressed.UseVisualStyleBackColor = true;
            this.addOrderPressed.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(2, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 304);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.clientNameDataGridViewTextBoxColumn1,
            this.orderPriceDataGridViewTextBoxColumn1,
            this.allOrderDetailDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(386, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(400, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 304);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodNameDataGridViewTextBoxColumn,
            this.goodPriceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.orderDetailsPriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(396, 298);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "删除明细";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "OrderDetailsLits";
            this.bindingSource2.DataSource = this.bindingSource1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // clientNameDataGridViewTextBoxColumn1
            // 
            this.clientNameDataGridViewTextBoxColumn1.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn1.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.clientNameDataGridViewTextBoxColumn1.Name = "clientNameDataGridViewTextBoxColumn1";
            this.clientNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.clientNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // orderPriceDataGridViewTextBoxColumn1
            // 
            this.orderPriceDataGridViewTextBoxColumn1.DataPropertyName = "OrderPrice";
            this.orderPriceDataGridViewTextBoxColumn1.HeaderText = "OrderPrice";
            this.orderPriceDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.orderPriceDataGridViewTextBoxColumn1.Name = "orderPriceDataGridViewTextBoxColumn1";
            this.orderPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderPriceDataGridViewTextBoxColumn1.Width = 150;
            // 
            // allOrderDetailDataGridViewTextBoxColumn1
            // 
            this.allOrderDetailDataGridViewTextBoxColumn1.DataPropertyName = "AllOrderDetail";
            this.allOrderDetailDataGridViewTextBoxColumn1.HeaderText = "AllOrderDetail";
            this.allOrderDetailDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.allOrderDetailDataGridViewTextBoxColumn1.Name = "allOrderDetailDataGridViewTextBoxColumn1";
            this.allOrderDetailDataGridViewTextBoxColumn1.ReadOnly = true;
            this.allOrderDetailDataGridViewTextBoxColumn1.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(HomeWork5.Order);
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "goodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "goodName";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodPriceDataGridViewTextBoxColumn
            // 
            this.goodPriceDataGridViewTextBoxColumn.DataPropertyName = "goodPrice";
            this.goodPriceDataGridViewTextBoxColumn.HeaderText = "goodPrice";
            this.goodPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.goodPriceDataGridViewTextBoxColumn.Name = "goodPriceDataGridViewTextBoxColumn";
            this.goodPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDetailsPriceDataGridViewTextBoxColumn
            // 
            this.orderDetailsPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderDetailsPrice";
            this.orderDetailsPriceDataGridViewTextBoxColumn.HeaderText = "OrderDetailsPrice";
            this.orderDetailsPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderDetailsPriceDataGridViewTextBoxColumn.Name = "orderDetailsPriceDataGridViewTextBoxColumn";
            this.orderDetailsPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "订单号",
            "顾客名称",
            "订单价格"});
            this.comboBox1.Location = new System.Drawing.Point(80, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 28);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.findOrderPressed);
            this.Controls.Add(this.importPressed);
            this.Controls.Add(this.exportPressed);
            this.Controls.Add(this.changeOrderPressed);
            this.Controls.Add(this.addOrderPressed);
            this.Controls.Add(this.deleteOrderPressed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addOrderPressed;
        private System.Windows.Forms.Button importPressed;
        private System.Windows.Forms.Button exportPressed;
        private System.Windows.Forms.Button changeOrderPressed;
        private System.Windows.Forms.Button deleteOrderPressed;
        private System.Windows.Forms.Button findOrderPressed;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn allOrderDetailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailsPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

