namespace ISA
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            lbstaff = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbstaff
            // 
            lbstaff.AutoSize = true;
            lbstaff.Font = new Font("Khmer OS Siemreap", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbstaff.ForeColor = Color.DodgerBlue;
            lbstaff.Location = new Point(195, 38);
            lbstaff.Name = "lbstaff";
            lbstaff.Size = new Size(258, 50);
            lbstaff.TabIndex = 0;
            lbstaff.Text = "Staff's information";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Cursor = Cursors.Cross;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(705, 157);
            button2.Name = "button2";
            button2.Size = new Size(60, 27);
            button2.TabIndex = 16;
            button2.TextAlign = ContentAlignment.BottomLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.ForeColor = SystemColors.InactiveCaptionText;
            textBox2.Location = new Point(441, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 27);
            textBox2.TabIndex = 15;
            textBox2.Text = "search supplier's name here";
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Leave += textBox2_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 160);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 17;
            label1.Text = "staff's full name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(162, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 25);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 203);
            label2.Name = "label2";
            label2.Size = new Size(128, 31);
            label2.TabIndex = 19;
            label2.Text = "staff's gender";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(162, 130);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 27);
            textBox4.TabIndex = 22;
            textBox4.Text = "Auto generate";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 130);
            label3.Name = "label3";
            label3.Size = new Size(87, 31);
            label3.TabIndex = 21;
            label3.Text = "Staff's Id";
            label3.Click += label3_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(162, 209);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(288, 209);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 251);
            label4.Name = "label4";
            label4.Size = new Size(138, 31);
            label4.TabIndex = 25;
            label4.Text = "staff's birthday";
            label4.Click += label4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 251);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 284);
            label7.Name = "label7";
            label7.Size = new Size(137, 31);
            label7.TabIndex = 29;
            label7.Text = "staff's position";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(166, 284);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 27);
            textBox5.TabIndex = 3;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 320);
            label5.Name = "label5";
            label5.Size = new Size(121, 31);
            label5.TabIndex = 30;
            label5.Text = "staff's salary";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 325);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Khmer OS Siemreap", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 355);
            label6.Name = "label6";
            label6.Size = new Size(152, 31);
            label6.TabIndex = 32;
            label6.Text = "staff's stop work";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(174, 362);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(51, 24);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "yes";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(299, 362);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(47, 24);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "no";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.HotTrack;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(146, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 36;
            button1.Text = "save";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.MenuHighlight;
            button3.Image = Properties.Resources.edit_property2_25px;
            button3.Location = new Point(272, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 37;
            button3.Text = "update";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.Highlight;
            button4.Image = Properties.Resources.save11;
            button4.Location = new Point(16, 51);
            button4.Name = "button4";
            button4.Size = new Size(94, 37);
            button4.TabIndex = 38;
            button4.Text = "new";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.Highlight;
            button5.Location = new Point(31, 409);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 40;
            button5.Text = "close";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(391, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(397, 248);
            dataGridView1.TabIndex = 39;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(lbstaff);
            Name = "Staff";
            Text = "Staff";
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbstaff;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
    }
}