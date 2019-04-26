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
                    <input type="button" class="pure-button pure-button-primary" id="btnEliminar" runat="server" value="Eliminar" onserverclick="btnEliminar_Click" />
                    <input type="button" class="pure-button pure-button-primary" id="btnEditar" runat="server" value="Editar" onserverclick="btnEditar_Click" />
                    <input type="button" class="pure-button pure-button-primary" id="btnNuevo" runat="server" value="Nuevo" onserverclick="btnNuevo_Click" />
                    <input type="text" id="txtFiltrar" runat="server" onkeypress="return NoEnterBuscar(event)" style="color: blue" />
                    <input type="button" class="pure-button pure-button-primary" id="btnBuscar" runat="server" value="Buscar" onserverclick="btnBuscar_Click" />
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
