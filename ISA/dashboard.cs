using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;
namespace ISA
{

    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            A6 obj = new A6();
            obj.A6con();
            SqlCommand com = new SqlCommand("dasboard", obj.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@ns",SqlDbType.Int).Direction = ParameterDirection.Output;
            com.Parameters.Add("@ts", SqlDbType.Float).Direction = ParameterDirection.Output;
            com.Parameters.Add("@np",SqlDbType.Int).Direction= ParameterDirection.Output;
            com.Parameters.Add("@tq", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.Parameters.Add("@gt", SqlDbType.Float).Direction = ParameterDirection.Output;
            com.Parameters.Add("@nsu", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.Parameters.Add("@nc", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();
            var ns = int.Parse(com.Parameters["@ns"].Value.ToString());
            var ts = float.Parse(com.Parameters["@ts"].Value.ToString());
            var np = int.Parse(com.Parameters["@np"].Value.ToString());
            var tq = int.Parse(com.Parameters["@tq"].Value.ToString());
            var gt = float.Parse(com.Parameters["@gt"].Value.ToString());
            var nsu = int.Parse(com.Parameters["@nsu"].Value.ToString());
            var nc = int.Parse(com.Parameters["@nc"].Value.ToString());

            txbnumstaff.Text=ns.ToString();
            txbTotalsalary.Text = ts.ToString();
            txbNumProduct.Text = np.ToString();
            txbTotalQty.Text = tq.ToString();
            txbGrandTotal.Text = gt.ToString();
            TxbNumSup.Text = nsu.ToString();
            txbNumCus.Text = nc.ToString();

        }
    }
}
