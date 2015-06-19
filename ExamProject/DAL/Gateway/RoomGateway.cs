using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using ExamProject.DAL.DAO;

namespace ExamProject.DAL.Gateway
{
    public class RoomGateway
    {
        Gateway aGateway=new Gateway();

        public void SaveRoomInfo(Room newRoom)
        {
            string query = "INSERT INTO RoomInformation_tbl(RoomNo,CatagoryID,Description) VALUES('" + newRoom.RoomNo +
                           "','" + newRoom.CatagoryID + "','" + newRoom.Description + "')";
            aGateway.command.CommandText = query;
            aGateway.sqlConnection.Open();
            aGateway.command.ExecuteNonQuery();
            aGateway.sqlConnection.Close();
        }

        public bool RoomNoExist(string RoomNo)
        {
            bool result = false;
            string query = "SELECT * FROM RoomInformation_tbl WHERE RoomNo= '" + RoomNo + "'";
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
          public List<Room> RoomListByCataoryID(int catagoryId)
        {
            List<Room> roomList = new List<Room>();
            string query = "SELECT * FROM RoomInformation_tbl WHERE CatagoryID='"+catagoryId+"'";
            aGateway.command.CommandText = query;
            aGateway.sqlConnection.Open();
            SqlDataReader reader = aGateway.command.ExecuteReader();
            while (reader.Read())
            {
                Room room = new Room();
                room.ID = int.Parse(reader[0].ToString());
                room.RoomNo = reader[1].ToString();
                roomList.Add(room);
            }
            reader.Close();
            aGateway.sqlConnection.Close();
            return roomList;
        }
          public List<Room> RoomList()
          {
              List<Room> roomList = new List<Room>();
              string query = "SELECT * FROM RoomInformation_tbl ";
              aGateway.command.CommandText = query;
              aGateway.sqlConnection.Open();
              SqlDataReader reader = aGateway.command.ExecuteReader();
              while (reader.Read())
              {
                  Room room = new Room();
                  room.ID = int.Parse(reader[0].ToString());
                  room.RoomNo = reader[1].ToString();
                  room.CatagoryID = int.Parse(reader[2].ToString());
                  roomList.Add(room);
              }
              reader.Close();
              aGateway.sqlConnection.Close();
              return roomList;
          }
    }
}