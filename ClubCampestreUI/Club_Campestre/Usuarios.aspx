<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Club_Campestre.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Shared/css/gridviews.css" type="text/css" rel="stylesheet" />
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
            <asp:Button class="pure-button pure-button-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/>
            <asp:Button class="pure-button pure-button-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            <asp:Button class="pure-button pure-button-primary" ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:TextBox ID="FiltrarUsuarios" runat="server" ForeColor="Blue" OnTextChanged="Filtrar_TextChanged"></asp:TextBox>
            <asp:Button class="pure-button pure-button-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <label id="errorMensaje" runat="server"></label>
        </div>
        <br />
        <div class="pure-controls">
            <asp:GridView CssClass="pure-table" ID="UsuariosGridView" runat="server" class="pure-table" AutoGenerateColumns="false" ForeColor="Blue" AllowPaging="True" OnPageIndexChanging="UsuariosGridView_PageIndexChanging" PageSize="5" PagerStyle-CssClass="pagingDiv">
                <Columns>
                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                    <asp:BoundField DataField="Identificacion" HeaderText="Cédula" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Rol" HeaderText="Rol" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerSettings Mode="NumericFirstLast"/>
            </asp:GridView>
            <br />
        </div>
    </div> 

    </div>
</asp:Content>
