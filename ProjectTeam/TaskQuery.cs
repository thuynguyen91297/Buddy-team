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
            RETURN LIST, TASK FROM CARD
        */
        public static String GET_TASKS_FROM_CARD = "SELECT List.Title, IDCard, Cards.Title, Cards.Descriptions, [beginDate], [endDate] FROM [dbo].[Cards] INNER JOIN List ON List.IDList = Cards.IDList";


        /*
            RETURN USER NAME, PASSWORD FROM ACCOUNTUSER
        */
        public static String GetUserNameFromDatabase(string username, string password)
        {
            string ACCOUNT = "SELECT * FROM AccountUser WHERE email = '" + username + "' and password = '" + password;
            return ACCOUNT;
        }

        public static String GET_NAME_LIST = "SELECT [Title], [IDList] FROM [TasksManagement].[dbo].[List]";

        public static String UPDATE_TASK = "UPDATE [dbo].[Cards] SET [Title] = @TaskName, [IDList] = @IdList, [Descriptions] = @decription, [beginDate] = @beginDate, [endDate] = @endDate WHERE IDCard = @IDCard";

        public static String GetList(int idCard) => "SELECT [List].[IDList], [List].[Title] FROM [dbo].[List] INNER JOIN Cards ON [List].IDList = IDCard WHERE IDCard = "+ idCard;

        /*
         *
         */
         public static String DeleteTask(string idCard)
        {
            return "DELETE FROM [dbo].[Cards] WHERE IDCard = +"+ idCard;
        }

        public static String GET_LIST_DASHBOARD = "SELECT [Title], [IDBoard] FROM [dbo].[Board]";

        /*
         *  return string
         *  create insert query 
         *  param (<idboard>, <titleboard>)
         */
        public static String InsertNewDashboard(string titleBoard) => "INSERT INTO [dbo].[Board] ([Title]) VALUES ('" + titleBoard + "')";

        /*
         *  return string
         *  create insert query 
         *  param (<title>, <idlist>, <description>, <begin>, <end>)
         */
        public static String InsertNewTask(string title, string idList, string description, string begin, string end) => "INSERT INTO [dbo].[Cards] ([Title], [IDList], [Descriptions], [beginDate], [endDate]) VALUES ('"+title+"' ,'"+ int.Parse(idList)+"', '"+description+"','"+begin+"', '"+end+"')";
    }
}
