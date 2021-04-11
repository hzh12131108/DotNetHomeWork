namespace HomeWork7
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainLength = new System.Windows.Forms.NumericUpDown();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rightLengthRatio = new System.Windows.Forms.NumericUpDown();
            this.leftLengthRatio = new System.Windows.Forms.NumericUpDown();
            this.rightAngle = new System.Windows.Forms.NumericUpDown();
            this.leftAngle = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLengthRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLengthRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 20F);
            this.button1.Location = new System.Drawing.Point(52, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.leftAngle);
            this.groupBox1.Controls.Add(this.rightAngle);
            this.groupBox1.Controls.Add(this.leftLengthRatio);
            this.groupBox1.Controls.Add(this.rightLengthRatio);
            this.groupBox1.Controls.Add(this.mainLength);
            this.groupBox1.Controls.Add(this.depth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "树各项参数";
            // 
            // mainLength
            // 
            this.mainLength.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mainLength.Location = new System.Drawing.Point(122, 68);
            this.mainLength.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.mainLength.Name = "mainLength";
            this.mainLength.Size = new System.Drawing.Size(120, 28);
            this.mainLength.TabIndex = 1;
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(122, 30);
            this.depth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(120, 28);
            this.depth.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "画笔颜色：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "左分支角度：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "右分支角度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "右长度比：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "左长度比：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "主干长度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "递归深度：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rightLengthRatio
            // 
            this.rightLengthRatio.DecimalPlaces = 2;
            this.rightLengthRatio.Increment = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            this.rightLengthRatio.Location = new System.Drawing.Point(122, 108);
            this.rightLengthRatio.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rightLengthRatio.Name = "rightLengthRatio";
            this.rightLengthRatio.Size = new System.Drawing.Size(120, 28);
            this.rightLengthRatio.TabIndex = 0;
            // 
            // leftLengthRatio
            // 
            this.leftLengthRatio.DecimalPlaces = 2;
            this.leftLengthRatio.Increment = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            this.leftLengthRatio.Location = new System.Drawing.Point(122, 146);
            this.leftLengthRatio.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.leftLengthRatio.Name = "leftLengthRatio";
            this.leftLengthRatio.Size = new System.Drawing.Size(120, 28);
            this.leftLengthRatio.TabIndex = 14;
            // 
            // rightAngle
            // 
            this.rightAngle.Location = new System.Drawing.Point(122, 186);
            this.rightAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.rightAngle.Name = "rightAngle";
            this.rightAngle.Size = new System.Drawing.Size(120, 28);
            this.rightAngle.TabIndex = 15;
            // 
            // leftAngle
            // 
            this.leftAngle.Location = new System.Drawing.Point(122, 226);
            this.leftAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.leftAngle.Name = "leftAngle";
            this.leftAngle.Size = new System.Drawing.Size(120, 28);
            this.leftAngle.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "选择颜色";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLengthRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLengthRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.NumericUpDown mainLength;
        private System.Windows.Forms.NumericUpDown leftAngle;
        private System.Windows.Forms.NumericUpDown rightAngle;
        private System.Windows.Forms.NumericUpDown leftLengthRatio;
        private System.Windows.Forms.NumericUpDown rightLengthRatio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

