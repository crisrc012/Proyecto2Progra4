<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Tipo_Clientes.aspx.cs" Inherits="Club_Campestre.Tipo_Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
        <div class ="main">
    <div class="pure-control-group">
        <div>
            <header>
                <h1>Tipo Cliente</h1>
            </header>
        </div>
        <div class="pure-controls">
            <input type="button" class="pure-button pure-button-primary" ID="btnEliminar" runat="server" value="Eliminar" onserverclick="btnEliminar_Click" />
            <input type="button" class="pure-button pure-button-primary" ID="btnEditar" runat="server" value="Editar" onserverclick ="btnEditar_Click" />
            <input type="button" href="Mant_Tipo_Cliente.aspx" class="pure-button pure-button-primary" ID="btnNuevo" runat="server" value="Nuevo" onserverclick="btnNuevo_Click" />
            <asp:TextBox ID="txtFiltraTipocliente" runat="server" OnTextChanged="txtTipoCliente_TextChanged" ForeColor="Blue"></asp:TextBox>
            <input type="button" class="pure-button pure-button-primary" ID="btnBuscar" runat="server" Value="Buscar" onserverclick="btnBuscar_Click" />
            <label id="errorMensaje" runat="server"></label>
        </div>
        <br />
        <div class="pure-controls">
            <asp:GridView class="pure-table" ID="TipoClienteGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue" >
                <Columns>
                    <asp:BoundField DataField="IdTipoCliente" HeaderText="Tipo cliente" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </div> 

    </div>




</asp:Content>
