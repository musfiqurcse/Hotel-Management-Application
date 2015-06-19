using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamProject.DAL.DAO
{
    public class Schedule
    {
        public int  ID { get; set; }
        public string Date { get; set; }
        public string BookedBy { get; set; }
        public string Address { get; set; }

        public int RoomID { get; set; }
    }
}