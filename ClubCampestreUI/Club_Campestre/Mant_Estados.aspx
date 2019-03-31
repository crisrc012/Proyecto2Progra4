<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Estados.aspx.cs" Inherits="Club_Campestre.Mantenimiento.Mant_Estados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
<%--        <br />
    <table align="center">
    
        <tr>
            <td class="style1">
                <strong style =" color : black">Cédula:</strong></td>
            <td>
                <asp:TextBox ID="TextBox_Cedula" runat="server" ForeColor="Blue"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td class="style1">
                <strong style =" color : black">Nombre:</strong></td>
            <td>
                <asp:TextBox ID="TextBox_Nombre" runat="server" ForeColor="Blue"></asp:TextBox>
            </td>

        </tr>
    </table>

    <div >
        <table style="margin:auto; width:10%; text-align: center">
            <tr>
                <td> <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" /></td>
                <td></td>
                <td><asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" /></td>
            </tr>
        </table>
       
        
    </div>--%>
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
            <label for="estado"> Estado: </label>
            <input runat="server" type="text" id ="txtestado" value="" style="color: #0090ff"/>
          </div>

          <div class="pure-control-group">
            <label for="descripcion"> Descripcion: </label>
              <input runat="server" type="text" id="txtdescripcion" style="color: #0090ff" />
          </div>

          <div class="pure-controls">
              <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar" onserverclick="btnGuardar_Click" />
          </div>
          </fieldset>
        </form>
        <a href="Estados.aspx">Regresar</a>
      </div>
</asp:Content>
