namespace ISA
{
    partial class Customer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AKbalthom Ream", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(191, 19);
            label1.Name = "label1";
            label1.Size = new Size(360, 50);
            label1.TabIndex = 0;
            label1.Text = "Customer's information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("AKbalthom Naga", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(156, 36);
            label2.TabIndex = 1;
            label2.Text = "Customer's ID ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("AKbalthom Naga", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(204, 36);
            label3.TabIndex = 2;
            label3.Text = "Customer's Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("AKbalthom Naga", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(184, 36);
            label4.TabIndex = 3;
            label4.Text = "Customer's Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 94);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "auto generate";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 27);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(29, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(368, 27);
            textBox4.TabIndex = 6;
            textBox4.Text = "search customer's name";
            textBox4.Click += textBox4_Click;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.save3_25px;
            button1.Location = new Point(440, 89);
            button1.Name = "button1";
            button1.Size = new Size(88, 32);
            button1.TabIndex = 8;
            button1.Text = "save";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.searchicon;
            button2.Location = new Point(399, 252);
            button2.Name = "button2";
            button2.Size = new Size(25, 23);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.edit3_25px;
            button3.Location = new Point(548, 89);
            button3.Name = "button3";
            button3.Size = new Size(111, 31);
            button3.TabIndex = 10;
            button3.Text = "update";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Green;
            button4.Image = Properties.Resources.addC_25px1;
            button4.Location = new Point(12, 31);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 11;
            button4.Text = "new";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(422, 155);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button5
            // 
            button5.Location = new Point(696, 91);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 13;
            button5.Text = "Close";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
    }
}