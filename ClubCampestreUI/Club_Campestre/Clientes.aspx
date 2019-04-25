<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Club_Campestre.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Shared/css/gridviews.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="main">
        <div class="pure-control-group">
            <div>
                <header>
                    <h1>Clientes</h1>
                </header>
            </div>
            <div>
                <div class="pure-controls">
                    <asp:Button class="pure-button pure-button-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                    <asp:Button class="pure-button pure-button-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
                    <asp:Button class="pure-button pure-button-primary" ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
                    <asp:TextBox ID="txtFiltraClientes" runat="server" ForeColor="Blue"></asp:TextBox>
                    <asp:Button class="pure-button pure-button-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    <label id="errorMensaje" runat="server"></label>
                </div>
                <br />
            </div>
            <div class="pure-controls">
                <asp:GridView class="pure-table" ID="ClientesGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue" AllowPaging="True" PageSize="5" PagerStyle-CssClass="pagingDiv" OnPageIndexChanging="ClientesGridView_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="IdCliente" HeaderText="ID Cliente" />
                        <asp:BoundField DataField="Tipo de Cliente" HeaderText="Tipo de Cliente" />
                        <asp:BoundField DataField="IdPersona" HeaderText="Cédula" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                        <asp:BoundField DataField="Rol" HeaderText="Rol" />
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
