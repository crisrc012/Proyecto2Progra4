﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="TipoCliente.aspx.cs" Inherits="Club_Campestre.Tipo_Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href ="Shared/css/gridviews.css" rel="stylesheet" />
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
            <asp:GridView ID="TipoClienteGridView" class="pure-table" runat="server" AutoGenerateColumns="false" ForeColor="blue" Height="156px" Width="304px" AllowPaging="True" OnPageIndexChanging="TipoClienteGridView_PageIndexChanging" PageSize="5" PagerStyle-CssClass="pagingDiv" >
                <Columns>
                    <asp:BoundField DataField="IdTipoCliente" HeaderText="Tipo Cliente"/>
                    <asp:BoundField DataField="Descripcion" HeaderText="Tipo Cliente"/>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="chkRow" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
            </asp:GridView>
            <br />
        </div>
    </div> 
    </div>
</asp:Content>
