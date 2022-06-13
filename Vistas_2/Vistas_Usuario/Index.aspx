<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Vistas_2.Vistas_Usuario.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Index</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 244px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 244px;
            height: 23px;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <h1>Index Usuario</h1>
            <p>Bienvenido a revestimientos A&amp;Ti </p>
        
        </div>
         <table class="auto-style1">
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td class="auto-style3"></td>
                 <td class="auto-style3"></td>
                 <td class="auto-style4">
                     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Vistas_Usuario/Login.aspx">Ingresa</asp:HyperLink>
                 </td>
                 <td class="auto-style3">~/Vistas_Usuario/Login.aspx</td>
                 <td class="auto-style3"></td>
                 <td class="auto-style3"></td>
                 <td class="auto-style3"></td>
                 <td class="auto-style3"></td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style2">
                     <asp:HyperLink ID="hplRegistrate" runat="server" NavigateUrl="~/Vistas_Usuario/Registro.aspx">Registrate</asp:HyperLink>
                 </td>
                 <td>~/Vistas_Usuario/Registro.aspx</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
             <tr>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td class="auto-style2">&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
                 <td>&nbsp;</td>
             </tr>
         </table>
    </form>
</body>
</html>
