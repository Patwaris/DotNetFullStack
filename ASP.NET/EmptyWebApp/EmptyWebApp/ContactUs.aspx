<%@ Page Title="" Language="C#" MasterPageFile="~/MyApp.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="EmptyWebApp.ContactUs" %>

<%@ Register Src="~/UserControls/ButtonUserControl.ascx" TagPrefix="uc1" TagName="ButtonUserControl" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/myAppStyles.css" />
    <script type="text/javascript">
        function Wish() {
            var user = document.getElementById('ContentPlaceHolder1_txtUser');
            if (user.value == "") {
                //  alert('Please enter username');
                var msg = document.getElementById('ContentPlaceHolder1_userErrmsg');
                msg.innerHTML = "*Please enter userName";
                return false;
            }
            else {
                var msg = document.getElementById('ContentPlaceHolder1_userErrmsg');
                msg.innerHTML = "";
                return true;
            }
            //let a = 10;
            //for (var counter = 1; counter < 5; counter++) {
            //    alert(counter);
            //}            
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>We are now wroking on the ASP.Net Web forms</p>
    <div>
        <asp:Label ID="Label1" runat="server" Text="User Name : "></asp:Label>
        <asp:TextBox ID="txtUser" Text="Default" OnTextChanged="txtUser_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
        <asp:Label ID="userErrmsg" Style="color: red;" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPW" runat="server" TextMode="Password" Style="margin-left: 23px" Width="154px"></asp:TextBox>
    </div>
    <div>
        <asp:CheckBox ID="chk" runat="server" Text="Male" Checked="true" />
    </div>
    <div style="align-content: center">
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" OnClientClick="return Wish();" />
        <uc1:ButtonUserControl runat="server" ID="ButtonUserControl" />
    </div>
    <div>
        <asp:DropDownList ID="dd" runat="server" >
            <asp:ListItem Selected="True">--Select--</asp:ListItem>
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>USA</asp:ListItem>
            <asp:ListItem>UK</asp:ListItem>
            <asp:ListItem>AUS</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <asp:RadioButton ID="rb" runat="server" Text="Select" />
        <asp:HyperLink ID="hl" runat="server" NavigateUrl="~/Home.aspx">Click Me!</asp:HyperLink>
    </div>
    <div>
        <asp:Label ID="lblUserId" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>

