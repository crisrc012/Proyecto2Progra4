<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="MembresiaCliente.aspx.cs" Inherits="Club_Campestre.MembresiaCliente" %>
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
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server" >
            <%--Membresias--%>
    <div class="background">
        <div class="modal-content animate" id="id03" runat="server" style="margin: 1% auto 35% auto; width: 50%">
            <div class="imgcontainer" style="margin: 1% auto 15% auto">
                <span  onclick="closeApp()" class="close" title="Close Modal" >&times;</span>
                <%--   <img src="Images/Users-icon.png" alt="Avatar" class="avatar"/>--%>
            </div>

            <div class="container">
                <label for="cedulaRG"><b>Numero Cedula:</b></label>
                <input type="text" id="cedulaRG" runat="server" required/>

                <label for="nombreRG"><b>Nombre Completo:</b></label>
                <input type="text" id="nombreRG" runat="server" required/>

                <label for="DropDownMembresias"><b>Tipo Membresia:</b></label>
                <select id="DropDownMembresias" name="DropDownMembresias" runat="server"></select>

                <label for="fechaInicioRG"><b>Fecha Inicio:</b></label>
                <input type="date" id="fechaInicioRG" runat="server" />
                
                <label for="fechaVenceRG"><b>Fecha Vencimiento:</b></label>
                <input type="date" id="fechaVenceRG" runat="server"/>

                <label for="passwordRG"><b>Password:</b></label>
                <input type="password" id="passwordRG" runat="server" required/>
                <div>
                    <button type="submit" id="guardar" runat="server" onserverclick="Membresias">Registro</button>
                </div>
               
            </div>

            <div class="container" style="background-color: #f1f1f1">
                
            <button type="button" runat="server" onserverclick="Cerrar" class="cancelbtn">Cancel </button>

            </div>
            <div>
                <label>validaciones de datos correcta?  <a onserverclick="valida_ServerClick" id="valida" runat="server"> Si... </a> <br /></label>
                
                <a>Los datos de beneficiarios y otros se tomaran en el momento de la visia al Club</a>
            </div>
        </div>
        <div>
            <footer style="width: 50px">
            </footer>
        </div>   
    </div>

 </asp:Content>

