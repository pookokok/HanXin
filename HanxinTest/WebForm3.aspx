<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="HanxinTest.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="js/jquery-1.9.1.js"></script>
<%--    <script src="js/StaticCommodityAttributeNum.js"></script>
    <script src="js/StaticCommodityAttributeName.js"></script>
    <script src="js/StaticCommodityAttributeFormat.js"></script>--%>
    <script src="js/StaticCommodityAttribute.js"></script>
    <script src="js/validate.js"></script>
    <script src="js/GSValidate.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input runat="server" type="text" id="txt1" value="bat" />
            <input runat="server" type="text" id="txt2" value="" />
        </div>
        <div>
            <input type="button" id="btn" value="xxx" onclick="GSValidate($('#txt1').val(), $('#txt2').val())"/>
        </div>
        <div>
            <select>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
               
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>

                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
               
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
                <option value="1">乐器、游戏、玩具、工艺品、教育器材和用品</option>
            </select>

        </div>
    </form>

</body>
</html>
