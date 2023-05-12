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
    public partial class frm_Add_New_Student_Details : Form
    {
        public frm_Add_New_Student_Details()
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

        void clear_controls()
        {
            tb_FirstName.Clear();
            tb_LastName.Clear();
            tb_MobileNo.Clear();
            tb_RollNo.Clear();
            cmb_Courses.SelectedIndex = -1;

            tb_FirstName.Focus();
        }

        private void frm_Add_New_Student_Details_Load(object sender, EventArgs e)
        {
            clear_controls();
            tb_FirstName.Focus();
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
            frm_Student_List obj = new frm_Student_List();
            obj.Show();

            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_FirstName.Text != "" && tb_LastName.Text != "" && tb_MobileNo.Text != "" && tb_RollNo.Text != "" && cmb_Courses.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into Student_Details (Roll_No, First_Name, Last_Name, Mobile_No, Course) values (@RNo, @FName, @LName, @MNo, @Course)";
                cmd.Connection = Con;

                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RollNo.Text;
                cmd.Parameters.Add("FName", SqlDbType.VarChar).Value = tb_FirstName.Text;
                cmd.Parameters.Add("LName", SqlDbType.VarChar).Value = tb_LastName.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_MobileNo.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Courses.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record insert successfully.");

                clear_controls();
            }   
            else
            {
                MessageBox.Show("Fill out all fileds.");
            }

            Con_Close();
        }
    }
}
