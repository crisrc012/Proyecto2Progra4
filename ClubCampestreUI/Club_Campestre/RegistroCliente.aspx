<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="Club_Campestre.RegistroCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <style type="text/css">
        .background {
            box-sizing: border-box;
            width: 100%;
            height: 1200px;
            padding: 3px;
            background-image: url(Images/fondo.jpg);
            border: 1px solid black;
            background-size: 100% 100%;
            margin: auto;
        }

        .main {
            margin: auto;
            width: 85%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <%--Registro--%>
    <div class="background">
        <div class="modal-content animate" action="/action_page.php" runat="server" style="margin: 1% auto 35% auto; width:50%"> 
                <div class="imgcontainer" style="margin: 1% auto 15% auto" >
                    <span   onclick="closeApp()" class="close" title="Close Modal">&times;</span>
                    <h1>Registro de Clientes</h1>
                 <%--   <img src="Images/Users-icon.png" alt="Avatar" class="avatar"/>--%>
                </div>

                 <div class="container">
                     <label for="cedulaRG"><b>Numero Cedula:</b></label>
                     <input type="text" id="cedulaRG" runat="server" required />

                     <label for="nombreRG"><b>Nombre Completo:</b></label>
                     <input type="text" id="nombreRG" runat="server" required/>

                      <label for="direccionRG"><b>Direccion Domicilio:</b></label>
                     <input type="text" id="direccionRG" runat="server" />

                      <label for="emailRG"><b>Correo Electronico:</b></label>
                     <input type="email" id="emailRG" runat="server" required/>

                      <label for="telefonoRG"><b>Numero de Telefono:</b></label>
                     <input type="text" id="telefonoRG" runat="server" required/>

                     <label for="passwordRG"><b>Password:</b></label>
                     <input type="password" id="passwordRG" runat="server" required/>

                     <label for="confirmarRG"><b>Password:</b></label>
                     <input type="password" id="confirmarRG" runat="server" required/>    
                     
                     <button type="submit" runat="server" onserverclick="Registrarse">Registro</button>                            

                </div>

                <div class="container" style="background-color: #f1f1f1">                    
                    <button type="button" runat="server" onserverclick="Cerrar" class="cancelbtn">Cancel </button>                   
                </div>
            <div>
                <a href="Images/ReglasdeUso .jpg">Los datos pendientes o extras se registraran en el ingreso al club</a>
            </div>
            </div>
    </div>
            
</asp:Content>
