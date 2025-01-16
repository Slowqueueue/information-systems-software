<%@ Page Title="Телефонный справочник" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication_lr4._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Телефонный справочник</h1>
    <p>На этой странице отображаются телефонные номера и сведения об их владельцах.</p>
    <asp:Table ID="table" runat="server" CssClass="table" HorizontalAlign="Center"></asp:Table>
    <hr />
    <form id="form1" runat="server">
        <asp:Button ID="saveXml" OnClick="saveXml_Click" runat="server" CssClass="btn btn-primary" Text="Сохранить в XML"/>
        <asp:Button ID="readXml" OnClick="readXml_Click" runat="server" CssClass="btn btn-primary" Text="Загрузить из XML"/>
        <asp:Button ID="clearTable" OnClick="clearMyTableBtn" runat="server" CssClass="btn btn-primary" Text="Очистить таблицу"/>
    </form>
</asp:Content>
