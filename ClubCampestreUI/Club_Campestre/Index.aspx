<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Club_Campestre.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper row1">
        <header id="header" class="hoc clear">
            <div id="logo" class="fl_left">
                <h1><a id="Titulo" href="index.html">CLUB CAMPESTRE</a></h1>
                <p>Descanso y Relajacion a su Alcance</p>
            </div>
            <nav id="mainav" class="fl_right">
                <ul class="clear">
                   <li><a class="drop" href="#">Catalogo</a>
                        <ul>
                            <li><a href="Encriptacion.aspx">Tipo Membresia</a></li>
                            <li><a href="Des_Encriptacion.aspx">Tipo Clientes</a></li>
                            <li><a href="Fibonnacci.aspx">Estados</a></li>
                            <li><a href="Fibonnacci.aspx">Clientes</a></li>                           
                        </ul>
                    </li>
                    <li><a class="drop" href="#">Seguridad</a>
                        <ul>
                            <li><a href="Encriptacion.aspx">Usuarios</a></li>
                            <li><a href="Des_Encriptacion.aspx">Roles</a></li>                                                   
                        </ul>
                    </li>
                     <li class="active"><a href="Index.aspx">Salir</a></li>
                </ul>
            </nav>
        </header>
    </div>
</asp:Content>
