﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalhesProjeto.aspx.cs" Inherits="Site.Pages.DetalhesProjeto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Detalhes</title>
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
                    <h3 class="well">Detalhes do Projeto</h3>
                </div>
                <br />

                Digite o código do Projeto:
                    <br />
                <asp:TextBox ID="txtCodigo" runat="server" placeholder="Codigo" Width="10%" CssClass="form-control" />
                <br />
                <asp:Button ID="btnPesquisa" Text="Pesquisar" runat="server" CssClass="btn btn-info btn-lg" OnClick="btnPesquisa_Click"/>
                <br />
                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>
                <br />
                <asp:Panel ID="pnlDados" runat="server">
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome do Projeto" Width="45%" CssClass="form-control" />
                    <br />
                    <asp:TextBox ID="txtInicio" runat="server" placeholder="Inicio do Projeto" Width="15%" CssClass="form-control" />
                    <br />
                    <asp:TextBox ID="txtFinal" runat="server" placeholder="Final do Projeto" Width="15%" CssClass="form-control" />
                    <br />
                    <asp:TextBox ID="txtDescricao" runat="server" placeholder="Dercrição do Projeto"  Width="50%" CssClass="form-control" />
                    <br />
                    <asp:Button ID="btnExclui" Text="Excluir" runat="server" CssClass="btn btn-danger btn-lg" OnClick="btnExclui_Click" />
                    <asp:Button ID="btnAtualiza" Text="Atualizar" runat="server" CssClass="btn btn-warning btn-lg" OnClick="btnAtualiza_Click" />
                    <br />
                    <br />
                    Novo usuário:
                    <asp:TextBox ID="txtCodigoUsuario" runat="server" placeholder="Codigo" Width="15%" CssClass="form-control" />
                    <asp:Button ID="btnAdicionarUsuario" Text="Adicionar Usuário" runat="server" CssClass="btn btn-info btn-lg" OnClick="btnAdicionarUsuario_Click" />
                    <br />
                    
                </asp:Panel>
                <br />
                <a href="../Default.aspx" class="btn btn-primary btn-lg">Voltar</a>
            </div>
        </div>

        </div>
    </form>
</body>
</html>
