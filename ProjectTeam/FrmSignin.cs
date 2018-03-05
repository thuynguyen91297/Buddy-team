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
        DatabaseUtils dbUtils = new DatabaseUtils();
        DataSet ds = new DataSet();

        SqlDataReader reader = null;

        SqlCommand sqlCom;

        MainForm mainDashboard;
        public FrmLogIn()
        {
            InitializeComponent();
        }
        
        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;

            if (dbUtils.open())
            {
                sqlCom = new SqlCommand(TaskQuery.getUserNameFromDatabase(username, password), dbUtils.getConnection());
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
                    if(tbUserName.Text == reader["username"].ToString() && tbPassword.Text == reader["password"].ToString())
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

        private void lbCreatAcc_Click(object sender, EventArgs e)
        {
            FrmSignUp fm = new FrmSignUp();
            fm.Show();
        }

    }

}