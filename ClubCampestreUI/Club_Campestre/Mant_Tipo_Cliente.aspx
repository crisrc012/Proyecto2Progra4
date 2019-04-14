<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Tipo_Cliente.aspx.cs" Inherits="Club_Campestre.Mant_Tipo_Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
        <div class ="main">
        <div class="pure-control-group">
        <div >
        <header>
            <h1 runat="server" id ="mantenimiento">Estados</h1>
        </header>
    </div>
    <div>
        <form class = "pure-form pure-form-aligned" method="post">
          <fieldset>

          <div class="pure-control-group">
            <label for="TipoCliente"> TipoCliente: </label>
            <input runat="server" type="text" id ="txttipocliente" value="" style="color: #0090ff"/>
          </div>

          <div class="pure-control-group">
            <label for="descripcion"> Descripcion: </label>
              <input runat="server" type="text" id="txtdescripcion" style="color: #0090ff" />
          </div>

          <div class="pure-controls">
              <input type="button" class="pure-button pure-button-primary" Value="Guardar" runat="server" onserverclick="Guardar_ServerClick" />
              
              
          </div>
          </fieldset>
        </form>
        <a href="Tipo_Clientes">Regresar</a>
      </div>
    </div>

</asp:Content>
