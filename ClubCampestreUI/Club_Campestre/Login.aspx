<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Club_Campestre.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
     <div class="panel panel-body" style="margin: 0; padding: 0; position: fixed; left: 37%; right: 37%; top: 20%; background-color: #f5f5f5; z-index: 30001; opacity: 1.5; filter: alpha(opacity=50)">
         <div class="panel panel-heading " style="background-color: #0094ff">
        </div>   
        <div class="container">
            <h2>Inicio Seción</h2>
            <div class="form-group">
                <label for="email">Email:</label>
                <input type="email" class="form-control" id="email" placeholder="Enter email" name="email" style="width:250px">
            </div>
            <div class="form-group">
                <label for="pwd">Password:</label>
                <input type="password" class="form-control" id="pwd" placeholder="Enter password" name="pswd" style="width:200px">
            </div>
            <div class="form-group form-check">
                <label class="checkbox">
                    <input class="form-check-input" type="checkbox" name="remember" value="">  
                    Remember me                     
                </label>
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
        </div>
    </div>
    
</asp:Content>
