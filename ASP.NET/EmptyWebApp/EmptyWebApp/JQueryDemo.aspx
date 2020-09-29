<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JQueryDemo.aspx.cs" Inherits="EmptyWebApp.JQueryDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Content/Jquery.js"></script>
    <script>
        $(document).ready(function () {
            $("button").click(function () {
                $("p").hide();
            })
        });
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Jquery Sample</p>
            <button>Click</button>
        </div>
    </form>
</body>
</html>
