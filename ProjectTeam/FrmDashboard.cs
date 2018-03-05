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
    public partial class FrmDashboard : Form
    {
        DatabaseUtils dbUtilsDashboard;
        DataSet dsTask;

        public FrmDashboard()
        {
            InitializeComponent();
            dbUtilsDashboard = new DatabaseUtils();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            if (dbUtilsDashboard.open())
            {
                loadListTask();
                dbUtilsDashboard.close();
            }
            else
            {
                MessageBox.Show("Fail! Cant't load datagridview");
            }
        }

        private void loadListTask()
        {
            try
            {
                dsTask = dbUtilsDashboard.getDataSet(TaskQuery.GET_TASKS_FROM_CARD);
                dbUtilsDashboard.load_dgv(TaskQuery.GET_TASKS_FROM_CARD, dsTask, dgvTasks);
                //dgvTasks.DataSource = dsTask;
                //dgvTasks.DataMember = dsTask.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(dbUtilsDashboard.g)
            }
            
        }
    }
}
