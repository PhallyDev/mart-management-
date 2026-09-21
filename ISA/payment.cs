using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging.Effects;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace ISA
{
    public partial class Payment : Form
    {
        A6 obj = new A6();
        SqlDataReader dr;
        SqlCommand com;
        public Payment()
        {
            InitializeComponent();

            obj.A6con();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          com=new SqlCommand("InPayment",obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("pd",dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            com.Parameters.AddWithValue("id",int.Parse( comboBox1.Text));
            com.Parameters.AddWithValue("@fn",textBox3.Text);
            com.Parameters.AddWithValue("@oid", int.Parse(comboBox2.Text));

            com.Parameters.AddWithValue("@de", float.Parse(textBox5.Text));
            com.Parameters.AddWithValue("@am",float.Parse(textBox6.Text));
            com.ExecuteNonQuery();
            MessageBox.Show("saved");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            obj.A6con();
            com = new SqlCommand("select FullName from tbStaffs where stID=" + textBox3.Text, obj.con);
            dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox3.Text = dr[0].ToString();
                }
            }
            else
            {
                textBox3.Text = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
        }

        private void Payment_Load(object sender, EventArgs e)
        {

            obj = new A6();
            obj.A6con();
            SqlDataAdapter da = new SqlDataAdapter("SELECT stID,FullName from tbStaffs where stopWork is NULL ", obj.strCon);
            DataTable dt;
            dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "stID";
            comboBox1.ValueMember = "FullName";
            comboBox1.Text = null;

            com = new SqlCommand("SELECT OrID,Amount,Sum(Deposit) as Total from tbPayments GROUP BY OrID,"
                + "Amount HAVING Sum(Deposit)< Amount OR SUM(Deposit) is NULL ", obj.con);
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = null;
            comboBox2.Items.Clear();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "OrID";
            comboBox2.ValueMember = "OrID";
            comboBox2.Text = null;

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.SelectedValue.ToString();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int oID;
            oID = int.Parse(comboBox2.SelectedValue.ToString());
            com = new SqlCommand(
                    "SELECT deposit, Total, total - deposit " +
                     "FROM dbo.tbOrders i " +
                    "INNER JOIN dbo.tbPayments p ON i.OrID = p.OrID " +
                    "WHERE i.OrID = @id",
                    obj.con);

            com.Parameters.AddWithValue("@id", oID);

            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                textBox5.Text = dr[0].ToString();
                textBox6.Text = dr[1].ToString();
                textBox7.Text = dr[2].ToString();
            }
            dr.DisposeAsync();
            dr.DisposeAsync();
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            decimal t = 0, d = 0, r = 0;

            decimal.TryParse(textBox5.Text, out d);
            decimal.TryParse(textBox6.Text, out t);

            r = t - d;

            textBox7.Text = r.ToString();
        }
    }
}
