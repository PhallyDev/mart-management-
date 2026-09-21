using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISA
{
    public partial class Staff : Form
    {
        A6 obj;
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        public Staff()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("sSta", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", textBox2.Text);
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("dbo.GetAllStaff", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            obj.A6con();
            com = new SqlCommand("inStaff", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sId", textBox4.Text);
            com.Parameters.AddWithValue("@sN", textBox1.Text);
            if (radioButton1.Checked == true)
            {
                com.Parameters.AddWithValue("@g", 'M');
            }
            else
            {
                com.Parameters.AddWithValue("@g", 'F');
            }
            com.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            com.Parameters.AddWithValue("@po", textBox5.Text);
            com.Parameters.AddWithValue("@sa", textBox3.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("saved");


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            if (i < 0) return;
            DataGridViewRow row = dataGridView1.Rows[i];
            textBox4.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "M")
            {
                radioButton1.Checked = true;
            }
            else
                radioButton2.Checked = true;
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value);
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox3.Text = row.Cells[5].Value.ToString();
            radioButton4.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("dbo.uSta", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", textBox4.Text);
            com.Parameters.AddWithValue("@name", textBox1.Text);
            if (radioButton1.Checked == true)
            {
                com.Parameters.AddWithValue("@gen", 'M');
            }
            else
            {
                com.Parameters.AddWithValue("@gen", 'F');
            }
            com.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
            com.Parameters.AddWithValue("@po", textBox5.Text);
            com.Parameters.AddWithValue("@sa", textBox3.Text);
            if (radioButton3.Checked == true)
            {
                com.Parameters.AddWithValue("@stop", 1);
            }
            else
            {
                com.Parameters.AddWithValue("@stop", 0);
            }
            com.ExecuteNonQuery();
            MessageBox.Show("updated");

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
