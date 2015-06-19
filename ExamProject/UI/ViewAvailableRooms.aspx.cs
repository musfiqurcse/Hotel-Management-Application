using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamProject.BLL;
using ExamProject.DAL.DAO;

namespace ExamProject.UI
{
    public partial class ViewAvailableRooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Schedule newSchedule=new Schedule();
        ScheduleManager newManager=new ScheduleManager();
        RoomManager newRoomManager=new RoomManager();
        private List<Room> NotAvailableRoom;
        private List<Room> AvailableRoom;
        protected void showButton_Click(object sender, EventArgs e)
        {
            newSchedule.Date = datePicker.SelectedDate.ToString();
            AvailableRoom= newRoomManager.GetRoomList();
           NotAvailableRoom = newManager.NotAvailable(newSchedule.Date);
            LoadDataGrid();

        }

        public void LoadDataGrid()
        {
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();

            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("Room No", typeof(string));
                dt.Columns.Add("Catagory", typeof(string));

            }
            foreach (var room in AvailableRoom)
            {
               
                if (AvailableRoomID(room))
                {
                    continue;
                }
                else
                {
                    string check;
                    if (room.CatagoryID == 1)
                    {
                        check = "AC";

                    }
                    else
                    {
                        check = "NON-AC";
                    }
                   

                    DataRow NewRow = dt.NewRow();
                    NewRow[0] = room.RoomNo;
                    
                    NewRow[1] = check;
                    dt.Rows.Add(NewRow);

                    

                }

            }
            availableGridView.DataSource = dt;
            availableGridView.DataBind();

        }

        public bool AvailableRoomID(Room room)
        {
            foreach (var roomNew in NotAvailableRoom)
            {
                if (roomNew.ID == room.ID)
                    return true;

            }
            return false;
        }
        

      
    }
}