<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="Club_Campestre.Servicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">

       <div class ="main">
    <div class="pure-control-group">
        <div>
            <header>
                <h1>Servicios</h1>
            </header>
        </div>
        <div class="pure-controls">
            <asp:Button class="pure-button pure-button-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <asp:Button class="pure-button pure-button-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            <asp:Button class="pure-button pure-button-primary" ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:TextBox ID="txtFiltraServicio" runat="server" OnTextChanged="txtServicio_TextChanged" ForeColor="Blue" onkeypress="return NoEnterBuscar(event)"></asp:TextBox>
            <asp:Button class="pure-button pure-button-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <label id="errorMensaje" runat="server"></label>
        </div>
        <br />
        <div class="pure-controls">
            <asp:GridView class="pure-table" ID="ServicioGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue">
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
