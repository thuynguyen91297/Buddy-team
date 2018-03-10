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
    public partial class FrmLogIn : Form
    {
<<<<<<< HEAD
        DatabaseUtils dbUtils = new DatabaseUtils();
        DataSet ds = new DataSet();

        SqlDataReader reader = null;

        SqlCommand sqlCom;

        MainForm mainDashboard;
=======
        Sqlcommands cmd = new Sqlcommands();
>>>>>>> origin/login
        public FrmLogIn()
        {
            InitializeComponent();
        }
        
<<<<<<< HEAD
        private void btLogin_Click(object sender, EventArgs e)
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
=======
        private bool check(string email, string password)
        {
            

            string[] para = { "email", "password" };
            string[] values = { email, password };
            if(cmd.getDataTableStoredProcedure(para,values,"USP_Login" ).Rows.Count>0)
            {
                return true;
            }
            return false;
        }

        static int attempt = 5;
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ email, password vào nhé");
            }
            else
            {
                if (check (tbUserName.Text,tbPassword.Text))
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                MessageBox.Show("Sai tên Tài khoản rồi nhaaaaaa");
>>>>>>> origin/login
                }
            }
        }
        FrmSignUp fm = new FrmSignUp();

        private void lbCreatAcc_Click(object sender, EventArgs e)
        {
            //this.Hide();
            fm.Show();
        }

<<<<<<< HEAD
=======
        
>>>>>>> origin/login
    }

}