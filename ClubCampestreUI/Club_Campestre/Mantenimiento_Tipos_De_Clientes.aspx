﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_TipoCliente.aspx.cs" Inherits="Club_Campestre.Mantenimiento_Tipos_De_Clientes" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="main">
        <div class="pure-control-group">
            <div>
                <header>
                    <h1 runat="server" id="mantenimiento">Mantenimiento de Tipo de Clientes </h1>
                </header>
            </div>
            <div>
                <fieldset>
                    <div class="pure-control-group">
                        <label for="txtIdTipodeCliente" id="lblIdTipoCliente" runat="server">ID Tipo de Cliente: </label>
                        <input runat="server" type="text" id="txtIdTipoCliente" onkeypress="return soloLetras(event)" value="" style="color: #0090ff" />
                    </div>

                    <div class="pure-control-group">
                        <label for="txtdescripcion">Tipo de Cliente: </label>
                        <input runat="server" type="text" id="txtdescripcion" onkeypress="return soloLetras(event)" value="" style="color: #0090ff" />
                    </div>
                    <div class="pure-controls">
                        <label for="btnguardar" id="lblGuardar" runat="server"></label>
                        <input type="button" class="pure-button pure-button-primary" id="btnGuardar" runat="server" value="Guardar" onserverclick="btnGuardar_Click" />
                    </div>
                </fieldset>
                <a href="Tipo_Clientes.aspx">Regresar</a>
            </div>
        </div>
    </div>


</asp:Content>
