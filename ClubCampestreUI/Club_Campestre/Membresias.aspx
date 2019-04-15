<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Membresias.aspx.cs" Inherits="Club_Campestre.Membresias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class ="main">
        <div class="pure-control-group">
            <header>
                <h1>Membresias</h1>
            </header>
        </div>
        <div class="pure-controls">
            <asp:Button class="pure-button pure-button-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <asp:Button class="pure-button pure-button-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            <asp:Button class="pure-button pure-button-primary" ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:TextBox ID="txtFiltrarMembresias" runat="server" ForeColor="Blue" onkeypress="return NoEnterBuscar(event)"></asp:TextBox>
            <asp:Button class="pure-button pure-button-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <label id="errorMensaje" runat="server"></label>
        </div>
        <br />
        <div class="pure-controls">
            <asp:GridView class="pure-table" ID="MembresiasGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue">
                <Columns>
                    <asp:BoundField DataField="IdMembresia" HeaderText="Membresia"/>
                    <asp:BoundField DataField="Identificacion" HeaderText="Cedula"/>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre"/>
                    <asp:BoundField DataField="Membresia" HeaderText="Tipo Membresia"/>
                    <asp:BoundField DataField="Costo" HeaderText="Costo"/>
                    <asp:BoundField DataField="FechaInicio" HeaderText="Fecha Inicio"  />
                    <asp:BoundField DataField="FechaVencimiento" HeaderText="Fecha Vencimiento"  />
                    <asp:BoundField DataField="Estado" HeaderText="Estado"  />
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
</asp:Content>
