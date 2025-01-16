<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication_lr2.WebForm1"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Joperge Web Page</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-top:30px">
        <div class="row centered-form">
            <div class="col-xs-12 col-sm-8 col-md-4 col-sm-offset-2 col-md-offset-4">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">⠀⠀⠀⠀Форма регистрации⠀⠀⠀⠀</h3>
                    </div>
                    <div class="panel-body">
                        <form id="form1" runat="server">
                            <div class="row">
                                <div class="col-xs-6 col-sm-6 col-md-6">
                                    <div class="form-group">
                                        <asp:TextBox ID="first_name" runat="server" name="first_name" class="form-control input-sm" placeholder="Имя"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-xs-6 col-sm-6 col-md-6">
                                    <div class="form-group">
                                        <asp:TextBox ID="last_name" runat="server" name="last_name" class="form-control input-sm" placeholder="Фамилия"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="form-group">
                                <asp:TextBox type="email" ID="email" runat="server" name="email" class="form-control input-sm" placeholder="Email"></asp:TextBox>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-xs-6 col-sm-6 col-md-6">
                                    <div class="form-group">
                                        <asp:TextBox type="password" ID="password" runat="server" name="password" class="form-control input-sm" placeholder="Пароль"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-xs-6 col-sm-6 col-md-6">
                                    <div class="form-group">
                                        <asp:TextBox type="password" ID="password_check" runat="server" name="password_check" class="form-control input-sm" placeholder="Подтвердите пароль"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Зарегистрироваться" Height="39px" Width="416px" />
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

