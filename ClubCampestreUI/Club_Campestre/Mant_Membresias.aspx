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
            <div class="pure-form pure-form-aligned">
                <fieldset>
                    <div class="pure-control-group">
                        <label for="txtCedula">Cedula Cliente:</label>
                        <input runat="server" type="text" id="txtCedula" value="" style="color: #0090ff" />
                        <label for="txtNombre">Nombre:</label>
                        <input runat="server" type="text" id="txtNombre" value="" style="color: #0090ff; width: 305px;" />
                    </div>

                    <div class="pure-control-group">
                        <label for="DropDownTipoCliente">Tipo Membresia:</label>
                        <asp:DropDownList ID="DropDownTipoCliente" runat="server" Width="178px"></asp:DropDownList>
                        <label for="IDCliente">ID Cliente:</label>
                        <input runat="server" type="text" id="IDCliente" value="" style="color: #0090ff" />
                    </div>

                    <div class="pure-control-group">
                        <label for="FechaInicio">Fecha Inicio:</label>
                        <input id="FechaInicio" type="date">&nbsp;
                        <label for="FechaVence">Fecha Vencimiento:</label><input id="FechaVence" type="date" disabled>
                    </div>

                    <div class="pure-control-group">
                        <label for="BeneficiariosGridView">Beneficiarios:</label>
                        <input type="button" class="pure-button pure-button-primary" Value="Agregar" onclick="AgregarBene()" />
                        <input type="button" class="pure-button pure-button-primary" runat="server" Value="Quitar" />
                        <br - />
                        <span id="RegistroBeneficiarios"></span>

                        <asp:GridView class="pure-table" ID="BeneficiariosGridView" runat="server" AutoGenerateColumns="false" ForeColor="Blue" Height="171px" Width="305px" HorizontalAlign="Center" >
                            <Columns>
                                <asp:BoundField DataField="IdPersona" HeaderText="ID Beneficiario"/>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkRow" runat="server" ItemStyle-Width="5" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        
                    </div>
                    <div id="AddBene" style="display:none; position: fixed; z-index: 1; left: 0;  top: 0; width: 100%; height: 100%;  overflow: auto;   background-color: rgb(0,0,0); background-color: rgba(0,0,0,0.4); padding-top: 60px">
                        <div action="/action_page.php" runat="server" style="background-color: #fefefe; margin: 20% auto 15% auto; border: 1px solid #888; width: 45%; -webkit-animation: animatezoom 0.6s; animation: animatezoom 0.6s">
                            <div style="text-align: center; margin: 24px 0 12px 0; position: relative">
                                <span onclick="document.getElementById('AddBene').style.display='none'" style="position: absolute; right: 25px; top: 0; color: #000; font-size: 35px; font-weight: bold;" title="Close Modal">&times;</span>
                            </div>
                            <div class="pure-control-group" style="padding: 16px">
                                <label for="bencel"><b style="color:blue" >Cédula Beneficiario:</b></label>
                                <input type="text" id="bencel" placeholder="Enter Cédula" name="bencel" required="required" runat="server" style="color:blue"/>
                                <button class="pure-button pure-button-primary"  type="submit" runat="server" onserverclick="CargaBeneficiarios">Agregar</button>
                            </div>
                        </div>
                    </div>

                    <div class="pure-controls">
                        <asp:Button class="pure-button pure-button-primary" ID="btnGuardar" runat="server" Text="Guardar" />
                    </div>
                </fieldset>
            </div>
            <a href="Membresias.aspx" style="color:black ">Regresar</a>
        </div>
    </div>
</asp:Content>
