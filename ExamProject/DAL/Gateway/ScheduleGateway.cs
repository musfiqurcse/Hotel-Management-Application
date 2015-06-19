using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ExamProject.DAL.DAO;

namespace ExamProject.DAL.Gateway
{
    public class ScheduleGateway
    {
        Gateway aGateway =new Gateway();
        public bool IsDateAvailabe(Schedule newSchedule)
        {
            bool result = false;
            string query = "SELECT * FROM ScheduleRoom_tbl WHERE Date='" + newSchedule.Date + "' AND RoomID='" +
                           newSchedule.RoomID + "'";
            aGateway.command.CommandText = query;
            aGateway.sqlConnection.Open();
            SqlDataReader reader = aGateway.command.ExecuteReader();
            while (reader.Read())
            {
                result = true;
                break;
            }
            reader.Close();
            aGateway.sqlConnection.Close();
            return result;


        }

        public void SaveSchedule(Schedule newSchedule)
        {
            string query = "INSERT ScheduleRoom_tbl(Date,BookedBy,Address,RoomID) VALUES('" +  newSchedule.Date+
                           "','" +newSchedule.BookedBy  + "','" + newSchedule.Address + "','"+newSchedule.RoomID+"')";
            aGateway.command.CommandText = query;
            aGateway.sqlConnection.Open();
            aGateway.command.ExecuteNonQuery();
            aGateway.sqlConnection.Close();
        }

        public List<Room> NotAvailableList(string date)
        {
           List<Room> room = new List<Room>();
            string query = "SELECT * FROM ScheduleRoom_tbl WHERE Date='" + date + "' ";
            aGateway.command.CommandText = query;
            aGateway.sqlConnection.Open();
            SqlDataReader reader = aGateway.command.ExecuteReader();
            while (reader.Read())
            {
                 Room newRoom=new Room();
                newRoom.ID = int.Parse(reader[4].ToString());
                room.Add(newRoom);

            }
            reader.Close();
            aGateway.sqlConnection.Close();
            return room;
        } 
       
    }
}