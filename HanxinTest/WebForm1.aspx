<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HanxinTest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #txt1 {
            height: 480px;
            width: 876px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--<input type="text" runat="server" value="" id="txt"/>--%>
        <textarea id="txt1" runat="server" ></textarea>
    </div>
        <div>放大倍数:<input type="text" runat="server" value="3"  id="txtiScale"/></div>
        <div>纠错容量:<input type="text" runat="server" value="1"  id="txtiRsLevel"/></div>
        <div>
            <label id="lbl" runat="server"></label>
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
