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
                    <script src="Scripts/jquery-3.3.1.min.js"></script>
                    <link href="Content/themes/base/jquery-ui.css" rel="stylesheet" />
                    <script src="Scripts/jquery-ui-1.12.1.min.js"></script>
                    <script src="Scripts/chosen.jquery.min.js"></script>
                    <link href="Content/chosen.css" rel="stylesheet" />
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
                            <label for="txtdescripcion">Persona: </label>
                            <select id="DropDownTUsuarios" runat="server" name="DropDownTUsuarios" class="chosen"></select>
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
    <script type="text/javascript">
        $('.chosen').chosen();
    </script>
</asp:Content>
