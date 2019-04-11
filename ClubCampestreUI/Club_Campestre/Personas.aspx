<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="Club_Campestre.Personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
      <div class ="main" style="width: 86%">
        <div class="pure-control-group">
        <div >
        <header>
            <h1 >Personas</h1>
        </header>
    </div>
    <div>
         <form class = "pure-form pure-form-aligned" method="post">
          <fieldset>

          <div class="pure-control-group">
            <label for="cedula"> Cedula: </label>
            <input runat="server" type="text" id ="txtCedula" value="" style="color: #0090ff"/>
          </div>

          <div class="pure-control-group">
            <label for="nombre"> Nombre: </label>
              <input runat="server" type="text" id="txtnombre" style="color: #0090ff" />
          </div>
              <div  class="pure-control-group">
                  <label for="direccion">Direccion</label>
              <textarea id="TextAreadireccion" cols="40" rows="5"  style="color: #0090ff"></textarea>
                  </div>
          </fieldset>
        </form>
        <a href="Estados.aspx">Regresar</a>
      </div>
    </div>
           </div>
</asp:Content>
