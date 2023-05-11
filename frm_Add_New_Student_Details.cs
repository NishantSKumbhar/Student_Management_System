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
    public partial class frm_Add_New_Student_Details : Form
    {
        public frm_Add_New_Student_Details()
        {
            InitializeComponent();
        }

        public void clear_controls()
        {
            tb_FirstName.Clear();
            tb_LastName.Clear();
            tb_MobileNo.Clear();
            tb_RollNo.Clear();
            cmb_Courses.SelectedIndex = -1;

        }

        private void frm_Add_New_Student_Details_Load(object sender, EventArgs e)
        {
            clear_controls();
            tb_FirstName.Focus();
        }

        private void tb_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_RollNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_MobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }

       

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear_controls();
        }

        private void btn_ViewStudentList_Click(object sender, EventArgs e)
        {

        }
    }
}
