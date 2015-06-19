using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ExamProject.DAL.DAO;

namespace ExamProject.DAL.Gateway
{
    public class CatagoryGateway
    {
        Gateway aGateway= new Gateway();

        public List<Catagory> GetCatagoryList()
        {
            List<Catagory> catagoryList=new List<Catagory>();
            string query = "SELECT * FROM Catagory_tbl";
            aGateway.command.CommandText = query;
            aGateway.sqlConnection.Open();
            SqlDataReader reader = aGateway.command.ExecuteReader();
            while (reader.Read())
            {
                Catagory catagory=new Catagory();
                catagory.ID = int.Parse(reader[0].ToString());
                catagory.Name = reader[1].ToString();
                catagoryList.Add(catagory);
            }
            reader.Close();
            aGateway.sqlConnection.Close();
            return catagoryList;
        }

      
    }
}