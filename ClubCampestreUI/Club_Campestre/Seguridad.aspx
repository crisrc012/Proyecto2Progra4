<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Seguridad.aspx.cs" Inherits="Club_Campestre.Seguridad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper row1">
        <header id="header" class="hoc clear">
            <div id="logo" class="fl_left">
                <h1><a id="Titulo" href="index.html">SEGURIDAD DEL SISTEMA</a></h1>
                <p>Datos sobre usuarios y roles</p>
            </div>
            <nav id="mainav" class="fl_right">
                <ul class="clear">
                    <li class="active"><a href="Index.aspx">Salir</a></li>
                    <li><a class="drop" href="#">Menu</a>
                        <ul>
                            <li><a href="Usuarios.aspx">Tipo Membresia</a></li>
                            <li><a href="Roles.aspx">Tipo Clientes</a></li>                    
                        </ul>
                    </li>
                </ul>
            </nav>
        </header>
    </div>
</asp:Content>
