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
    public partial class FrmLogIn : Form
    {
        DatabaseUtils dbUtils;
        Sqlcommands cmd;
        static int attempt = 5;
        FrmSignUp fm = new FrmSignUp();
        MainForm mainForm;

        public FrmLogIn()
        {
            InitializeComponent();
            dbUtils = new DatabaseUtils();
        }

       /* private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;

            if (dbUtils.open())
            {
                sqlCom = new SqlCommand(TaskQuery.GetUserNameFromDatabase(username, password), dbUtils.getConnection());
            }
            else
            {
                MessageBox.Show("Failed");
            }
            if (string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please enter the field in form");
                this.tbUserName.Focus();
                this.tbPassword.Focus();
                return;
            }
            else
            {
                reader = sqlCom.ExecuteReader();
                while (reader.Read())
                {
                    if (tbUserName.Text == reader["username"].ToString() && tbPassword.Text == reader["password"].ToString())
                    {
                        MessageBox.Show("Login successfully");
                        mainDashboard = new MainForm();
                        mainDashboard.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username password!");
                    }
                }
            }
        }
        */
        private void verifyEmailAndPassword()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(TaskQuery.GetAccountUserForLogin(tbUserName.Text, tbPassword.Text), dbUtils.getConnection());
            DataTable dbTable = new DataTable();
            adapter.Fill(dbTable);
            if(dbTable.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login successful! Please use our app");
                this.Hide();
                mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Please login again!");
            }
        }

        private void lbCreatAcc_Click(object sender, EventArgs e)
        {
            this.Close();
            fm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please enter your username!");
                tbUserName.Focus();
            }else if(tbPassword.Text == "")
            {
                MessageBox.Show("Please enter your password!");
                tbPassword.Focus();
            }
            else
            {
                verifyEmailAndPassword();
            }
        }
    }

}