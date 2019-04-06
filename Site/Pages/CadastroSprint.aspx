<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroSprint.aspx.cs" Inherits="Site.Pages.CadastroSprint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sprint</title>
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
                    <h3 class="well">Cadastro da Sprint:</h3>
                </div>
                <br />
                Número da Sprint:
                    <br />
                <asp:TextBox ID="txtNumero" runat="server" placeholder="Numero" Width="45%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredNumero" ErrorMessage="Por favor, digite o numero da Sprint." ControlToValidate="txtNumero" runat="server" ForeColor="Red"/>
                <br />
                <br />
                Inicio da Sprint:
                    <br />
                <asp:TextBox ID="txtInicio" runat="server" placeholder="Inicio" Width="15%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredAddress" ErrorMessage="Por favor, digite a data de inicio da Sprint." ControlToValidate="txtInicio" runat="server" ForeColor="Red"/>
                <br />
                <br />
                Final da Sprint:
                    <br />
                <asp:TextBox ID="txtFinal" runat="server" placeholder="Fim" Width="15%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredFinal" ErrorMessage="Por favor, digite a data final da Sprint." ControlToValidate="txtFinal" runat="server" ForeColor="Red"/>
                <br />
                <br />
                Descrição da Sprint:
                    <br />
                <asp:TextBox ID="txtDescricao" runat="server" placeholder="Descricao" TextMode="MultiLine" Width="50%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="RequiredDescricao" ErrorMessage="Por favor, digite a Descrição da Sprint." ControlToValidate="txtDescricao" runat="server" ForeColor="Red"/>
                <br />
                <br />
                Código do Projeto desta Sprint:
                    <br />
                <asp:TextBox ID="txtCodigoProjeto" runat="server" placeholder="Codigo" Width="15%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="RequiredCodigoProjeto" ErrorMessage="Por favor, digite o código do projeto desta Sprint." ControlToValidate="txtCodigoProjeto" runat="server" ForeColor="Red"/>
                <br />
                <br />

                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <asp:Button ID="btnCadastro" Text="Cadastrar" runat="server" CssClass="btn btn-success btn-lg" OnClick="btnCadastro_Click"/>
                <a href="../Default.aspx" class="btn btn-primary btn-lg">Voltar</a>
            </div>
        </div>
        </div>
    </form>
</body>
</html>
