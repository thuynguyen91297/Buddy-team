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

namespace ProjectTeam
{
    public partial class FrmSignUp : Form
    {
        private DatabaseUtils dbUtils;

        public FrmSignUp()
        {
            InitializeComponent();
            dbUtils = new DatabaseUtils();
        }
        
        private bool checkExistEmail()
        {
            string email = tbEmail.Text;
            SqlDataReader dr = dbUtils.getDataReader(TaskQuery.GetAccountUser(email));
            if(dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*private void btnCreateAccount_Click(object sender, EventArgs e)
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
        } */

        void clear()
        {
            tbEmail.Text = tbPassword.Text = tbConfirmPassword.Text = "";
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //SqlConnection scn = dbUtils.getConnection();
            if (tbEmail.Text == "" || tbPassword.Text == "" || checkExistEmail()==true)
            {
                MessageBox.Show("Email bạn đăng kí đã được đăng kí, mời bạn đk lại bằng Email khác");
            }
            else
            {
                try
                {
                    dbUtils.executeNonQuery(TaskQuery.InsertNewAccountUser(tbEmail.Text, tbPassword.Text));
                    MessageBox.Show("Đăng kí tài khoản thành công, mời bạn đăng nhập để sử dụng ứng dụng");
                    new FrmLogIn().Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
