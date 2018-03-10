using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTeam
{
    class Dashboard
    {
        private int idDashboard;
        private string dashboardName;

        public Dashboard(int idDashboard, string dashboardName)
        {
            this.idDashboard = idDashboard;
            this.dashboardName = dashboardName;
        }
        
        public void setIdDashboard(int idDashboard)
        {
            this.idDashboard = idDashboard;
        }

        public int getIdDashboard()
        {
            return this.idDashboard;
        }

        public void setDashboardName(string dashboardName)
        {
            this.dashboardName = dashboardName;
        }

        public string getDashboardName()
        {
            return this.dashboardName;
        }


    }
}
