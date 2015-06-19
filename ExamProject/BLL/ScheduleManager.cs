using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamProject.DAL.DAO;
using ExamProject.DAL.Gateway;

namespace ExamProject.BLL
{
    public class ScheduleManager
    {
        ScheduleGateway aGateway =new ScheduleGateway();
        public bool Save(Schedule newSchedule)
        {
            if (aGateway.IsDateAvailabe(newSchedule)==true)
            {
                return false;
            }
            else
            {
                
               aGateway.SaveSchedule(newSchedule);
                return true;
            }
        }

        public List<Room> NotAvailable(string date)
        {
            return aGateway.NotAvailableList(date);
        } 
        
    }
}