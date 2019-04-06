<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaPessoa.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.min.css" />
    <script type="text/javascript" src="../Scripts/jquery-3.0.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Consulta de Usuario:</h3>
                </div>

                <asp:GridView ID="gridClientes" runat="server" CssClass="table table-hover" GridLines="None" AutoGenerateColumns="false" HeaderStyle-BackColor="#ccffcc">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText ="Código"/>
                        <asp:BoundField DataField="Nome" HeaderText ="Nome"/>
                        <asp:BoundField DataField="Endereco" HeaderText ="Endereço"/>
                        <asp:BoundField DataField="Email" HeaderText ="Email"/>
                    </Columns>
                </asp:GridView>

                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <a href="../Default.aspx" class="btn btn-primary btn-lg">Voltar</a>
                <br />
            </div>
        </div>
    </form>
</body>
</html>
