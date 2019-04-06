<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPessoa.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.min.css" />
    <script type="text/javascript" src="../Scripts/jquery-3.0.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Cadastro de Usuário:</h3>
                </div>
                <br />

                Nome do Usuário:
                    <br />
                <asp:TextBox ID="txtNome" runat="server" placeholder="Nome completo" Width="45%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredName" ErrorMessage="Por favor, digite o nome do usuário." ControlToValidate="txtNome" runat="server" ForeColor="Red"/>
                <br />
                <br />
                Endereço do Usuário:
                    <br />
                <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço do usuário" Width="45%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredAddress" ErrorMessage="Por favor, digite o endereço do usuário." ControlToValidate="txtEndereco" runat="server" ForeColor="Red"/>
                <br />
                <br />
                Email do Usuário:
                    <br />
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email do usuário" Width="45%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredEmail" ErrorMessage="Por favor, digite o email do usuário." ControlToValidate="txtEmail" runat="server" ForeColor="Red"/>
                <br />
                <br />
                Senha do Usuário:
                    <br />
                <asp:TextBox ID="txtSenha" TextMode="Password" runat="server" placeholder="Senha do usuário" Width="45%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="RequiredSenha" ErrorMessage="Por favor, digite a Senha do usuário." ControlToValidate="txtSenha" runat="server" ForeColor="Red"/>
                <br />
                <br />

                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <asp:Button ID="btnCadastro" Text="Cadastrar" runat="server" CssClass="btn btn-success btn-lg" OnClick="btnCadastro_Click"/>
                <a href="../Login.aspx" class="btn btn-primary btn-lg">Voltar</a>
            </div>
        </div>
    </form>
</body>
</html>
