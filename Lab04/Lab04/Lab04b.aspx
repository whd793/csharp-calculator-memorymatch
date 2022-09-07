<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab04b.aspx.cs" Inherits="Lab04.Lab04b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <Triggers>

                    <asp:AsyncPostBackTrigger ControlID="select" EventName="click" />
                    <asp:AsyncPostBackTrigger ControlID="insert" EventName="click" />
                    <asp:AsyncPostBackTrigger ControlID="update" EventName="click" />
                    <asp:AsyncPostBackTrigger ControlID="delete" EventName="click" />
                </Triggers>
                <ContentTemplate>
                     <asp:Button runat="server" ID="select" Text="Select" OnClick="select_Click" />
                    <asp:Button runat="server" ID="insert" Text="Insert" OnClick="insert_Click" />
                    <asp:Button runat="server" ID="update" Text="Update" OnClick="update_Click" />
                    <asp:Button runat="server" ID="delete" Text="Delete" OnClick="delete_Click" />
                    <br />
                    <asp:DataGrid runat="server" ID="myDataGrid" AutoGenerateColumns="true" width="550px"></asp:DataGrid>

                </ContentTemplate>


            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
