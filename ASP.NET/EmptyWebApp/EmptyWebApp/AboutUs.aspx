<%@ Page Title="" Language="C#" MasterPageFile="~/MyApp.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="EmptyWebApp.AboutUs" %>

<%@ Register Src="~/UserControls/ButtonUserControl.ascx" TagPrefix="bt1" TagName="ButtonUserControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">\
    <link rel="stylesheet" type="text/css" href="Content/myAppStyles.css" /> 
   <%-- <style type="text/css">
        h1{background-color:red;}
        h2{background-color:aqua;}
    </style>--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <h1>My First ASP.Net Page</h1>   
    <h2>This is header 2 </h2>    
    <asp:Label ID="Label1" runat="server" Text="About US"></asp:Label>
    <bt1:ButtonUserControl runat="server" id="ButtonUserControl" />    
</asp:Content>
