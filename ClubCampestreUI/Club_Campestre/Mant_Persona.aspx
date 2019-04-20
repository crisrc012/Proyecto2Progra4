<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Persona.aspx.cs" Inherits="Club_Campestre.Mant_Persona" %>
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
                <h1>Personas</h1>
            </header>
        </div>
        <div class="pure-controls">
            <asp:Button class="pure-button pure-button-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            &nbsp;
            <asp:Button class="pure-button pure-button-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            &nbsp;
            <asp:Button class="pure-button pure-button-primary" ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            &nbsp;
            <asp:TextBox ID="txtFiltraPersona" runat="server" OnTextChanged="txtFiltraPersona_TextChanged" ForeColor="Blue" onkeypress="return NoEnterBuscar(event)"></asp:TextBox>
            &nbsp;
            <asp:Button class="pure-button pure-button-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <label id="errorMensaje" runat="server"></label>
        </div>
        <br />
        <div class="pure-controls">
            <asp:GridView class="pure-table" ID="PersonaGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue" AllowPaging="True" OnPageIndexChanging="PersonaGridView_PageIndexChanging" PageSize="5" PagerStyle-CssClass="pagingDiv">
                <Columns>
                    <asp:BoundField DataField="Identificacion" HeaderText="Id Persona" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                    <asp:BoundField DataField="Rol" HeaderText="Rol" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="Correo" HeaderText="Correo" />
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
