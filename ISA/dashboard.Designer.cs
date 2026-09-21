namespace ISA
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            groupBox1 = new GroupBox();
            txbTotalsalary = new TextBox();
            txbnumstaff = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TxbNumSup = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txbGrandTotal = new TextBox();
            txbTotalQty = new TextBox();
            label6 = new Label();
            txbNumProduct = new TextBox();
            txbtq = new Label();
            label5 = new Label();
            groupBox4 = new GroupBox();
            txbNumCus = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(657, 381);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbTotalsalary);
            groupBox1.Controls.Add(txbnumstaff);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 148);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff";
            // 
            // txbTotalsalary
            // 
            txbTotalsalary.Location = new Point(201, 84);
            txbTotalsalary.Name = "txbTotalsalary";
            txbTotalsalary.Size = new Size(125, 27);
            txbTotalsalary.TabIndex = 1;
            // 
            // txbnumstaff
            // 
            txbnumstaff.Location = new Point(201, 45);
            txbnumstaff.Name = "txbnumstaff";
            txbnumstaff.Size = new Size(125, 27);
            txbnumstaff.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 84);
            label2.Name = "label2";
            label2.Size = new Size(111, 27);
            label2.TabIndex = 0;
            label2.Text = "Total salary";
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 41);
            label1.Name = "label1";
            label1.Size = new Size(160, 27);
            label1.TabIndex = 0;
            label1.Text = "Numbers of Staff";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxbNumSup);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(403, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 138);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Supplier";
            // 
            // TxbNumSup
            // 
            TxbNumSup.Location = new Point(196, 55);
            TxbNumSup.Name = "TxbNumSup";
            TxbNumSup.Size = new Size(125, 27);
            TxbNumSup.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 55);
            label4.Name = "label4";
            label4.Size = new Size(190, 28);
            label4.TabIndex = 0;
            label4.Text = "Numbers of supplier";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txbGrandTotal);
            groupBox3.Controls.Add(txbTotalQty);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txbNumProduct);
            groupBox3.Controls.Add(txbtq);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(35, 193);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(337, 208);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product";
            // 
            // txbGrandTotal
            // 
            txbGrandTotal.Location = new Point(201, 130);
            txbGrandTotal.Name = "txbGrandTotal";
            txbGrandTotal.Size = new Size(125, 27);
            txbGrandTotal.TabIndex = 1;
            // 
            // txbTotalQty
            // 
            txbTotalQty.Location = new Point(201, 84);
            txbTotalQty.Name = "txbTotalQty";
            txbTotalQty.Size = new Size(125, 27);
            txbTotalQty.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 130);
            label6.Name = "label6";
            label6.Size = new Size(112, 27);
            label6.TabIndex = 0;
            label6.Text = "Grand total";
            // 
            // txbNumProduct
            // 
            txbNumProduct.Location = new Point(201, 45);
            txbNumProduct.Name = "txbNumProduct";
            txbNumProduct.Size = new Size(125, 27);
            txbNumProduct.TabIndex = 1;
            // 
            // txbtq
            // 
            txbtq.AutoSize = true;
            txbtq.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbtq.Location = new Point(72, 84);
            txbtq.Name = "txbtq";
            txbtq.Size = new Size(90, 27);
            txbtq.TabIndex = 0;
            txbtq.Text = "Total gty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 45);
            label5.Name = "label5";
            label5.Size = new Size(189, 27);
            label5.TabIndex = 0;
            label5.Text = "Numbers of Product";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txbNumCus);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(403, 202);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(337, 138);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Customer";
            // 
            // txbNumCus
            // 
            txbNumCus.Location = new Point(206, 55);
            txbNumCus.Name = "txbNumCus";
            txbNumCus.Size = new Size(125, 27);
            txbNumCus.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 55);
            label7.Name = "label7";
            label7.Size = new Size(204, 28);
            label7.TabIndex = 0;
            label7.Text = "Numbers of Customer";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "dashboard";
            Text = "dashboard";
            Load += dashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txbTotalsalary;
        private TextBox txbnumstaff;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox TxbNumSup;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txbTotalQty;
        private TextBox txbNumProduct;
        private Label txbtq;
        private Label label5;
        private TextBox txbGrandTotal;
        private Label label6;
        private GroupBox groupBox4;
        private TextBox txbNumCus;
        private Label label7;
    }
}