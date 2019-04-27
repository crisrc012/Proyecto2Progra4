<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Persona.aspx.cs" Inherits="Club_Campestre.Mant_Persona" %>

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
                    <h1>Personas</h1>
                </header>
            </div>
            <div class="pure-controls">
                <input type="button" class="pure-button pure-button-primary" id="btnEliminar" runat="server" value="Eliminar" onserverclick="btnEliminar_Click" />&nbsp;
            <input type="button" class="pure-button pure-button-primary" id="btnEditar" runat="server" value="Editar" onserverclick="btnEditar_Click" />&nbsp;
            <input type="button" class="pure-button pure-button-primary" id="btnNuevo" runat="server" value="Nuevo" onserverclick="btnNuevo_Click" />&nbsp;
            <input type="text" id="txtFiltraPersona" runat="server" onkeypress="return NoEnterBuscar(event)" style="color: darkgreen;" />&nbsp;
            <input type="button" class="pure-button pure-button-primary" id="btnBuscar" runat="server" value="Buscar" onserverclick="btnBuscar_Click" />
                <label id="errorMensaje" runat="server"></label>
            </div>
            <br />
            <div class="pure-controls">
                <asp:GridView class="pure-table" ID="PersonaGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue" AllowPaging="True" OnPageIndexChanging="PersonaGridView_PageIndexChanging" PageSize="5" PagerStyle-CssClass="pagingDiv">
                    <Columns>
                        <asp:BoundField DataField="Identificacion" HeaderText="Cédula" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                        <asp:BoundField DataField="Rol" HeaderText="Rol" />
                        <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
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
