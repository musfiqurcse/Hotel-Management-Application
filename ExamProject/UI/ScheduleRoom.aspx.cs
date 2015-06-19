using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamProject.BLL;
using ExamProject.DAL.DAO;

namespace ExamProject.UI
{
    public partial class ScheduleRoom : System.Web.UI.Page
    {
        Room newRoom=new Room();
     static  CatagoryManager newCatagoryManager=new CatagoryManager();
        List<Catagory> catagoryList=newCatagoryManager.GetCatagory(); 
        RoomManager newRoomManager=new RoomManager();
        private ScheduleManager newScheduleManager=new ScheduleManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                LoadDropDown();
                LoadRoomNoDropDownList(int.Parse(selectCatagoryDropDownList.SelectedItem.Value));
                

            }
        }

        

        
            public void LoadDropDown()
            {
            selectCatagoryDropDownList.DataSource = newCatagoryManager.GetCatagory();
            selectCatagoryDropDownList.DataTextField = "Name";
            selectCatagoryDropDownList.DataValueField = "ID";
             selectCatagoryDropDownList.DataBind();
           
            }

        public void LoadRoomNoDropDownList(int catagoryID)
        {
            roomDropdownList.DataSource = newRoomManager.GetRoomListByCatagoryID(catagoryID);
            roomDropdownList.DataTextField = "RoomNo";
            roomDropdownList.DataValueField = "ID";
            roomDropdownList.DataBind();
        }

        protected void selectCatagoryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomNoDropDownList(int.Parse(selectCatagoryDropDownList.SelectedItem.Value));
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Schedule newSchedule=new Schedule();
            newSchedule.RoomID = int.Parse(roomDropdownList.SelectedItem.Value);
            newSchedule.Date = datePicker.SelectedDate.ToString();
            newSchedule.BookedBy = bookedByText.Value;
            newSchedule.Address = addressTextBox.Value;
            if (newScheduleManager.Save(newSchedule) == true)
            {
                string script = "alert(\"Room Booked Succefully!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                    "ServerControlScript", script, true);
            }
            else
            {
                string script = "alert(\"Room already booked!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                    "ServerControlScript", script, true);
            }
            Clear();

        }

        public void Clear()
        {
            bookedByText.Value = addressTextBox.Value = null;
        }


       
        }

    
}