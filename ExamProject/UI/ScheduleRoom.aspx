<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScheduleRoom.aspx.cs" Inherits="ExamProject.UI.ScheduleRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 19px;
        }
        #Text3 {
            height: 39px;
            width: 143px;
            margin-left: 69px;
        }
        #Text2 {
            margin-left: 50px;
        }
        #Text1 {
            margin-left: 35px;
        }
        #bookedByText {
            margin-left: 44px;
        }
        #addressTextBox {
            margin-left: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Select Catagory :
        <asp:DropDownList ID="selectCatagoryDropDownList" runat="server" OnSelectedIndexChanged="selectCatagoryDropDownList_SelectedIndexChanged" AutoPostBack="True" style="margin-left: 21px">
        </asp:DropDownList>
        <br />
        <br />
        Select Room :&nbsp; <asp:DropDownList ID="roomDropdownList" runat="server" style="margin-left: 35px">
        </asp:DropDownList>
        <br />
        <br />
        Select Date:&nbsp;&nbsp;&nbsp;
        <asp:Calendar type="text" ID="datePicker" runat="server" style="margin-left: 125px"></asp:Calendar>
        <br />
        Booked by:&nbsp;
        <input id="bookedByText" runat="server" type="text" /><br />
        <br />
        Address:
        <input id="addressTextBox" runat="server" type="text" /><br />
        <br />
        <asp:Button ID="saveButton" runat="server" style="margin-left: 208px" Text="Save" OnClick="saveButton_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
