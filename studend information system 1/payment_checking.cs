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
    public partial class payment_Checking : Form
    {
        public SqlConnection con;
        public string str;
        public SqlDataReader mdr;
        public payment_Checking()
        {
            InitializeComponent();
        }
        Config o = new Config();
        private void labelspd_Click(object sender, EventArgs e)
        {

        }

        private void buttonok_Click(object sender, EventArgs e)
        {

            int i = 0;
            string qry;
            SqlCommand cmd;
            try
            {
                qry = "Select * from payment where student_id='" + textBoxesin.Text + "'";
                cmd = new SqlCommand(qry, con);

                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    if (textBoxesin.Text != "")
                    {
                        o.loadgrid("SELECT * FROM payment WHERE student_id LIKE '%" + textBoxesin.Text + "%' OR recepit_number LIKE '%" + textBoxesin.Text + "%' OR tuition_fees_paid LIKE '%" + textBoxesin.Text + "%' OR Date_Of_Receipt LIKE '%" + textBoxesin.Text + "%'", dataGridView1);
                    }
                    
                }

                else
                {
                    MessageBox.Show("Payment is not complete");
                }
                mdr.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void payment_Checking_Load(object sender, EventArgs e)
        {
            try
            {
                str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\student.mdf;Integrated Security=True;Connect Timeout=30";
                con = new SqlConnection();
                con.ConnectionString = str;
                con.Open();

            }
            catch (SqlException x)
            {
                MessageBox.Show("Error :" + x.Message);

            }
        }
    }
}
