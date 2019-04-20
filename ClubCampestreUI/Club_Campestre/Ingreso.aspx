<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="Club_Campestre.Ingreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
          <div class ="main" style="width: 86%; margin-left: 0px; margin-right: 150px;">
        <div class="pure-control-group">
        <div >
        <header>
            <h1 >Ingresos</h1>
        </header>
    </div>
    <div>
         <form class = "pure-form pure-form-aligned" method="post">
          <fieldset>
           <div class="pure-control-group">
             
            <label for="cedula"> Cedula: </label>
            <input runat="server" type="text" id ="txtCedula" value="" style="color: #0090ff"/>
               <asp:Button ID="TxtConsultar" class="pure-button pure-button-primary" runat="server" Text="Consultar" OnClick="TxtConsultar_Click" />
              <label for="Rol"> TipoCliente: </label>
              <input runat="server" type="text" id="TxtTipoCliente"  ForeColor="Blue" Width="191px" />
          </div>

          <div class="pure-control-group">
            <label for="nombre"> Nombre: </label>
              <input runat="server" type="text" id="txtnombre" onkeypress="javascript:return soloLetras(event)" style="color: #0090ff" />
         <div > </div>
              <div class="pure-control-group">
             <label for="cedula"> Membresia: </label>
            <input runat="server" type="text" id ="TxtMembresia" value="" style="color: #0090ff"/>
              <label for="Rol"> Costo: </label>
              <input runat="server" type="text" id="TxtCosto"  ForeColor="Blue" Width="191px" />
             </div>
               </div>
               <label for="telefono" > Invitado</label><input runat="server" type="text" id="txtInvitado"  style="color: #0090ff; width: 284px;" />
              <asp:Button class="pure-button pure-button-primary" ID="btnagregarInvitado" runat="server" Text="+"   />
              &nbsp;
              <asp:Button  class="pure-button pure-button-primary"  ID="btnremoverInvitado" runat="server" Text="-"  />
              <div class="pure-controls">
                    <asp:GridView class="pure-table" ID="GridViewIvitados" runat="server" AutoGenerateColumns="false" ForeColor="Blue"  Height="156px" Width="400px" >
                <Columns>
                    <asp:BoundField DataField="IdPersona" HeaderText="Cedula" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="Costo" HeaderText="Costo" />
                    
                </Columns>
            </asp:GridView>
            <br />
        </div>

               <label for="correo"> Servicios: </label>
                    <div class="pure-controls">
                    <asp:GridView class="pure-table" ID="ServiciosGridView" runat="server"  Height="156px" Width="400px" AutoGenerateColumns="false" ForeColor="Blue" >
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
                 <label for="TxtTotal"> Total: </label>
            <input runat="server" type="text" id ="TxtTotal" value="" style="color: #0090ff"/>
            </div>  
        <div class="pure-controls" style="width:  330px; margin:0 auto; ">
            
            <asp:Button class="pure-button pure-button-primary" ID="btnFacturar" runat="server" Text="Facturar"   />
           </div>

          </fieldset>
        </form>
             </div>
    </div>
           </div>
</asp:Content>
