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
            }
            catch (Exception ex)
            {
                dbUtilsDashboard.errorMessage(208);
            }
            
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvTasks.Rows[rowIndex];
            try
            {
                // dbUtilsDashboard.load_comboBox();
                txtNameList.Text = row.Cells[0].Value.ToString();
                txtIdTask.Text = row.Cells[1].Value.ToString();
                txtTaskName.Text = row.Cells[2].Value.ToString();
                txtDescription.Text = row.Cells[3].Value.ToString();
                txtBeginDate.Text = row.Cells[4].Value.ToString();
                txtEndDate.Text = row.Cells[5].Value.ToString();
            }
            catch(Exception ex)
            {
                dbUtilsDashboard.errorMessage(208);
            }
            

        }

    }
}
