<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Estados.aspx.cs" Inherits="Club_Campestre.Estados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="pure-control-group">
        <div >
        <header>
            <h1>Estados</h1>
        </header>
    </div>
    <div class="pure-controls" >
        <asp:Button class="pure-button pure-button-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"  />
        <asp:Button class="pure-button pure-button-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click"  />
        <asp:Button class="pure-button pure-button-primary" ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
    </div>
     <br/>
    <div class="pure-controls">
        <asp:GridView  class ="pure-table" ID="EstadoGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue">
            <Columns>               
                <asp:BoundField DataField="IdEstado" HeaderText="Estado"   />
                <asp:BoundField DataField="Estado" HeaderText="Descripcion" />
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
