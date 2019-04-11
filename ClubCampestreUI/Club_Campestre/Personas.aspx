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
              <div></div>
                          <label for="correo"> Correo: </label>
              
              <input runat="server" type="email" id="emailcorreo" style="color: #0090ff; width: 284px;" />
              <asp:Button class="pure-button pure-button-primary" ID="btnagregar" runat="server" Text="+" onserverclick="btnAgregar_Click" OnClick="btnGuardar_Click1" />
              &nbsp;
              <asp:Button class="pure-button pure-button-primary" ID="btnremover" runat="server" Text="-" onserverclick="btnRemover_Click" OnClick="btnRemover_Click1" />
          
                    <div class="pure-controls">
                    <asp:GridView class="pure-table" ID="CorreoGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue" OnSelectedIndexChanged="CorreoGridView_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="correo" HeaderText="Direcciones de Correo" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
        <div class="pure-controls" style="width:  330px; margin:0 auto; ">
              <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar" onserverclick="btnGuardar_Click" OnClick="btnGuardar_Click1" />
          </div>

          </fieldset>
        </form>
        <a href="Estados.aspx">Regresar</a>
      </div>
    </div>
           </div>
</asp:Content>
