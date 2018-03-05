using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam
{
    public partial class FormInsert : Form
    {
        string sqlCom;
        DatabaseUtils dbUtils = new DatabaseUtils();

        public FormInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCom = "INSERT INTO [dbo].[AccountUser] ([ID],[email],[password]) VALUES ("+int.Parse(tbID.Text.Trim())+",'"+tbEmail.Text.Trim()+"', '"+tbPassword.Text.Trim()+"' )";
            if (dbUtils.executeNonQuery(sqlCom))
            {
                MessageBox.Show("Oke");
            }
            else
            {
                MessageBox.Show("Fail");
            }
            
        }
    }
}
