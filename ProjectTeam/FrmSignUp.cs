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
        DatabaseUtils dbUtils = new DatabaseUtils();
        string sqlRegister = null;
        
        SqlCommand sqlComm;

        public FrmSignUp()
        {
            InitializeComponent();
        }

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

    }
}
