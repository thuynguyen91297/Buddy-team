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

        
        public bool checkExistEmail()
        {

            string email = tbEmail.Text;
            string SQLStringSelect = " SELECT [email]FROM[dbo].[AccountUser]";
            Sqlcommands cmd = new Sqlcommands();
            SqlConnection con = new SqlConnection();
            cmd.getConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tồn tại");
                return true;
            }
            else
            {
                // chưa có
                return false ;
            }
        }



        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPassword.Text == "" || checkExistEmail()==true)
            {
                MessageBox.Show("Mời bạn nhập Email và Password đúng");
            }
            else
            {
                string SQLStringInsert = "INSERT INTO[dbo].[AccountUser]([email],[password]) VALUES('" + tbEmail.Text + "','" + tbPassword.Text + "')";
                SqlConnection scn = new SqlConnection();
                scn.ConnectionString = @"Data Source=DESKTOP-T73FOFC\SQLEXPRESS;Initial Catalog=BuddyTeam;Integrated Security=True";
                SqlCommand scmd = new SqlCommand(SQLStringInsert, scn);

                scmd.Parameters.Clear();
                scn.Open();
                try
                {
                    scmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
