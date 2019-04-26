<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="Club_Campestre.Roles" %>

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
                    <h1>Roles</h1>
                </header>
            </div>
            <div class="pure-controls">
                <input type="button" class="pure-button pure-button-primary" id="btnEliminar" runat="server" value="Eliminar" onserverclick="btnEliminar_Click" />
                <input type="button" class="pure-button pure-button-primary" id="btnEditar" runat="server" value="Editar" onserverclick="btnEditar_Click" />
                <input type="button" class="pure-button pure-button-primary" id="btnNuevo" runat="server" value="Nuevo" onserverclick="btnNuevo_Click" />
                <input type="text" id="txtFiltrar" runat="server" onkeypress="return NoEnterBuscar(event)" style="color: blue" />
                <input type="button" class="pure-button pure-button-primary" id="btnBuscar" runat="server" value="Buscar" onserverclick="btnBuscar_Click" />
                <label id="errorMensaje" runat="server"></label>
            </div>
            <br />
            <div class="pure-controls">
                <asp:GridView class="pure-table" ID="RolesGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue" Height="156px" Width="304px" AllowPaging="True" OnPageIndexChanging="RolesGridView_PageIndexChanging" OnSelectedIndexChanged="RolesGridView_SelectedIndexChanged" PageSize="5" PagerStyle-CssClass="pagingDiv">
                    <Columns>
                        <asp:BoundField DataField="IdRol" HeaderText="Rol" />
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
