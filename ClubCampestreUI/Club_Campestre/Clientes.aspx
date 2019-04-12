<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Club_Campestre.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class ="main" style="width: 86%">
        <div class="pure-control-group">
        <div >
        <header>
            <h1 >Clientes</h1>
        </header>
    </div>
    <div>
         <form class = "pure-form pure-form-aligned" method="post">
          <fieldset>

           <div class="pure-controls" style="height: 80px">
                    
          
        <div class="pure-controls" style="width:  330px; margin:0 auto; ">
             <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar" onserverclick="btnGuardar_Click" OnClick="btnGuardar_Click1" />
             <asp:Button class="pure-button pure-button-primary" ID="btnBuscar" runat="server" Text="Buscar" onserverclick="btnBuscar_Click" OnClick="btnBuscar_Click1" />
             <asp:Button class="pure-button pure-button-primary" ID="btnEliminar" runat="server" Text="Eliminar" onserverclick="btnEliminar_Click" OnClick="btnEliminar_Click1" />
             <asp:Button class="pure-button pure-button-primary" ID="btnModificar" runat="server" Text="Modificar" onserverclick="btnModificar_Click" OnClick="btnModificar_Click1" />
              <asp:TextBox ID="txtFiltraEstados" runat="server" OnTextChanged="txtFiltraEstados_TextChanged" ForeColor="Blue"></asp:TextBox>  
        </div>
      <br />
        </div>
         <div class="pure-controls">
            <asp:GridView class="pure-table" ID="ClientesGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue">
                <Columns>
                    <asp:BoundField DataField="IdCliente" HeaderText="Id_Cliente" />
                    <asp:BoundField DataField="TipoCliente" HeaderText="Tipo_Cliente" />
                    <asp:BoundField DataField="IdPersona" HeaderText="Id_Persona" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
          </fieldset>
        </form>
      
      </div>
    </div>
           </div>
</asp:Content>
