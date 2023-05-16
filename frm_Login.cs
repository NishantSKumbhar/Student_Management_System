using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        

        

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand scmd = new SqlCommand("select count(*) from Login_Details where Username = @unm and Password = @pwd", Con);
            scmd.Parameters.Add("unm", SqlDbType.NVarChar).Value = tb_Username.Text;
            scmd.Parameters.Add("pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            int cnt = Convert.ToInt32(scmd.ExecuteScalar());

            if (cnt > 0)
            {
                MessageBox.Show("Login Successfull");

                SharedContent.Username = tb_Username.Text;

                frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "Please enter valid credentials";
            }

            tb_Username.Text = "";
            tb_Password.Clear();
            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            Con_Close();
        }

        private void tb_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar)     // Allowing only any letter OR Digit

            || e.KeyChar == '\b')                 // Allowing BackSpace character

            {

                e.Handled = false;

            }

            else

            {

                e.Handled = true;

            }
        }
    }
}
