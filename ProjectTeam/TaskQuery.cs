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
        public static String GET_TASKS_FROM_CARD(int idDoard) => "SELECT List.Title, IDCard, Cards.Title, Cards.Descriptions, [beginDate], [endDate]" +
        " FROM[dbo].[Cards]" +
        " JOIN List ON List.IDList = Cards.IDList" +
        " JOIN Board ON List.IDBoard = Board.IDBoard" +
        " WHERE Board.IDBoard = '"+ idDoard +"'";

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

        public static String GetList(int idCard) => "SELECT [List].[IDList], [List].[Title] FROM [dbo].[List] INNER JOIN Cards ON [List].IDList = Cards.IDList WHERE IDCard = "+ idCard;

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

        public static String GetAccountUser(string email) => "SELECT [IDUser],[email],[password] FROM [dbo].[AccountUser] WHERE email = '" + email + "'";


        public static String InsertNewAccountUser(string email, string password) => "INSERT INTO[dbo].[AccountUser]([email],[password]) " +
                    "VALUES('" + email + "','" + password + "')";

        public static String GetAccountUserForLogin(string email, string pass) =>
            "SELECT COUNT(*) FROM [dbo].[AccountUser] WHERE email = '" + email + "' AND password = '"+ pass +"'";
    }
}
