<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Mant_Estados.aspx.cs" Inherits="Club_Campestre.Mantenimiento.Mant_Estados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
        <br />
    <table align="center">
    
        <tr>
            <td class="style1">
                <strong>Cédula:</strong></td>
            <td>
                <asp:TextBox ID="TextBox_Cedula" runat="server" ForeColor="Blue"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td class="style1">
                <strong>Nombre:</strong></td>
            <td>
                <asp:TextBox ID="TextBox_Nombre" runat="server" ForeColor="Blue"></asp:TextBox>
            </td>

        </tr>
    </table>

    <div >
        <table style="margin:auto; width:10%; text-align: center">
            <tr>
                <td> <asp:Button ID="btnAtras" runat="server" Text="Atras" OnClick="btnAtras_Click" /></td>
                <td></td>
                <td><asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" /></td>
            </tr>
        </table>
       
        
    </div>
</asp:Content>
