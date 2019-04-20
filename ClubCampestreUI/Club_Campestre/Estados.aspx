<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Estados.aspx.cs" Inherits="Club_Campestre.Estados" %>
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
                <h1>Estados</h1>
            </header>
        </div>
        <div class="pure-controls">
            <asp:Button class="pure-button pure-button-primary" ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <asp:Button class="pure-button pure-button-primary" ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            <asp:Button class="pure-button pure-button-primary" ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:TextBox ID="txtFiltraEstados" runat="server" OnTextChanged="txtFiltraEstados_TextChanged" ForeColor="Blue" onkeypress="return NoEnterBuscar(event)"></asp:TextBox>
            <asp:Button class="pure-button pure-button-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <label id="errorMensaje" runat="server"></label>
        </div>
        <br />
        <div class="pure-controls">
            <asp:GridView class="pure-table" ID="EstadoGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue" Height="156px" Width="304px" PageSize="5" AllowPaging="True" PagerStyle-CssClass="pagingDiv" OnPageIndexChanging="EstadoGridView_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="IdEstado" HeaderText="Estado" />
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
        <a class="fa fa-lg fa-folder" href="Index.aspx" style="color:black">---Regresar---</a>
    </div>
       
</asp:Content>
