<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="MembresiaCliente.aspx.cs" Inherits="Club_Campestre.MembresiaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
            <%--Membresias--%>
        <div class="modal-content animate" action="/action_page.php" runat="server" style="margin: 1% auto 35% auto; width: 50%">
            <div class="imgcontainer" style="margin: 1% auto 15% auto">
                <span onclick="document.getElementById('id03').style.display='none'" class="close" title="Close Modal">&times;</span>
                <%--   <img src="Images/Users-icon.png" alt="Avatar" class="avatar"/>--%>
            </div>

            <div class="container">
                <label for="cedulaRG"><b>Numero Cedula:</b></label>
                <input type="text" id="cedulaRG" runat="server" />

                <label for="nombreRG"><b>Nombre Completo:</b></label>
                <input type="text" id="nombreRG" runat="server" />

                <label for="DropDownMembresias"><b>Tipo Membresia:</b></label>
                <asp:dropdownlist id="DropDownMembresias" runat="server"></asp:dropdownlist>

                <label for="fechaInicioRG"><b>Fecha Inicio:</b></label>
                <input type="date" id="fechaInicioRG" runat="server" />
                
                <label for="fechaVenceRG"><b>Fecha Vencimiento:</b></label>
                <input type="date" id="fechaVenceRG" runat="server" />

                <label for="passwordRG"><b>Password:</b></label>
                <input type="password" id="passwordRG" runat="server" />

                <button type="submit" runat="server" onserverclick="Membresias">Registro</button>         

            </div>

            <div class="container" style="background-color: #f1f1f1">
                
               <button type="button" runat="server" onserverclick="Cerrar" class="cancelbtn">Cancel </button>

            </div>
        </div>
 </asp:Content>
