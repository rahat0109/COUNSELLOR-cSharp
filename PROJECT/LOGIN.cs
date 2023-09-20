using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PROJECT
{
    public partial class LOGIN : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["loginformcs"].ConnectionString;
        public LOGIN()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                String query = "select * from login_tbl where username = @user and pass = @pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                con.Open();
                SqlDataReader sda = cmd.ExecuteReader();
                if (sda.HasRows == true)
                {
                    MessageBox.Show("Login successful", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    INTRO f4 = new INTRO();
                    f4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill the feild", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Login successful", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.Icon = Properties.Resources.error;
                errorProvider1.SetError(this.textBox1, "Fill the feild");

            }
            else
            {
                errorProvider1.Icon = Properties.Resources.check;
                //errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider2.Icon = Properties.Resources.error;
                errorProvider2.SetError(this.textBox2, "Fill the feild");

            }
            else
            {
                errorProvider2.Icon = Properties.Resources.check;
                //errorProvider2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f2 = new Form11();
            f2.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
