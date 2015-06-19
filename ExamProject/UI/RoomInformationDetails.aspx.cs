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
    public partial class RoomInformationDetails : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDropDown();
            }
        }
      CatagoryManager newCatagoryManager=new CatagoryManager();
        RoomManager newRoomManager=new RoomManager();
        private Room newRoom;

        
        
        public void LoadDropDown()
        {
            selectCatagoryDropDownList.DataSource = newCatagoryManager.GetCatagory();
            selectCatagoryDropDownList.DataTextField = "Name";
            selectCatagoryDropDownList.DataValueField = "ID";
             selectCatagoryDropDownList.DataBind();
           
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            newRoom=new Room();
            newRoom.RoomNo = roomNoTextBox.Value;
            newRoom.CatagoryID = int.Parse(selectCatagoryDropDownList.SelectedItem.Value);
            newRoom.Description = descriptionTextBox.Value;
            if (newRoomManager.SaveRoomInfo(newRoom)==true)
            {
                string script = "alert(\"Room Information Saved Succefully!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                    "ServerControlScript", script, true);
            }
            else
            {
                string script = "alert(\"Room No Exist!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                    "ServerControlScript", script, true);
            }
            Clear();

        }

        public void Clear()
        {
            roomNoTextBox.Value = descriptionTextBox.Value = null;
        }
    }
}