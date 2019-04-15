<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Club_Campestre.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class ="main">
    <div class="pure-control-group">
        <div>
            <header>
                <h1>Usuarios</h1>
            </header>
        </div>
        <div class="pure-controls">
            <asp:Button class="pure-button pure-button-primary" ID="btnEliminar" runat="server" Text="Eliminar"/>
            <asp:Button class="pure-button pure-button-primary" ID="btnEditar" runat="server" Text="Editar" />
            <asp:Button class="pure-button pure-button-primary" ID="btnNuevo" runat="server" Text="Nuevo" />
            <asp:TextBox ID="FiltrarUsuarios" runat="server" ForeColor="Blue"></asp:TextBox>
            <asp:Button class="pure-button pure-button-primary" ID="btnBuscar" runat="server" Text="Buscar" />
            <label id="errorMensaje" runat="server"></label>
        </div>
        <br />
        <div class="pure-controls">
            <asp:GridView ID="UsuariosGridView" runat="server" class="pure-table" AutoGenerateColumns="false" ForeColor="Blue">
                <Columns>
                    <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" />
                    <asp:BoundField DataField="IdPersona" HeaderText="IdPersona" />
                    <asp:BoundField DataField="Contrasena" HeaderText="Contrasena" />
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
