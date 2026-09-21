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
    public partial class frmSupplier : Form
    {
        A6 obj;
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        public frmSupplier()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("dbo.usup",obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", textBox2.Text);
            com.Parameters.AddWithValue("@name",textBox3.Text);
            com.Parameters.AddWithValue("@address", textBox4.Text);
            com.Parameters.AddWithValue("@contact", textBox5.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("updated");
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("GetAllSupplier", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            com = new SqlCommand("inSupplier", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@supN", textBox3.Text);
            com.Parameters.AddWithValue("@supAdd", textBox4.Text);
            com.Parameters.AddWithValue("@supCon", textBox5.Text);
            MessageBox.Show("saved");
            com.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("sSup", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", textBox1.Text);
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dataGridView1.RowCount > 0)
            {
                i=e.RowIndex;
                if (i < 0) return;
               DataGridViewRow row=dataGridView1.Rows[i];
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();
                textBox5.Text = row.Cells[3].Value.ToString();

            }
        }
    }
}
