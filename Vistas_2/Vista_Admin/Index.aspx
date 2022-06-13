<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Vistas_2.Vista_Admin.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Index</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Index ADMIN</h1>
            <h2>Bienvenido Administrador</h2>
            <nav>
                <a href="Index.aspx">Logout</a>
                <a href="Productos.aspx">Productos</a>
                <a href="Cuentas.aspx">Cuentas</a>
                <a href="Registro.aspx">Registros</a>
                <a href="Presupuestos.aspx">Presupuestos</a>
                <a href="Ventas.aspx">Ventas</a>
                <a href="~\Vistas_Usuario\Index.aspx">Home</a>
                <asp:Label ID="lblNombreUsuario" runat="server"></asp:Label>
            </nav>
        </div>
    </form>
</body>
</html>
