<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroProjeto.aspx.cs" Inherits="Site.Pages.CadastroProjeto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
                    <h3 class="well">Cadastro do Projeto:</h3>
                </div>
                <br />

                Nome do Projeto:
                    <br />
                <asp:TextBox ID="txtNome" runat="server" placeholder="Nome " Width="45%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredName" ErrorMessage="Por favor, digite o nome do projeto." ControlToValidate="txtNome" runat="server" ForeColor="Red"/>
                <br />
                <br />
                Inicio do Projeto:
                    <br />
                <asp:TextBox ID="txtInicio" runat="server" placeholder="Inicio" Width="15%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredAddress" ErrorMessage="Por favor, digite a data de inicio do projeto." ControlToValidate="txtInicio" runat="server" ForeColor="Red"/>
                <br />
                <br />
                Final do Projeto:
                    <br />
                <asp:TextBox ID="txtFinal" runat="server" placeholder="Fim" Width="15%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="requiredFinal" ErrorMessage="Por favor, digite a data final do projeto." ControlToValidate="txtFinal" runat="server" ForeColor="Red"/>
                <br />
                <br />
                Descrição do Projeto:
                    <br />
                <asp:TextBox ID="txtDescricao" runat="server" placeholder="Descricao" TextMode="MultiLine" Width="50%" CssClass="form-control"/>
                <asp:RequiredFieldValidator ID="RequiredDescricao" ErrorMessage="Por favor, digite a Descrição do projeto." ControlToValidate="txtDescricao" runat="server" ForeColor="Red"/>
                <br />
                <br />

                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>

                <asp:Button ID="btnCadastro" Text="Cadastrar" runat="server" CssClass="btn btn-success btn-lg" OnClick="btnCadastro_Click"/>
                <a href="../Default.aspx" class="btn btn-primary btn-lg">Voltar</a>
            </div>
        </div>

    </form>
</body>
</html>
