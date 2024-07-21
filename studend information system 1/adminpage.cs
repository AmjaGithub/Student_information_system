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
    public partial class adminpage : Form
    {
        public adminpage()
        {
   
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonstr_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            student_deatailscs b = new student_deatailscs();
            b.ShowDialog();
        }
    }
}
