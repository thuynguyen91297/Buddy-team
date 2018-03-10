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
    public partial class FrmDashboard : Form
    {
        DatabaseUtils dbUtilsDashboard;
        private DataSet dsTask;

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

        /*
         *  event for cell in data gridview 
         */
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
            catch (Exception ex)
            {
                dbUtilsDashboard.errorMessage(208);
            }
        }

        /*
         * Click add task in Doard 
         * Show from add new task 
        */
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            FrmDialogAddTask frmDialogAdd = new FrmDialogAddTask();
            frmDialogAdd.ShowDialog(this);
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            /*try
            {
                SqlCommand cmd = new SqlCommand(TaskQuery.UPDATE_TASK, dbUtilsDashboard.getConnection());
                cmd.Parameters.AddWithValue("@IDCard", txtIdTask);
                cmd.Parameters.AddWithValue("@Title", txtTaskName);
                cmd.Parameters.AddWithValue("@IDList", txtNameList);
                cmd.Parameters.AddWithValue("@Descriptions", txtDescription);
                cmd.Parameters.AddWithValue("@beginDate", txtBeginDate);
                cmd.Parameters.AddWithValue("@endDate", txtEndDate);
                dbUtilsDashboard.executeNonQuery(TaskQuery.UPDATE_TASK);
                MessageBox.Show("Nice! Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh shit! You cann't update");
            }
            */
        }

        private void convertDate(string cdate, TextBox txtDate)
        {
            DateTime subDateTime = new DateTime();
            subDateTime = DateTime.ParseExact(cdate, "MM-dd-yyyy", null);
            string converted_date = subDateTime.ToString("dd-MM-yyyy");
            txtDate.Text = converted_date;
        }
    }
}
