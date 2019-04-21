<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Estados.aspx.cs" Inherits="Club_Campestre.Mantenimiento.Mant_Estados" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="main">
        <div class="pure-control-group">
            <div>
                <header>
                    <h1 runat="server" id="mantenimiento">Estados</h1>
                </header>
            </div>
            <div>
                <form class="pure-form pure-form-aligned" method="post">
                    <fieldset>

                        <div class="pure-control-group">
                            <label for="txtestado">Estado: </label>
                            <input title="Identificador de estados"  runat="server" type="text" id="txtestado" onkeypress="return soloLetras(event)" value="" maxlength="1" style="color: #0090ff"/>
                        </div>

                        <div class="pure-control-group">
                            <label for="txtdescripcion">Descripcion: </label>
                            <input title="Descripción de estado"  runat="server" type="text" id="txtdescripcion" onkeypress="return soloLetras(event)"  style="color: #0090ff" />
                        </div>

                        <div class="pure-controls">
                            <label for="btnguardar" id="lblGuardar" runat="server"></label>
                            <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                        </div>
                    </fieldset>
                </form>
                <a href="Estados.aspx">Regresar</a>
            </div>
        </div>
    </div>

    
</asp:Content>
