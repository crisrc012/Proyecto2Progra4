<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Tipo_Membre.aspx.cs" Inherits="Club_Campestre.Mant_Tipo_Membre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
        <div class ="main">
        <div class="pure-control-group">
        <div >
        <header>
            <h1 runat="server" id ="mantenimiento">Mantenimiento Tipo de Membresia</h1>
        </header>
    </div>
    <div>
        <form class = "pure-form pure-form-aligned" method="post">
          <fieldset>

          <div class="pure-control-group">
            <label for="Tipo_de_Membresia" id="lblTipoMembresia"> Tipo de Membresia: </label>
            <input runat="server" type="text" id ="txtTipoMembre" value="" style="color: #0090ff"/>
          </div>

          <div class="pure-control-group">
            <label for="descripcion"> Descripcion: </label>
              <input runat="server" type="text" id="txtdescripcion" style="color: #0090ff" />
          </div>
                        <div class="pure-control-group">
            <label for="Costo"> Costo: </label>
              <input runat="server" type="text" id="txtcosto" style="color: #0090ff" />
          </div>

          <div class="pure-controls">
              <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar" onclick="btnGuardar_Click"  />
          </div>
          </fieldset>
        </form>
        <a href="TipoMembresia.aspx">Regresar</a>
      </div>
    </div>

   

</asp:Content>
