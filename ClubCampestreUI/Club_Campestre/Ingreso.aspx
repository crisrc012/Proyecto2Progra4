<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="Club_Campestre.Ingreso" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Shared/css/gridviews.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="main" style="width: 86%; margin-left: 0px; margin-right: 150px;">
        <div class="pure-control-group">
            <div>
                <header>
                    <h1>Ingresos</h1>
                </header>
            </div>
            <div>
                <fieldset>
                    <div class="pure-control-group">
                        <label for="cedula">Cedula: </label>
                        <input runat="server" type="text" id="txtCedula" value="" required style="color: #0090ff" />
                        <input type="button" id="TxtConsultar" class="pure-button pure-button-primary" runat="server" value="Consultar" onserverclick="TxtConsultar_Click" />
                        <label for="Rol">TipoCliente: </label>
                        <input runat="server" type="text" id="TxtTipoCliente" forecolor="Blue" width="191px" style="color: #0090ff" />
                    </div>
                    <div class="pure-control-group">
                        <label for="nombre">Nombre: </label>
                        <input runat="server" type="text" id="txtnombre" onkeypress="javascript:return soloLetras(event)" style="color: #0090ff" />
                    </div>
                    <div></div>
                    <div class="pure-control-group">
                        <label for="cedula">Membresia: </label>
                        <input runat="server" type="text" id="TxtMembresia" value="" style="color: #0090ff" />
                        <label for="Rol">Costo: </label>
                        <input runat="server" type="text" id="TxtCosto" forecolor="Blue" width="191px" style="color: #0090ff" />
                    </div>
                    <div class="pure-control-group">
                        <label for="btnagregarInvitado">Invitado</label><input runat="server" type="text" id="txtInvitado" style="color: #0090ff; width: 284px;" />
                        <input type="button" class="pure-button pure-button-primary" id="btnagregarInvitado" runat="server" value="+" onserverclick="btnagregarInvitado_Click" />
                        &nbsp;
                        <input type="button" class="pure-button pure-button-primary" id="btnremoverInvitado" runat="server" value="-" onserverclick="btnremoverInvitado_ServerClick" />
                    </div>
                    <div class="pure-controls">
                        <asp:GridView class="pure-table" ID="GridViewInvitados" runat="server" AutoGenerateColumns="false" ForeColor="Blue" Height="156px" Width="400px" AllowPaging="True" PageSize="5"
                            PagerStyle-CssClass="pagingDiv" OnPageIndexChanging="GridViewIvitados_PageIndexChanging">
                            <Columns>
                                <asp:BoundField DataField="IdPersona" HeaderText="Cedula" />
                                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                                <asp:BoundField DataField="Costo" HeaderText="Costo" />
                            </Columns>
                        </asp:GridView>
                        <br />
                    </div>
                    <label for="correo">Servicios: </label>
                    <div class="pure-controls">
                        <asp:GridView class="pure-table" ID="ServiciosGridView" runat="server" Height="156px" Width="400px" AutoGenerateColumns="false" ForeColor="Blue" AllowPaging="True" PageSize="5" PagerStyle-CssClass="pagingDiv" OnPageIndexChanging="ServiciosGridView_PageIndexChanging">
                            <Columns>
                                <asp:BoundField DataField="IdTipoServicio" HeaderText="IdTipoServicio" />
                                <asp:BoundField DataField="Descripcion" HeaderText="Servicio" />
                                <asp:BoundField DataField="costo" HeaderText="Costos" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <label id="errorMensaje" runat="server"></label>
                        <br />
                    </div>
                    <div class="pure-control-group">
                        <label for="TxtTotal">Total: </label>
                        <input runat="server" type="text" id="TxtTotal" value="" style="color: #0090ff" />
                    </div>
                    <div class="pure-controls" style="width: 330px; margin: 0 auto;">
                        <input type="button" id="Btntotalizar" runat="server" class="pure-button pure-button-primary" value="Totalizar" onserverclick="Btntotalizar_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <input type="button" class="pure-button pure-button-primary" id="btnFacturar" runat="server" value="Facturar" onserverclick="btnFacturar_Click" />
                    </div>
                </fieldset>
            </div>
        </div>
    </div>
</asp:Content>
