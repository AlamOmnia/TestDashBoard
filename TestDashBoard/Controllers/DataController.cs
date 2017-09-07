using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Helpers;
using TestDashBoard.Models;
using System.Data;

namespace TestDashBoard.Controllers
{
    public class DataController : ApiController
    {
       //  List<> phones = new List<Phone>();
        public DataTable Get()
        {
            var dataTable = new DataTable();
            string MyConString = @"Server=192.168.2.225;User Id=root;password=Takay1#$ane;Persist Security Info=True;default command timeout=3600;database=platinum";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = Resource.query;
            connection.Open();
            using (var dataReader = command.ExecuteReader())
            {
                dataTable.Load(dataReader);
            }




            //MySqlCommand command = DatabaseHelper.Instance.CreateCommand();
           // string sql = Resource.query;
            //command.CommandText = sql;
            //var dataReader = command.ExecuteReader();
            
          // List<DashBoardList> newPhones = dataReader.ToString().ToList();

            return dataTable;
        }
    }
}
