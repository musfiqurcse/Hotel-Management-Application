<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomInformationDetails.aspx.cs" Inherits="ExamProject.UI.RoomInformationDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 200px">
    
        Room Information Details<br />
        <br />
        Room No :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <input type="text" name="roomNoTextBox"  id="roomNoTextBox" runat="server" />
        <br />
        Select Catagory:&nbsp;
        <asp:DropDownList ID="selectCatagoryDropDownList" runat="server">
        </asp:DropDownList>
        <br />
        Description:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input type="text" name="descriptionTextBox"  id="descriptionTextBox" runat="server" />
        <br />
        <br />
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
    
    </div>
    </form>
</body>
</html>
