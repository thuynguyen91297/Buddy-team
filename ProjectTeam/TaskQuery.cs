using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTeam
{
    class TaskQuery
    {
        /*
            RETURN LIST, TASK FROM CARD
        */
        public static String GET_TASK_FROM_CARD = "SELECT Title, Descriptions, beginDate, endDate FROM Cards";


        /*
            RETURN USER NAME, PASSWORD FROM ACCOUNTUSER
        */
        public static String getUserNameFromDatabase(string username, string password)
        {
            string ACCOUNT = "SELECT * FROM AccountUser WHERE email = '" + username + "' and password = '" + password;
            return ACCOUNT;
        }
    }
}
