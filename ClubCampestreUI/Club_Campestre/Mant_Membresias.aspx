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
            <div  class="pure-form pure-form-aligned">
                <input class="pure-button pure-button-primary" id="btnPersonas" type="button" value="Personas" onclick="location.href ='Personas.aspx' " />  
                <span style="color:red" id="mensajeError" runat="server"></span>
            </div>
            <div class="pure-form pure-form-aligned">
                <fieldset>
                    <div class="pure-control-group">
                        <label for="txtCedula">Cedula Cliente:</label>
                        <input runat="server" type="text" id="txtCedula" style="color: blue" required />
                        <label for="txtNombre">Nombre:</label>
                        <input runat="server" type="text" id="txtNombre" value="" style="color: #0090ff; width: 305px;"/>
                    </div>

                    <div class="pure-control-group">
                        <label for="DropDownTipoCliente">Tipo Membresia:</label>
                        <asp:DropDownList ID="DropDownTipoCliente" runat="server" Width="178px" ForeColor="Blue"></asp:DropDownList>
                        <label for="IDCliente">ID Cliente:</label>
                        <input runat="server" type="text" id="IDCliente" value="Socio" style="color: blue"  />
                    </div>

                    <div class="pure-control-group">
                        <label for="FechaInicio">Fecha Inicio:</label>
                        <input id="FechaInicio" type="date" style="color: blue" runat="server">
                        
                    </div>
                    <div class="pure-control-group">
                        <label for="FechaVence">Fecha Vencimiento:</label>
                        <input id="FechaVence" type="date" style="color: blue" runat="server" disabled >
                    </div>
                    <section>
                        <div class="pure-control-group">
                            <label for="BeneficiariosGridView">Beneficiarios:</label>
                            <asp:TextBox ID="txtbenefiario" runat="server"  style="color:blue" ></asp:TextBox>
                            <input type="button" id="btnAgregar" class="pure-button pure-button-primary" value="Agregar" runat="server"  onserverclick="CargaBeneficiarios" />
                            <input type="button" class="pure-button pure-button-primary" runat="server" onserverclick="QuitarBeneficiarios" value="Quitar" />

                            <span id="RegistroBeneficiarios"></span>

                            <asp:GridView class="pure-table pure-controls" ID="BeneficiariosGridView" runat="server" AutoGenerateColumns="False" ForeColor="Blue" Width="410px">
                                <Columns>
                                    <asp:BoundField DataField="IdPersona" HeaderText="ID Beneficiario" ItemStyle-Width="100" />
                                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" ItemStyle-Width="200"  />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </section>                  
                    <section>
                        <div class="pure-controls">
                            <input class="pure-button pure-button-primary" id="btnRegresar" type="button" value="Regresar" onclick="location.href = 'Membresias.aspx' " />
                            <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                            <input type ="checkbox" id="checkok" runat="server"/>checkear para poder guardar<br />
                        </div>
                    </section>

                </fieldset>
            </div>
          </div>
    </div>
</asp:Content>
