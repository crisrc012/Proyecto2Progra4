<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="Club_Campestre.Personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
      <div class ="main" style="width: 86%; margin-left: 0px; margin-right: 150px;">
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
              <label for="Rol"> Rol: </label>
              <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownListRol_SelectedIndexChanged" Width="128px"></asp:DropDownList>
          </div>

          <div class="pure-control-group">
            <label for="nombre"> Nombre: </label>
              <input runat="server" type="text" id="txtnombre" style="color: #0090ff" />
          </div>
              <div  class="pure-control-group">
                  <label for="direccion">Direccion</label>
              <textarea id="TextAreadireccion" cols="50" rows="3"  style="color: #0090ff"></textarea>
                  </div>
              <div></div>
                          <label for="telefono"> Telefono: </label>
              
              <input runat="server" type="text" id="txtTelefono" style="color: #0090ff; width: 284px;" />
              <asp:Button class="pure-button pure-button-primary" ID="btnagregar2" runat="server" Text="+" onserverclick="btnAgregar2_Click" OnClick="btnGuardar2_Click1" />
              &nbsp;
              <asp:Button class="pure-button pure-button-primary" ID="btnremover2" runat="server" Text="-" onserverclick="btnRemover2_Click" OnClick="btnRemover2_Click1" />
          
                    <div class="pure-controls">
                    <asp:GridView class="pure-table" ID="TelefonoGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue" OnSelectedIndexChanged="TelefonoGridView_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="correo" HeaderText="Telefonos" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
          <label for="correo"> Correo: </label>
              
              <input runat="server" type="email" id="email1" style="color: #0090ff; width: 284px;" />
              <asp:Button class="pure-button pure-button-primary" ID="Button1" runat="server" Text="+" onserverclick="btnAgregar_Click" OnClick="btnGuardar_Click1" />
              &nbsp;
              <asp:Button class="pure-button pure-button-primary" ID="Button2" runat="server" Text="-" onserverclick="btnRemover_Click" OnClick="btnRemover_Click1" />
          
                    <div class="pure-controls">
                    <asp:GridView class="pure-table" ID="GridView1" runat="server" AutoGenerateColumns="false" ForeColor="Blue" OnSelectedIndexChanged="CorreoGridView_SelectedIndexChanged">
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
        <%--<a href="Estados.aspx">Regresar</a>--%>
      </div>
    </div>
           </div>
</asp:Content>
