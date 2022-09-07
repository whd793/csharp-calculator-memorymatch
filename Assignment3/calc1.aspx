<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calc1.aspx.cs" Inherits="calc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Container {
            width:700px;
            height:700px;
            border-radius:50px;
            background-color:#ccffff;
        }

        #LabelBackground {
            width:700px;
            height:90px;
            position:relative;
            top:0px;
            left:0px;
            background-color:#dddddd;
            border-top-left-radius:50px;
            border-top-right-radius: 50px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Container">
            <div id="LabelBackground">
                <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 152px; top: 17px; position: absolute" Text="Single Digit Calculator" Font-Size="32pt"></asp:Label>
            </div>

            <asp:TextBox ID="display" runat="server" Height="50px" style="z-index: 1; left: 50px; top: 146px; position: absolute" Width="300px"></asp:TextBox>

            <asp:Button ID="BtnClear" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 439px; top: 118px; position: absolute" Text="C" Width="100px" OnClick="BtnClear_Click" />

              <asp:Button ID="Btn1" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 66px; top: 451px; position: absolute" Text="1" Width="100px" OnClick="Btn1_Click" />
         
  <asp:Button ID="Btn2" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 186px; top: 451px; position: absolute" Text="2" Width="100px" OnClick="Btn2_Click" />
  <asp:Button ID="Btn3" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 307px; top: 455px; position: absolute" Text="3" Width="100px" OnClick="Btn3_Click" />
  <asp:Button ID="Btn4" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 65px; top: 336px; position: absolute" Text="4" Width="100px" OnClick="Btn4_Click" />
  <asp:Button ID="Btn5" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 184px; top: 336px; position: absolute" Text="5" Width="100px" OnClick="Btn5_Click" />
  <asp:Button ID="Btn6" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 305px; top: 337px; position: absolute" Text="6" Width="100px" OnClick="Btn6_Click" />
  <asp:Button ID="Btn7" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 65px; top: 224px; position: absolute" Text="7" Width="100px" OnClick="Btn7_Click" />
  <asp:Button ID="Btn8" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 187px; top: 225px; position: absolute" Text="8" Width="100px" OnClick="Btn8_Click" />
  <asp:Button ID="Btn9" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 308px; top: 226px; position: absolute" Text="9" Width="100px" OnClick="Btn9_Click" />
  <asp:Button ID="Btn0" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 65px; top: 566px; position: absolute" Text="0" Width="100px" OnClick="Btn0_Click" />
  <asp:Button ID="BtnDiv" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 439px; top: 226px; position: absolute" Text="/" Width="100px" OnClick="BtnDiv_Click" />
  <asp:Button ID="BtnMult" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 441px; top: 340px; position: absolute" Text="*" Width="100px" OnClick="BtnMult_Click" />
  <asp:Button ID="BtnAdd" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 307px; top: 566px; position: absolute" Text="+" Width="100px" OnClick="BtnAdd_Click" />
  <asp:Button ID="BtnSubtract" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 444px; top: 459px; position: absolute" Text="-" Width="100px" OnClick="BtnSubtract_Click" />
  <asp:Button ID="BtnEqual" runat="server" Font-Size="32px" Height="100px" style="z-index: 1; left: 185px; top: 566px; position: absolute" Text="=" Width="100px" OnClick="BtnEqual_Click" />

        </div>
    </form>
</body>
</html>
