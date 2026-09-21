using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ISA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer cus = new Customer();
            cus.ShowDialog();
            this.Close();
        }

        private void pro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product p = new Product();
            p.ShowDialog();
            this.Close();
        }

        private void Sup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupplier sup = new frmSupplier();
            sup.ShowDialog();
            this.Close();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff st = new Staff();
            st.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard d = new dashboard();
            d.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Import p = new Import();
            p.ShowDialog();
            this.Close();

        }

        private void order_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDetails order = new OrderDetails();
            order.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment p = new Payment();
            p.ShowDialog();
            this.Close();
        }
    }
}
