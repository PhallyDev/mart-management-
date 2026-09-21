using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ISA
{

    public partial class OrderDetails : Form
    {
        decimal price, amount;
        decimal Total = 0;
        decimal p, t;
        int qty;
        A6 obj = new A6();
        SqlDataReader dr;
        SqlCommand com;
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("select ProName from tbProducts where ProCode=" + textBox2.Text, obj.con);
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
            com.Dispose();
            dr.DisposeAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.ShowDialog();
            this.Close();
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            qty = int.Parse(textBox4.Text);
            p = decimal.Parse(textBox9.Text);
            t = qty * p;
            textBox10.Text = t.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox9.Text = null;
            textBox10.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value=DateTime.Now;
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add(" Qty", 40);
            listView1.Columns.Add("UnitPrice", 100);
            listView1.Columns.Add(" Amount", 100);
        }

        private void textbox5_leave(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();
            com = new SqlCommand("select FullName from tbStaffs where stID=" + textBox5.Text, obj.con);
            dr = com.ExecuteReader();
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

        private void textBox7_Leave(object sender, EventArgs e)
        {
            obj = new A6();
            obj.A6con();

            com = new SqlCommand(
                "SELECT cusID FROM tbCustomers WHERE cusName = @name",
                obj.con
            );

            com.Parameters.AddWithValue("@name", textBox7.Text);

            dr = com.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    textBox8.Text = dr[0].ToString();
                }
            }
            else
            {
                textBox8.Text = "";
            }

            dr.Close();
            com.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("orD", typeof(string));
            dtMaster.Columns.Add("stid", typeof(int));
            dtMaster.Columns.Add("fn", typeof(string));
            dtMaster.Columns.Add("cid", typeof(int));
            dtMaster.Columns.Add("cName", typeof(string));
            dtMaster.Columns.Add("total", typeof(float));


            string orD = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            dtMaster.Rows.Add(DateTime.Parse(orD), textBox5.Text, textBox6.Text, textBox8.Text,
                textBox7.Text, Total);
            com = new SqlCommand("InsOrder", obj.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter pa1 = new SqlParameter();
            pa1.ParameterName = "@OR";
            pa1.SqlDbType = SqlDbType.Structured;
            pa1.Value = dtMaster;
            com.Parameters.Add(pa1);
            com.ExecuteNonQuery();
            MessageBox.Show("successed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem lv = listView1.FindItemWithText(textBox2.Text);
            if (lv != null)
            {
                var qty = int.Parse(lv.SubItems[2].Text) + int.Parse(textBox4.Text);
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
                arr[0] = textBox2.Text;
                arr[1] = textBox3.Text;
                arr[2] = textBox4.Text;
                price = decimal.Parse(textBox9.Text);
                arr[3] = string.Format("{0:c}", price);
                amount = decimal.Parse(textBox4.Text) * decimal.Parse(textBox9.Text);
                arr[4] = string.Format("{0:c}", amount);
                item = new ListViewItem(arr);
                listView1.Items.Add(item);
                Total = Total + amount;
            }
        }
    }
    
}
