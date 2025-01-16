<%@ Page title="Добавить запись" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication_lr3.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="/">На главную</a>
    <h1>Добавить запись в базу данных</h1>
    <form id="form1" runat="server" method="post">
        <p><asp:TextBox ID="last_name" runat="server" type="text" CssClass="form-control" placeholder="Фамилия" required="true"></asp:TextBox></p>
        <p><asp:TextBox ID="first_name" runat="server" type="text" CssClass="form-control" placeholder="Имя" required="true"></asp:TextBox></p>
        <p><asp:TextBox ID="middle_name" runat="server" type="text" CssClass="form-control" placeholder="Отчество" required="true"></asp:TextBox></p>
        <hr />
        <div>Номер телефона:</div>
        <p><asp:TextBox ID="phone" runat="server" type="text" CssClass="form-control" placeholder="7XXXXXXXXXX" required="true" data-phone-pattern></asp:TextBox></p>
        <div>Адрес:</div>
        <p><asp:TextBox ID="address" runat="server" type="text" CssClass="form-control" placeholder="Улица, дом, квартира" required="true"></asp:TextBox></p>
        <asp:Button ID="submit" OnClick="submit_Click" CssClass="btn btn-primary" text="Добавить в таблицу" runat="server" />
    </form>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Script" runat="server">
    <script>var $jscomp = $jscomp || {}; $jscomp.scope = {}; $jscomp.arrayIteratorImpl = function (a) { var b = 0; return function () { return b < a.length ? { done: !1, value: a[b++] } : { done: !0 } } }; $jscomp.arrayIterator = function (a) { return { next: $jscomp.arrayIteratorImpl(a) } }; $jscomp.makeIterator = function (a) { var b = "undefined" != typeof Symbol && Symbol.iterator && a[Symbol.iterator]; return b ? b.call(a) : $jscomp.arrayIterator(a) };
        document.addEventListener("DOMContentLoaded", function () {
            var a = function (e) { var c = e.target, n = c.dataset.phoneClear; c = (c = c.dataset.phonePattern) ? c : "7__________"; var g = 0, k = c.replace(/\D/g, ""), d = e.target.value.replace(/\D/g, ""); "false" !== n && "blur" === e.type && d.length < c.match(/([_\d])/g).length ? e.target.value = "" : (k.length >= d.length && (d = k), e.target.value = c.replace(/./g, function (l) { return /[_\d]/.test(l) && g < d.length ? d.charAt(g++) : g >= d.length ? "" : l })) }, b = document.querySelectorAll("[data-phone-pattern]");
            b = $jscomp.makeIterator(b); for (var f = b.next(); !f.done; f = b.next()) { f = f.value; for (var m = $jscomp.makeIterator(["input", "blur", "focus"]), h = m.next(); !h.done; h = m.next())f.addEventListener(h.value, a) }
        });</script>
</asp:Content>
