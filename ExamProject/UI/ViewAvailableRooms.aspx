<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAvailableRooms.aspx.cs" Inherits="ExamProject.UI.ViewAvailableRooms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 text-align="center">
            View Available Rooms on a Specific Date
            </h1>
        <p text-align="center">
            Select Date</p>
        <p text-align="center">
            <asp:Calendar ID="datePicker" runat="server"></asp:Calendar>
            </p>
        <p text-align="center">
            <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
            </p>
        <p text-align="center">
            &nbsp;</p>
        <p text-align="center">
            <asp:GridView ID="availableGridView" runat="server">
            </asp:GridView>
            </p>
    
    </div>
    </form>
</body>
</html>
