namespace ISA
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Siemreap", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 50);
            label1.TabIndex = 0;
            label1.Text = "Supplier's information";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 130);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 1;
            label2.Text = "company's name";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(3, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "search supplier's name here";
            textBox1.Click += textBox1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(611, 94);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(255, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.AcceptsReturn = true;
            textBox3.Location = new Point(602, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(264, 27);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.AcceptsTab = true;
            textBox4.Location = new Point(602, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.AcceptsTab = true;
            textBox5.Location = new Point(611, 203);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(255, 27);
            textBox5.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Image = Properties.Resources.edit_property_25px;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(639, 278);
            button2.Name = "button2";
            button2.Size = new Size(118, 35);
            button2.TabIndex = 9;
            button2.Text = "update";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.HotTrack;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(538, 278);
            button3.Name = "button3";
            button3.Size = new Size(85, 35);
            button3.TabIndex = 10;
            button3.Text = "save";
            button3.TextAlign = ContentAlignment.BottomLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 101);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 11;
            label3.Text = "supplier's id";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 167);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 12;
            label4.Text = "Company's address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 210);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 13;
            label5.Text = "Company's contact";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Cross;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(372, 198);
            button1.Name = "button1";
            button1.Size = new Size(60, 28);
            button1.TabIndex = 14;
            button1.TextAlign = ContentAlignment.BottomLeft;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.Highlight;
            button4.Image = Properties.Resources.save11;
            button4.Location = new Point(12, 22);
            button4.Name = "button4";
            button4.Size = new Size(94, 37);
            button4.TabIndex = 16;
            button4.Text = "new";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(504, 204);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.Highlight;
            button5.Location = new Point(772, 278);
            button5.Name = "button5";
            button5.Size = new Size(94, 35);
            button5.TabIndex = 18;
            button5.Text = "close";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(878, 462);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSupplier";
            Text = "form Supplier";
            Load += frmSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
    }
}