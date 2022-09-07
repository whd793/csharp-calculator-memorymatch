<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Params.aspx.cs" Inherits="Lab05.Params" %>

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
                    <asp:AsyncPostBackTrigger ControlID="selectAll" EventName="Click" />
                     <asp:AsyncPostBackTrigger ControlID="selectOne" EventName="Click" />
                     <asp:AsyncPostBackTrigger ControlID="insert" EventName="Click" />
                     <asp:AsyncPostBackTrigger ControlID="update" EventName="Click" />
                     <asp:AsyncPostBackTrigger ControlID="deleteOne" EventName="Click" />
                     <asp:AsyncPostBackTrigger ControlID="deleteAll" EventName="Click" />
                     <asp:AsyncPostBackTrigger ControlID="truncate" EventName="Click" />
                </Triggers>
                <ContentTemplate>
                    <asp:Button runat="server" ID="selectAll" Text="Select All" OnClick="selectAll_Click" />
                    
                    <asp:Button runat="server" ID="selectOne" Text="Select One" OnClick="selectOne_Click" />
                    
                    <asp:Button runat="server" ID="insert" Text="Insert" OnClick="insert_Click" />
                    
                    <asp:Button runat="server" ID="update" Text="Update" OnClick="update_Click" />
                    
                    <asp:Button runat="server" ID="deleteOne" Text="Delete One" OnClick="deleteOne_Click" />
                    
                    <asp:Button runat="server" ID="deleteAll" Text="Delete All" OnClick="deleteAll_Click" />

                    
                    <asp:Button runat="server" ID="truncate" Text="Truncate" OnClick="truncate_Click" />
                    <br />
                    <asp:DataGrid runat="server" ID="myDataGrid">

                    </asp:DataGrid>           

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
