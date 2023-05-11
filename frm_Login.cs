using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Username_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "Admin" && tb_Password.Text == "A123")
            {
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
            //MessageBox.Show("Login Successfull");
            //frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
            //obj.Show();
            //this.Hide();
        }
    }
}
