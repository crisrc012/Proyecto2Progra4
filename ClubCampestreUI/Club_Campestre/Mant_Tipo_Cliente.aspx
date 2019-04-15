<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Tipo_Cliente.aspx.cs" Inherits="Club_Campestre.Mant_Tipo_Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 9px;
        }
        .auto-style3 {
            height: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
        <div class ="main">
        <div class="pure-control-group">
        <div >
        <header>
            <h1 runat="server" id ="mantenimiento">Clientes</h1>
        </header>
    </div>
    <div>
        <form class = "pure-form pure-form-aligned" method="post">
          <fieldset>

          <div class="pure-control-group">
            <label for="descripcion"> Tipo de Cliente: </label>
              <input runat="server" type="text" id="txttipocliente" style="color: #0090ff" class="auto-style1" />
          </div>

          <div class="pure-control-group">
            <label for="descripcion"> Id Cliente: </label>
              <input runat="server" type="text" id="txtidcliente" style="color: #0090ff" class="auto-style1" />
          </div>

          <div class="pure-control-group">
            <label for="descripcion"> Id Persona: </label>
              <input runat="server" type="text" id="txtidpersona" style="color: #0090ff" class="auto-style3" />
          </div>

          <div class="pure-controls">
               <asp:Button class="pure-button pure-button-primary" ID ="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
              
          </div>
          </fieldset>
        </form>
        <a href="Clientes.aspx">Regresar</a>
      </div>
    </div>

</asp:Content>
