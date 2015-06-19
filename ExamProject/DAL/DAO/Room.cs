using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ExamProject.DAL.DAO
{
    public class Room
    {
        public int  ID  { get; set; }
        public string RoomNo { get; set; }

        public string Description { get; set; }

        public int CatagoryID { get; set; }
    } 
}