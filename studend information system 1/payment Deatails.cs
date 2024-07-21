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
    public partial class payment_confirm : Form
    {
        public payment_confirm()
        {
            InitializeComponent();
        }
        Config o = new Config();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelname_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxname.Clear();
            textBoxrn.Clear();
            textBoxtfp.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String qry = "INSERT INTO Payment (student_id,recepit_number,tuition_fees_paid,Date_Of_Receipt) VALUES ('" + textBoxname.Text + "','" + textBoxrn.Text + "','" + textBoxtfp.Text + "','" + dateTimePicker1.Value.Date + "')";
                SqlCommand cmd = new SqlCommand(qry, o.con);
                cmd.ExecuteNonQuery();
                label1.ForeColor = Color.Green;
                label1.Text = "updated..";
            }
            catch (SqlException x)
            {
                MessageBox.Show("ERROR : " + x.Message);
            }
        }

        private void payment_confirm_Load(object sender, EventArgs e)
        {

        }
    }
}
