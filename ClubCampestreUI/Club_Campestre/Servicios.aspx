<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="Club_Campestre.Servicios" %>

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
                    <h1>Servicios</h1>
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
                <asp:GridView class="pure-table" ID="ServicioGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue" AllowPaging="True" OnPageIndexChanging="ServicioGridView_PageIndexChanging" PageSize="5" PagerStyle-CssClass="pagingDiv">
                    <Columns>
                        <asp:BoundField DataField="IdServicio" HeaderText="Id Servicio" />
                        <asp:BoundField DataField="Identificacion" HeaderText="Identificacion" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Tipo de Servicio" HeaderText="Tipo de Servicio" />
                        <asp:BoundField DataField="Costo" HeaderText="Costo" />
                        <asp:BoundField DataField="FechaRegistro" HeaderText="Fecha de Registro" />
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
