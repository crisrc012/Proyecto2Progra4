<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Personas.aspx.cs" Inherits="Club_Campestre.Personas" %>

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
                    <h1>Personas</h1>
                    <script src="Scripts/jquery-3.3.1.min.js"></script>
                    <link href="Content/themes/base/jquery-ui.css" rel="stylesheet" />
                    <script src="Scripts/jquery-ui-1.12.1.min.js"></script>
                    <script src="Scripts/chosen.jquery.min.js"></script>
                    <link href="Content/chosen.css" rel="stylesheet" />
                </header>
            </div>
            <div>
                <fieldset>
                    <div class="pure-control-group">
                        <label for="cedula">Cédula: </label>
                        <input runat="server" onkeypress="javascript:return SoloNumeros(event)" type="text" id="txtCedula" value="" style="color: #0090ff" required="required" />
                        <label for="Rol">Rol: </label>
                        <select id="DropDownRol" runat="server" name="DropDownRol" class="chosen"></select>
                    </div>

                    <div class="pure-control-group">
                        <label for="nombre">Nombre: </label>
                        <input runat="server" type="text" onkeypress="return soloLetras(event)" id="txtnombre" style="color: #0090ff" required="required" />
                    </div>
                    <div class="pure-control-group">
                        <label for="direccion">Dirección: </label>
                        <textarea id="TextAreadireccion" runat="server" style="color: #0090ff" placeholder="Costa Rica, San José, Central" required="required" ></textarea>
                    </div>
                    <div></div>
                    <label for="telefono">Teléfono: </label>
                    <input runat="server" type="text" id="txtTelefono" onkeypress="javascript:return SoloNumeros(event)" style="color: #0090ff; width: 284px;" />
                    <input type="button" class="pure-button pure-button-primary" id="btnagregarTelefono" runat="server" value="+" onserverclick="btnAgregar2_Click1" />
                    &nbsp;
                    <input type="button" class="pure-button pure-button-primary" id="btnquitarTelefono" runat="server" value="-" onserverclick="btnRemover2_Click1" />
                    <div class="pure-controls">
                        <asp:GridView class="pure-table" ID="GridViewTelefono" runat="server" AutoGenerateColumns="false" ForeColor="Blue" Height="156px" Width="400px" AllowPaging="True" OnPageIndexChanging="GridViewTelefono_PageIndexChanging" PageSize="5" PagerStyle-CssClass="pagingDiv">
                            <Columns>
                                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <br />
                    </div>
                    <label for="correo">Correo: </label>
                    <input runat="server" type="email" id="txtemail" style="color: #0090ff; width: 284px;" />
                    <input type="button" class="pure-button pure-button-primary" id="btnagregarCorreo" runat="server" value="+" onserverclick="btnAgregar_Click1" />
                    &nbsp;
                    <input type="button" class="pure-button pure-button-primary" id="btnquitarCorreo" runat="server" value="-" onserverclick="btnRemover_Click1" />
                    <div class="pure-controls">
                        <asp:GridView class="pure-table" ID="CorreoPersonaGridView" runat="server" Height="156px" Width="400px" AutoGenerateColumns="false" ForeColor="Blue" AllowPaging="True" OnPageIndexChanging="CorreoPersonaGridView_PageIndexChanging" PageSize="5" PagerStyle-CssClass="pagingDiv">
                            <Columns>
                                <asp:BoundField DataField="correo" HeaderText="Direcciones de Correo" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <br />
                    </div>
                    <div class="pure-controls" style="width: 330px; margin: 0 auto;">
                        <input class="pure-button pure-button-primary" id="btnRegresar" type="button" value="Regresar" onclick="location.href = 'Mant_Persona.aspx' " />
                        &nbsp;
                        <input type="button" class="pure-button pure-button-primary" id="btnGuardar" runat="server" value="Guardar" onserverclick="btnGuardar_Click1" />
                    </div>
                </fieldset>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $('.chosen').chosen();
    </script>
</asp:Content>
