<%@ Page Title="Телефонный справочник" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication_lr3._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Телефонный справочник</h1>
    <p>На этой странице отображаются телефонные номера и сведения об их владельцах.</p>
    <asp:Table ID="table" runat="server" CssClass="table" HorizontalAlign="Center"></asp:Table>

</asp:Content>
