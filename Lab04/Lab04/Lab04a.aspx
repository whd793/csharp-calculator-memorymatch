<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab04a.aspx.cs" Inherits="Lab04.Lab04a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <asp:DropDownList runat="server" ID="myList" DataTextField="title" DataValueField="title"/>
            <br /><br />
            <asp:DropDownList runat="server" ID="names" DataTextField="FLnames" DataValueField="FLnames"/>
            <asp:DropDownList runat="server" ID="phones" DataTextField="HomePhone" DataValueField="HomePhone"/>
            <asp:DropDownList runat="server" ID="cities" DataTextField="City" DataValueField="City"/>
        </div>
    </form>
</body>
</html>
