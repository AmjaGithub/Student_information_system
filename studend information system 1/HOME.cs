using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studend_information_system_1
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void buttonstr_Click(object sender, EventArgs e)
        {
            student_deatailscs a = new student_deatailscs();
            a.Show();
            
        }

        private void buttonsi_Click(object sender, EventArgs e)
        {
            Student_information b = new Student_information();
            b.Show();
        }

        private void buttonrs_Click(object sender, EventArgs e)
        {
            remove_form a = new remove_form();
            a.Show();
        }

        private void buttonpd_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonpd_Click_1(object sender, EventArgs e)
        {
            payment_confirm a = new payment_confirm();
            a.Show();
        }

        private void btnpc_Click(object sender, EventArgs e)
        {
            payment_Checking a = new payment_Checking();
            a.Show();
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }
    }
}
