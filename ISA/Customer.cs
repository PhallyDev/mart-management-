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
    public partial class Customer : Form
    {
        A6 obj;
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        public Customer()
        {
            InitializeComponent();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.Text = "search customer's name here";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("inCustomer", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@cName", textBox2.Text);
            com.Parameters.AddWithValue("@cCon", textBox3.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("saved.");
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("GetAllCustomer", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("scus", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", textBox4.Text);
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            com = new SqlCommand("ucus",obj.con);
            com.CommandType= CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id",textBox1.Text);
            com.Parameters.AddWithValue("@name", textBox2.Text);
            com.Parameters.AddWithValue("@contact",textBox3.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("saved");

        }
    }
}
