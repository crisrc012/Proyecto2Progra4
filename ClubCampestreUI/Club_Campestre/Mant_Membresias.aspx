<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Membresias.aspx.cs" Inherits="Club_Campestre.Mant_Membresias" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="main">
        <div class="pure-control-group">
            <div>
                <h1 runat="server" id="mantenimiento">Membresias</h1>
            </div>
            <form class="pure-form pure-form-aligned">
                <fieldset>
                    <div class="pure-control-group">
                        <label for="txtCedula">Cedula Cliente:</label>
                        <input runat="server" type="text" id="txtCedula" style="color: blue"/>
                        <label for="txtNombre">Nombre:</label>
                        <input runat="server" type="text" id="txtNombre" value="" style="color: #0090ff; width: 305px;" />
                    </div>

                    <div class="pure-control-group">
                        <label for="DropDownTipoCliente">Tipo Membresia:</label>
                        <asp:DropDownList ID="DropDownTipoCliente" runat="server" Width="178px" ForeColor="Blue"></asp:DropDownList>
                        <label for="IDCliente">ID Cliente:</label>
                        <input runat="server" type="text" id="IDCliente" value="" style="color: blue" />
                    </div>

                    <div class="pure-control-group">
                        <label for="FechaInicio">Fecha Inicio:</label>
                        <input id="FechaInicio" type="date" style="color: blue">
                        
                    </div>
                    <div class="pure-control-group">
                        <label for="FechaVence">Fecha Vencimiento:</label>
                        <input id="FechaVence" type="date" style="color: blue" disabled>
                    </div>
                    <section>
                        <div class="pure-control-group">
                            <label for="BeneficiariosGridView">Beneficiarios:</label>
                            <asp:TextBox ID="txtbenefiario" runat="server"  style="color:blue"></asp:TextBox>
                            <input type="button" class="pure-button pure-button-primary" value="Agregar" runat="server"  onserverclick="CargaBeneficiarios" />
                            <input type="button" class="pure-button pure-button-primary" runat="server" value="Quitar" />

                            <span id="RegistroBeneficiarios"></span>

                            <asp:GridView class="pure-table pure-controls" ID="BeneficiariosGridView" runat="server" AutoGenerateColumns="False" ForeColor="Blue" Height="171px" Width="495px">
                                <Columns>
                                    <asp:BoundField DataField="IdPersona" HeaderText="ID Beneficiario" />
                                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </section>                  

                    <div class="pure-controls">
                        <input class="pure-button pure-button-primary"  id="btnRegresar" type="button" value="Regresar" onclick="location.href ='Membresias.aspx' " />   
                        <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" /> 
                    </div>
                </fieldset>
            </form>
          </div>
    </div>
</asp:Content>
