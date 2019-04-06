<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Site.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <script type="text/javascript" src="Scripts/jquery-3.0.0.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel panel-default">
            <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCCC" Height="40%" Style="margin-left: 30%; margin-right: 30%; margin-top: 5%; margin-bottom: 55%; padding: 15px" Width="40%">
                <h2>LOGIN</h2>Código do Usuário:<br />
                <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" placeholder="Código do usuário"></asp:TextBox>
                <br />
                Senha:<br />
                <asp:TextBox ID="txtSenha" TextMode="Password" runat="server" CssClass="form-control" placeholder="Senha do usuário"></asp:TextBox>
                <br />

                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <asp:Button ID="btnLogar" runat="server" Text="Acessar" CssClass="btn btn-success btn-lg" OnClick="btnLogar_Click" />
                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-warning btn-lg" OnClick="btnCadastrar_Click" />
            </asp:Panel>
        </div>

    </form>
</body>
</html>
