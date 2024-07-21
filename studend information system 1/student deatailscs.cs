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
    public partial class student_deatailscs : Form
    {
        public student_deatailscs()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public string str;
        private void labelsd_Click(object sender, EventArgs e)
        {

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {

            try
            {

                String qry = "INSERT INTO student (student_id,s_fname,s_lname,s_DOB,s_address,s_phone,s_course) VALUES ('" + textBoxstudentid.Text + "','" + textBoxfirstname.Text + "','" + textBoxlastname.Text + "','" + textBoxdob.Text + "','" + textBoxaddress.Text + "','" + textBoxcn.Text + "','" + comboBoxcourse.Text + "')";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                label1.ForeColor = Color.Green;
                label1.Text = "updated..";
            }
            catch (SqlException x)
            {
                MessageBox.Show("ERROR : " + x.Message);
            }
        }

        private void student_deatailscs_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxaddress.Clear();
            textBoxcn.Clear();
            textBoxdob.Clear();
            textBoxfirstname.Clear();
            textBoxlastname.Clear();
            textBoxstudentid.Clear();
            
        }
    }
}
