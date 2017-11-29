<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="HanxinTest.WebForm4" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style type="text/css">
        #TextBox1 {
            height: 480px;
            width: 876px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <textarea id="TextBox1" runat="server" ></textarea>
        </div>
        <div>
            <label id="lbl" runat="server"></label>
        </div>
        <div>
           长<asp:TextBox ID="TextBox2" runat="server" Text="200"></asp:TextBox> 

           宽<asp:TextBox ID="TextBox3" runat="server" Text="200"></asp:TextBox> 

        </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    
    </div>
        <div>
            <img src="#" id="img" runat="server" /> 

        </div>
    </form>
</body>
</html>
