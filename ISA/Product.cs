using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ISA
{
    public partial class Product : Form
    {
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        A6 obj;
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("GetAllProduct", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox7.Text = "search product's name here";
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("inProduct", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@proCode", textBox1.Text);
            com.Parameters.AddWithValue("@name", textBox2.Text);
            com.Parameters.AddWithValue("@qty", textBox3.Text);
            com.Parameters.AddWithValue("@upis", textBox4.Text);
            com.Parameters.AddWithValue("@sup", textBox5.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("saved");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("sPro", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", textBox7.Text);
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dataGridView1.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;
                DataGridViewRow row = dataGridView1.Rows[i];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("dbo.uPro", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@code", textBox1.Text);
            com.Parameters.AddWithValue("@name", textBox2.Text);
            com.Parameters.AddWithValue("@qty", textBox3.Text);
            com.Parameters.AddWithValue("@upis", textBox4.Text);
            com.Parameters.AddWithValue("@sup", textBox5.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("updated");
        }
    }
}
