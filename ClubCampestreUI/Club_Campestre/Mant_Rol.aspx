<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Rol.aspx.cs" Inherits="Club_Campestre.Mant_Rol" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="main">
        <div class="pure-control-group">
            <div>
                <header>
                    <h1 runat="server" id="mantenimiento">Roles</h1>
                </header>
            </div>
            <div>
                <form class="pure-form pure-form-aligned" method="post">
                    <fieldset>

                        <div class="pure-control-group">
                            <label for="txtRoles" id="lbltxtroles" runat="server">Rol: </label>
                            <input runat="server" type="text" id="txtRoles" value="" style="color: #0090ff" />
                        </div>

                        <div class="pure-control-group">
                            <label for="txtdescripcion">Descripcion: </label>
                            <input runat="server" type="text" id="txtdescripcion" style="color: #0090ff" onkeypress="return soloLetras(event)" />
                        </div>

                        <div class="pure-controls">
                            <label for="btnguardar" id="lblGuardar" runat="server"></label>
                            <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar"  OnClick="btnGuardar_Click1"  />
                        </div>
                    </fieldset>
                </form>
                <a href="Roles.aspx">Regresar</a>
            </div>
        </div>
    </div>
</asp:Content>
