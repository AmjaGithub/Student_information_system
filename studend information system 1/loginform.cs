using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studend_information_system_1
{
    public partial class loginform : Form
    {
        public SqlConnection con;//con=sql conection name
        public string str;//database path

        public loginform()
        {
            InitializeComponent();
        }
        

        private void labelpassword_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            

            try
            {
                string qry = "SELECT user_name, s_password FROM admin WHERE user_name='" + textBoxusername.Text+"' AND s_password='"+textBoxpassword.Text+"'";
                SqlCommand cmd = new SqlCommand(qry, con);//qry+con=cmd(sql objective)
                SqlDataReader dr = cmd.ExecuteReader(); //

                if (dr.Read())
                {
                    con.Close();
                    HOME a = new HOME();
                    this.Dispose(false);
                    a.Show();
                }
                else
                {
                    errorlb.ForeColor = Color.Red;
                    errorlb.Text = "Invalid User name and password";
                }
                dr.Close();
            }
            catch(SqlException x)
            {
                MessageBox.Show("ERROR:" + x.Message);
            }
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            try
            {
                str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\student.mdf;Integrated Security=True;Connect Timeout=30";
                con = new SqlConnection();
                con.ConnectionString = str;
                con.Open();//sql openpanrathu
                
            }
            catch(SqlException x)
            {
                MessageBox.Show("Error :" + x.Message);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
