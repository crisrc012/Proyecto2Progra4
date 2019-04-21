<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Cliente.aspx.cs" Inherits="Club_Campestre.Mant_Tipo_Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="main">
        <div class="pure-control-group">
            <div>
                <header>
                    <h1 runat="server" id="mantenimiento">Clientes</h1>
                    <script src="Scripts/jquery-3.3.1.min.js"></script>
                    <link href="Content/themes/base/jquery-ui.css" rel="stylesheet" />
                    <script src="Scripts/jquery-ui-1.12.1.min.js"></script>
                    <script src="Scripts/chosen.jquery.min.js"></script>
                    <link href="Content/chosen.css" rel="stylesheet" />
                </header>
            </div>
            <div class="pure-form pure-form-aligned">
                <fieldset>
                    <div class="pure-control-group">
                        <label for="DropDownTClientes">Tipo de Cliente: </label>
                        <select id="DropDownTClientes" runat="server" name="DropDownTClientes" class="chosen"></select>
                    </div>
                    <div class="pure-control-group">
                        <label for="txtidcliente" id="lblidCliente" runat="server">Id Cliente: </label>
                        <input runat="server" type="text" id="txtidcliente" style="color: #0090ff" class="auto-style1" />
                    </div>
                    <div class="pure-control-group">
                        <label for="txtidpersona">Persona: </label>
                        <input runat="server" type="text" name="txtidpersona" id="txtidpersona" style="color: #0090ff" class="auto-style3" />
                        <select id="DropDownPersona" runat="server" name="DropDownPersonas" class="chosen"></select>
                    </div>
                    <div class="pure-controls">
                        <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    </div>
                </fieldset>
            </div>
            <a href="Clientes.aspx">Regresar</a>
        </div>
    </div> 
    <script type="text/javascript">
        $('.chosen').chosen();
    </script>
</asp:Content>
