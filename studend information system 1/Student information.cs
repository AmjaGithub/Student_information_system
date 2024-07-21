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
    public partial class Student_information : Form
    {
        public SqlConnection con;//con=sql conection name
        public string str;//database path
        public SqlDataReader mdr;
        public Student_information()
        {
            InitializeComponent();
        }

        private void Student_information_Load(object sender, EventArgs e)
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

        private void buttonsr_Click(object sender, EventArgs e)
        {
            int i = 0;
            string qry;
            SqlCommand cmd;
            try
            {
                qry = "Select * from student where student_id='" + textBoxstudentid.Text + "'";
                cmd = new SqlCommand(qry, con);

                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    textBox1.Text = mdr["student_id"].ToString();
                    textBox2.Text = mdr["s_fname"].ToString();
                    textBox3.Text = mdr["s_lname"].ToString();
                    textBox4.Text = mdr["s_DOB"].ToString();
                    textBox5.Text = mdr["s_address"].ToString();
                    textBox6.Text = mdr["s_phone"].ToString();
                    textBox7.Text = mdr["s_course"].ToString();
                }

                else
                {
                    MessageBox.Show("Invalid index number");
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void labeldob_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelfirstname_Click(object sender, EventArgs e)
        {

        }
    }
}
