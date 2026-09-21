using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
namespace ISA
{
    public partial class Import : Form
    {
        int stID;
        decimal price, amount;
        string supName;
        SqlCommand com;
        A6 obj;
        decimal Total = 0;
        public Import()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void importDetails_Load(object sender, EventArgs e)
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
            comboBox1.ValueMember = "stID";
            comboBox1.Text = null;

            SqlDataAdapter da1 = new SqlDataAdapter("SELECT supID, Supplier from tbSuppliers  ", obj.strCon);
            DataTable dt1;
            dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox2.DataSource = null;
            comboBox2.Items.Clear();
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "Supplier";
            comboBox2.ValueMember = "supID";
            comboBox2.Text = null;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "new")
            {
                listView1.Clear();
                listView1.View = View.Details;
                listView1.Columns.Add("ID", 50);
                listView1.Columns.Add("Name", 100);
                listView1.Columns.Add(" Qty", 40);
                listView1.Columns.Add("UnitPrice", 100);
                listView1.Columns.Add(" Amount", 100);
                Total = 0;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button5.Text = "cancel";
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button5.Text = "new";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.ShowDialog();
            this.Close();

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            stID = int.Parse(comboBox1.SelectedValue.ToString());
            com = new SqlCommand("SELECT FullName from tbStaffs where stID=" + stID, obj.con);

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                textBox3.Text = dr[0].ToString();

            }
            com.Dispose();
            dr.DisposeAsync();


        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

            textBox8.Text = comboBox2.SelectedValue.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {

            obj = new A6();
            obj.A6con();
            com = new SqlCommand("select ProName from tbProducts where ProCode=" + textBox5.Text, obj.con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox6.Text = dr[0].ToString();

                }
            }
            else
            {
                textBox6.Text = null;
            }
            com.Dispose();
            dr.DisposeAsync();
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            float amount, price;
            int qty;
            qty = int.Parse(textBox7.Text);
            price = float.Parse(textBox9.Text);
            amount = qty * price;
            textBox10.Text = amount.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lv = listView1.FindItemWithText(textBox5.Text);
            if (lv != null)
            {
                var qty = int.Parse(lv.SubItems[2].Text) + int.Parse(textBox7.Text);
                lv.SubItems[2].Text = qty.ToString();
                Total = Total - decimal.Parse(lv.SubItems[4].Text, NumberStyles.Currency);

                amount = qty * price;
                lv.SubItems[4].Text = string.Format("{0:c}", amount);
                Total = Total + amount;
            }
            else
            {
                ListViewItem item;
                string[] arr = new string[5];
                arr[0] = textBox5.Text;
                arr[1] = textBox6.Text;
                arr[2] = textBox7.Text;
                price = decimal.Parse(textBox9.Text);
                arr[3] = string.Format("{0:c}", price);
                amount = decimal.Parse(textBox7.Text) * decimal.Parse(textBox9.Text);
                arr[4] = string.Format("{0:c}", amount);
                item = new ListViewItem(arr);
                listView1.Items.Add(item);
                Total = Total + amount;
            }
            textBox11.Text = string.Format("{0:c}", Total);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("imD", typeof(string));
            dtMaster.Columns.Add("stid", typeof(int));
            dtMaster.Columns.Add("fn", typeof(string));
            dtMaster.Columns.Add("supID", typeof(int));
            dtMaster.Columns.Add("sn", typeof(string));
            dtMaster.Columns.Add("total", typeof(float));

            string imD = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            dtMaster.Rows.Add(DateTime.Parse(imD), comboBox1.Text, textBox3.Text, textBox8.Text,
                comboBox2.Text, Total);
            com = new SqlCommand("InImport", obj.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter pa1 = new SqlParameter();
            pa1.ParameterName = "@IM";
            pa1.SqlDbType = SqlDbType.Structured;
            pa1.Value = dtMaster;
            com.Parameters.Add(pa1);
            com.ExecuteNonQuery();
            MessageBox.Show("successed");
        }

        private void textBox9_Leave_1(object sender, EventArgs e)
        {
            int q = int.Parse(textBox7.Text);
            float p=float.Parse(textBox9.Text);
            textBox10.Text =(q*p).ToString();
        }
    }
}