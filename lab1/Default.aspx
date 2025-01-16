<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.WebForm1"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="margin-bottom: 15px">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Введите выражение" AssociatedControlID="expr"></asp:Label>
        <br />
        <asp:TextBox ID="expr" runat="server">2 + 2 - 1</asp:TextBox>
        <asp:Button ID="submitBtn" runat="server" Text="Отправить" />
    </form>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Ответ: "></asp:Label>
        <asp:Label ID="answer" runat="server"></asp:Label>
    </div>
</body>
</html>
