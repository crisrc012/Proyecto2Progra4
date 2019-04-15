<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="TipoMembresia.aspx.cs" Inherits="Club_Campestre.TipoMembresia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
        <div class ="main">
    <div class="pure-control-group">
        <div>
            <header>
                <h1>Tipos de Mebresias</h1>
            </header>
        </div>
        <div class="pure-controls">
            <asp:Button class="pure-button pure-button-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <asp:Button class="pure-button pure-button-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            <asp:Button class="pure-button pure-button-primary" href="Mant_Tipo_Membre.aspx"  ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:TextBox ID="txtFiltraTipoMembre" runat="server" OnTextChanged="txtFiltraTipoMembre_TextChanged" ForeColor="Blue"></asp:TextBox>
            <asp:Button class="pure-button pure-button-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <label id="errorMensaje" runat="server"></label>
        </div>
        <br />
        <div class="pure-controls">
            <asp:GridView class="pure-table" ID="TipoMembresiaGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue">
                <Columns>
                    <asp:BoundField DataField="IdTipoMembresia" HeaderText="Tipo de Mebresia" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                    <asp:BoundField DataField="costo" HeaderText="Costo" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox  ID="chkRow" runat="server" ItemStyle-Width="5" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </div> 

    </div>

</asp:Content>
