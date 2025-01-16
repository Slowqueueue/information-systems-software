<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication_lr2.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Gallery</title>
    <style>
        body {
            background-color: white;
        }

        section {
            padding-top: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="menu navbar-default" id="page-top">
        <div class="container-fluid">
            <div class="container">
                <div class="navbar-header">
                    <a class="navbar-brand" href="Default.aspx" style="padding-left: 0; padding-right: 0">Jokerge Web Page</a>
                </div>
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav navbar-right">
                        <li class="hidden">
                            <a href="#page-top"></a>
                        </li>
                        <li class="page-scroll">
                            <a href="#images">YBbl</a>
                        </li>
                        <li class="page-scroll">
                            <a href="#punk">Панк-рок</a>
                        </li>
                        <li class="page-scroll">
                            <a href="#members">Участники общества</a>
                        </li>
                        <li class="page-scroll">
                            <a href="/?exit=true">Выйти</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <main>
        <div class="content-wrapper">
            <section class="primary" id="images">
                <div class="container">
                    <h1>
                        <form runat="server">
                            <asp:Label ID="hello" runat="server" CssClass="text-center"></asp:Label>
                        </form>
                    </h1>
                    <div class="row">
                        <div class="col-lg-12 text-center">
                            <h2>YBbl</h2>
                            <hr class="star-primary">
                        </div>
                    </div>
                    <div class="row text-center">
                        <div class="col-sm-4">
                            <img src="kosti.gif" width="400" height="400">
                        </div>
                        <div class="col-sm-4">
                            <img src="jmak.gif" width="400" height="400">
                        </div>
                        <div class="col-sm-4">
                            <img src="uvy.gif" width="400" height="400">
                        </div>
                    </div>
                </div>
            </section>
            <section class="success" id="lorem">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 text-center">
                            <h2>Панк-рок</h2>
                            <hr class="star-light">
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-13 col-lg-offset-2">
                            <p>- В принципе, если так называть, есть темы, мы в принципе до сих пор тут должны и находимся, не важно, какая у нас популярность, понимаешь, да? Мы ведем себя как андерграунд группа, которая не.. нет такого, то что допустим, эм, звездная болезнь, понимаешь да? Это очень важно, понимаешь да? То есть у нас такого не должно быть, понимаешь да? Мы не проснулись звездами, понимаешь да? У нас все начиналось с самого начала, ты понимаешь, да? Все наши, эм, я долго состоял в скинхедовском движении, ты понимаешь да? Не фашистском, извини меня, тогда не было еще такого понятия, понимаешь да? Это было просто движение ультрапанков, понимаешь да? Это панковское движение, понимаешь, да? Которые могли что-то сделать против бандитов, жлобов, понимаешь, да? которые, гопников, понимаешь да? Которые организовывали реальные темы, ты понимаешь, да? Ща с этим очень густо щас в России на самом деле, ну по крайней мере я в этом был движении, понимаешь, да? Жили не знаю где, ну где угодно, понимаешь да? Я сбежал из дома, на самом деле, хотя я из очень хорошей семьи, на самом деле, понимаешь, да? И голодал, допустим, понимаешь да? И... Ну... Понимаешь, как, допустим как наш, как можно охарактеризовать как наш стиль, да? Он может называться, да и в принципе, это панк-рок или хардкор, понимаешь, да? Это все, что касается панк-рока. Панк-рок - это очень большая культура, на самом деле, рока, понимаешь, да? <br /> -Да. <br /> -Это, которая подняла рок заново, ты понимаешь да? Это опять же... Все, понимаешь? Это постпанк, это панк-рок, ты понимаешь? Это классические, понимаешь, да? Это ска, понимаешь да? По-любому. Это хардкор, по-любому, да?</p>
                        </div>
                    </div>
                </div>
            </section>
            <section class="primary" id="contact">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 text-center">
                            <h2>Участники общества</h2>
                            <hr class="star-primary">
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-8 col-lg-offset-2">
                            <p>Веталь</p>
                            <p>Леха</p>
                            <p>Никита</p>
                            <p>Киря</p>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </main>
</asp:Content>
