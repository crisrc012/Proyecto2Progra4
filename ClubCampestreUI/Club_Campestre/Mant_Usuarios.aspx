<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Usuarios.aspx.cs" Inherits="Club_Campestre.Mant_Usuarios" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="main">
        <div class="pure-control-group">
            <div>
                <header>
                    <h1 runat="server" id="mantenimiento">Usuarios</h1>
                </header>
            </div>
            <div>
                <form class="pure-form pure-form-aligned" method="post">
                    <fieldset>

                        <div class="pure-control-group">
                            <label for="txtestado">Usuario: </label>
                            <input runat="server" type="text" id="txtusuario" onkeypress="return soloLetras(event)" style="color: #0090ff ; width: 250px;" />
                        </div>

                        <div class="pure-control-group">
                            <label for="txtdescripcion">Identificación: </label>
                            <asp:DropDownList ID="DropDownTUsuarios" runat="server" OnSelectedIndexChanged="DropDownTUsuarios_SelectedIndexChanged" ForeColor="Blue" Width="250px" Height="35px">
                            </asp:DropDownList>
                            &nbsp;
                        </div>

                        <div class="pure-control-group">
                            <label for="txtdescripcion">Contraseña: </label>
                            <input runat="server" type="password" id="txtcontrasena" style="color: #0090ff; width: 250px;"/>
                        </div>

                        <div class="pure-controls">
                            <label for="btnguardar" id="lblGuardar" runat="server"></label>
                            <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                        </div>
                    </fieldset>
                </form>
                <a href="Usuarios.aspx">Regresar</a>
            </div>
        </div>
    </div>
</asp:Content>
