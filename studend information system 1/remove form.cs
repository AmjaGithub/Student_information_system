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
    public partial class remove_form : Form
    {
        SqlConnection con;
        SqlCommandBuilder builder;
        SqlDataAdapter da;
        DataSet ds;
        public SqlDataReader mdr;
        public remove_form()
        {
            InitializeComponent();
            String str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\student.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(str);
        }
        Config o = new Config();

        private void remove_form_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("SELECT * FROM student", con);
            builder = new SqlCommandBuilder(da);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

 
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Name = "Delete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                if ((MessageBox.Show("Confirm Date ?", "Delete", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables[0]);
                MessageBox.Show("Data Updated...!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
