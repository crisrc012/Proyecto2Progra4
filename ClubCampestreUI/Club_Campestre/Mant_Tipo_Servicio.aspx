<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_TipoServicio.aspx.cs" Inherits="Club_Campestre.Mant_Tipo_Servicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="main">
        <div class="pure-control-group">
            <div>
                <header>
                    <h1 runat="server" id="mantenimiento">Tipo de Servicio</h1>
                </header>
            </div>
            <div>
                <div class="pure-form pure-form-aligned">
                    <fieldset>
                        <div class="pure-control-group">
                            <label for="txtdescripcion">Nombre del Servicio: </label>
                            <input runat="server" type="text" id="txtdescripcion" style="color: #0090ff" onkeypress="return soloLetras(event)" />
                        </div>
                        <div class="pure-control-group">

                            <label for="txtcosto">Costo: </label>
                            <input runat="server" type="text" id="txtcosto" style="color: #0090ff" onkeypress="return SoloNumeros(event)" />
                        </div>

                        <div class="pure-controls">

                            <label for="btnguardar" id="lblGuardar" runat="server"></label>
                            <input type="button" class="pure-button pure-button-primary" id="btnGuardar" runat="server" value="Guardar" onserverclick="btnGuardar_Click" />
                        </div>
                    </fieldset>
                </div>
                <a href="TipoServicio.aspx">Regresar</a>
            </div>
        </div>
    </div>
</asp:Content>
