
namespace ISA
{
    partial class Payment
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
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Khmer OS Siemreap", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(282, 18);
            label1.Name = "label1";
            label1.Size = new Size(253, 41);
            label1.TabIndex = 0;
            label1.Text = "Payment's infomation";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(57, 115);
            label2.Name = "label2";
            label2.Size = new Size(171, 36);
            label2.TabIndex = 1;
            label2.Text = "Payment's code";
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(223, 120);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Auto Generate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InactiveCaptionText;
            label3.Location = new Point(396, 120);
            label3.Name = "label3";
            label3.Size = new Size(58, 36);
            label3.TabIndex = 3;
            label3.Text = "date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(460, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.InactiveCaptionText;
            label4.Location = new Point(114, 175);
            label4.Name = "label4";
            label4.Size = new Size(103, 36);
            label4.TabIndex = 5;
            label4.Text = "Staff's ID";
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.InactiveCaptionText;
            textBox3.Location = new Point(537, 175);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            textBox3.Text = "Auto generate";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.InactiveCaptionText;
            label5.Location = new Point(396, 175);
            label5.Name = "label5";
            label5.Size = new Size(135, 36);
            label5.TabIndex = 7;
            label5.Text = "staff's name";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.InactiveCaptionText;
            label6.Location = new Point(76, 237);
            label6.Name = "label6";
            label6.Size = new Size(141, 36);
            label6.TabIndex = 9;
            label6.Text = "Order's Code";
            // 
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.InfoText;
            textBox5.Location = new Point(392, 271);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(88, 27);
            textBox5.TabIndex = 12;
            textBox5.Leave += textBox5_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.InactiveCaptionText;
            label7.Location = new Point(392, 232);
            label7.Name = "label7";
            label7.Size = new Size(88, 36);
            label7.TabIndex = 11;
            label7.Text = "Deposit";
            // 
            // textBox6
            // 
            textBox6.ForeColor = SystemColors.InfoText;
            textBox6.Location = new Point(514, 271);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(87, 27);
            textBox6.TabIndex = 14;
            textBox6.Leave += textBox6_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.InactiveCaptionText;
            label8.Location = new Point(514, 232);
            label8.Name = "label8";
            label8.Size = new Size(58, 36);
            label8.TabIndex = 13;
            label8.Text = "total";
            // 
            // textBox7
            // 
            textBox7.ForeColor = SystemColors.InfoText;
            textBox7.Location = new Point(648, 271);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(99, 27);
            textBox7.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.InactiveCaptionText;
            label9.Location = new Point(648, 232);
            label9.Name = "label9";
            label9.Size = new Size(99, 36);
            label9.TabIndex = 15;
            label9.Text = "Remains";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.MenuText;
            button1.Image = Properties.Resources.clear_symbol_25px;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(460, 367);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 17;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = Properties.Resources.addC_25px2;
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.Location = new Point(578, 367);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.MenuText;
            button4.Image = Properties.Resources.clear_symbol_25px;
            button4.ImageAlign = ContentAlignment.TopLeft;
            button4.Location = new Point(676, 30);
            button4.Name = "button4";
            button4.Size = new Size(112, 29);
            button4.TabIndex = 70;
            button4.Text = "close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(223, 180);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 71;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(220, 241);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 72;
            comboBox2.SelectionChangeCommitted += comboBox2_SelectionChangeCommitted;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Payment";
            Text = "payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}