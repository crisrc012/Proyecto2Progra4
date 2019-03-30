<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Estados.aspx.cs" Inherits="Club_Campestre.Estados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div>
        <header>
            <h1>Estados</h1>
        </header>

    </div>
    <div style="text-align: right">
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" ForeColor="Blue" />
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" ForeColor="Blue" />
    </div>

    <div>
        <asp:GridView ID="EstadoGridView" runat="server" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor= "#0000ff"
            AutoGenerateColumns="false" ForeColor="Blue">
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
       
        <%--datasourceid="AuthorsSqlDataSource"
        <asp:GridView ID="ClientesGridView"
            AutoGenerateColumns="False" 
            orderWidth="1px" CellPadding="4"
            EmptyDataText="No Existen datos."
            AllowPaging="True"
            ShowHeaderWhenEmpty="True"             
            runat="server" DataKeyNames="Cedula">

            <Columns>
                <asp:BoundField DataField="Cedula" HeaderText="Cédula" SortExpression="Cedula" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                 <asp:CheckBoxField DataField="Editar" />
            </Columns>
        </asp:GridView>--%>
        <%--<asp:sqldatasource id="AuthorsSqlDataSource"  
        selectcommand="SELECT [au_lname], [au_fname], [address], [city], [state], [zip], [contract] FROM [authors]"
        connectionstring="server=localhost;database=pubs;integrated security=SSPI"
        runat="server">
      </asp:sqldatasource>--%>
    </div>
</asp:Content>
