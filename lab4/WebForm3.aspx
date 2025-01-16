<%@ Page Title="Удалить запись" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication_lr4.WebForm3" %>

<asp:Content ID="Content5" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="/">На главную</a>
    <h1>Удалить запись из базы данных</h1>
    <div>Выберите запись из списка:</div>
    <form id="form1" runat="server" method="post">
        <asp:DropDownList ID="list" runat="server" CssClass="form-control" required="true"></asp:DropDownList><br />
        <asp:Button ID="submit" OnClick="submit_Click" CssClass="btn btn-primary" text="Удалить из таблицы" runat="server" />
    </form>
</asp:Content>