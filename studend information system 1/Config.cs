using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace studend_information_system_1
{
    class Config
    {
        
     public SqlConnection con;
        public string str;

       public  Config ()
        {
            try
            {
                 str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\student.mdf;Integrated Security=True;Connect Timeout=30";
                 con = new SqlConnection (str);
                 con.Open();
                 

            }
            catch(SqlException x)
            {
                MessageBox.Show("ERROR" + x.Message);
            }
       }
            public void loadgrid(string qry, DataGridView grid)
       {
           SqlDataAdapter da = new SqlDataAdapter();
           DataSet ds = new DataSet();
           SqlCommand cmd = new SqlCommand(qry, con);
           da.SelectCommand = cmd;
           da.Fill(ds);
           grid.DataSource = ds.Tables[0];
           da.Dispose();
           cmd.Dispose();
       }

        
      
    }
    
}
