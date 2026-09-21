using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace ISA
{
    public class A6
    {
        public String strCon = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=A6y32026 ;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";

        public SqlConnection con;
        public  void A6con()
        {
            con = new SqlConnection(strCon);
            con.Open();
        }


    }
}
