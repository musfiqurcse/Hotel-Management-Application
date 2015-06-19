using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamProject.DAL.DAO;
using ExamProject.DAL.Gateway;

namespace ExamProject.BLL
{
    public class RoomManager
    {
        RoomGateway roomGateway=new RoomGateway();
        public bool SaveRoomInfo(Room newRoom)
        {
            if (roomGateway.RoomNoExist(newRoom.RoomNo)==true)
            {
                return false;
            }
            else
            {
                roomGateway.SaveRoomInfo(newRoom);
                return true;

            }
        }

        public List<Room> GetRoomListByCatagoryID(int catagoryID)
        {
            return roomGateway.RoomListByCataoryID(catagoryID);
        }

        public List<Room> GetRoomList()
        {
            return roomGateway.RoomList();

        } 
    }
}