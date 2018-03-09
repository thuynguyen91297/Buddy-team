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
using System.Data;
namespace ProjectTeam
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }
        
        string ConnectionString = @"Data Source=DESKTOP-T73FOFC\SQLEXPRESS;Initial Catalog=BuddyTeam;Integrated Security=True";
        
        private bool checkExistEmail()
        {
            SqlConnection scn = new SqlConnection(ConnectionString);
            string email = tbEmail.Text;
            string SQLStringSelect = " Select * from AccountUser where email = '" + email + "'";
            SqlCommand cmd = new SqlCommand(SQLStringSelect,scn); scn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection(ConnectionString);
            if (tbEmail.Text == "" || tbPassword.Text == "" || checkExistEmail()==true)
            {
                MessageBox.Show("Email bạn đăng kí đã được đăng kí, mời bạn đk lại bằng Email khác");
            }
            else
            {
                string SQLStringInsert = "INSERT INTO[dbo].[AccountUser]([email],[password]) " +
                    "VALUES('" + tbEmail.Text + "','" + tbPassword.Text + "')";
                 SqlCommand scmd = new SqlCommand(SQLStringInsert, scn);

                scmd.Parameters.Clear();
                scn.Open();
                try
                {
                    scmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí tài khoản thành công, mời bạn đăng nhập để sử dụng ứng dụng");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
