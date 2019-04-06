<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaSprint.aspx.cs" Inherits="Site.Pages.ConsultaSprint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consulta</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.min.css" />
    <script type="text/javascript" src="../Scripts/jquery-3.0.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Consulta da Sprint:</h3>
                </div>

                <asp:GridView ID="gridSprint" runat="server" CssClass="table table-hover" GridLines="None" AutoGenerateColumns="false" HeaderStyle-BackColor="#ccffcc">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText ="Código"/>
                        <asp:BoundField DataField="Numero" HeaderText ="Numero"/>
                        <asp:BoundField DataField="Inicio" HeaderText ="Inicio" DataFormatString = "{0:dd/MM/yyyy}"/>
                        <asp:BoundField DataField="Final" HeaderText ="Final" DataFormatString = "{0:dd/MM/yyyy}"/>
                        <asp:BoundField DataField="Objetivo" HeaderText ="Objetivo"/>
                    </Columns>
                </asp:GridView>

                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <a href="../Default.aspx" class="btn btn-primary btn-lg">Voltar</a>
                <br />
            </div>
        </div>
        </div>
    </form>
</body>
</html>
