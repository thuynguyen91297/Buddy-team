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
<<<<<<< HEAD

=======
using System.Data;
>>>>>>> origin/login
namespace ProjectTeam
{
    public partial class FrmSignUp : Form
    {
        DatabaseUtils dbUtils = new DatabaseUtils();
        string sqlRegister = null;
        
        SqlCommand sqlComm;

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

<<<<<<< HEAD
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if(tbEmail.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please fill fields!");
            }
            else
            {
                if(tbConfirmPassword.Text != tbPassword.Text)
                {
                    MessageBox.Show("Password is not match");
                }
                else
                {
                    sqlRegister = "INSERT INTO AccountUser(ID, Email, Password) VALUES ('"+ 5 +"', '"+ tbEmail.Text.Trim() + "', '" + tbPassword.Text.Trim() + "')";
                    dbUtils.open();
                    sqlComm = new SqlCommand(sqlRegister, dbUtils.getConnection());
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Register successfull");
                    clear();
                }
            }
        }

        void clear()
        {
            tbEmail.Text = tbPassword.Text = tbConfirmPassword.Text = "";
        }

=======
        

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
                    this.Hide();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Hide() ;
        }
>>>>>>> origin/login
    }
}
