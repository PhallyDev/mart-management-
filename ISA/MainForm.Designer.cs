namespace ISA
{
    partial class MainForm
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
            cus = new Button();
            Sup = new Button();
            Staff = new Button();
            pro = new Button();
            button1 = new Button();
            button2 = new Button();
            order = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // cus
            // 
            cus.BackColor = SystemColors.ActiveCaption;
            cus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cus.ForeColor = Color.DarkSlateGray;
            cus.Location = new Point(12, 31);
            cus.Name = "cus";
            cus.Size = new Size(162, 157);
            cus.TabIndex = 0;
            cus.Text = "Customer";
            cus.UseVisualStyleBackColor = false;
            cus.Click += cus_Click;
            // 
            // Sup
            // 
            Sup.BackColor = Color.IndianRed;
            Sup.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sup.ForeColor = Color.Blue;
            Sup.Location = new Point(12, 245);
            Sup.Name = "Sup";
            Sup.Size = new Size(162, 169);
            Sup.TabIndex = 0;
            Sup.Text = "Supplier";
            Sup.UseVisualStyleBackColor = false;
            Sup.Click += Sup_Click;
            // 
            // Staff
            // 
            Staff.BackColor = Color.Cyan;
            Staff.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Staff.ForeColor = Color.DimGray;
            Staff.Location = new Point(390, 31);
            Staff.Name = "Staff";
            Staff.Size = new Size(182, 157);
            Staff.TabIndex = 0;
            Staff.Text = "Staff";
            Staff.UseVisualStyleBackColor = false;
            Staff.Click += Staff_Click;
            // 
            // pro
            // 
            pro.BackColor = SystemColors.Highlight;
            pro.FlatStyle = FlatStyle.Flat;
            pro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pro.ForeColor = SystemColors.ControlText;
            pro.Location = new Point(190, 31);
            pro.Name = "pro";
            pro.Size = new Size(178, 157);
            pro.TabIndex = 0;
            pro.Text = "Product";
            pro.UseVisualStyleBackColor = false;
            pro.Click += pro_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(180, 245);
            button1.Name = "button1";
            button1.Size = new Size(195, 169);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DodgerBlue;
            button2.Location = new Point(381, 245);
            button2.Name = "button2";
            button2.Size = new Size(191, 169);
            button2.TabIndex = 1;
            button2.Text = "Import";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // order
            // 
            order.BackColor = Color.MediumAquamarine;
            order.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order.ForeColor = Color.DimGray;
            order.Location = new Point(578, 31);
            order.Name = "order";
            order.Size = new Size(182, 157);
            order.TabIndex = 0;
            order.Text = "Order";
            order.UseVisualStyleBackColor = false;
            order.Click += order_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DodgerBlue;
            button3.Location = new Point(569, 245);
            button3.Name = "button3";
            button3.Size = new Size(191, 169);
            button3.TabIndex = 1;
            button3.Text = "Payment";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pro);
            Controls.Add(order);
            Controls.Add(Staff);
            Controls.Add(Sup);
            Controls.Add(cus);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button cus;
        private Button Sup;
        private Button Staff;
        private Button pro;
        private Button button1;
        private Button button2;
        private Button order;
        private Button button3;
    }
}