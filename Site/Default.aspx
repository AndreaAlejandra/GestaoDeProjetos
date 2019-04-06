<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <script type="text/javascript" src="Scripts/jquery-3.0.0.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1>BEM VINDO <asp:Label ID="lblUsuarioLogado" runat="server" />!</h1>

            Selecione a opção desejada:
            <asp:DropDownList ID="ddlMenu" runat="server">
                <asp:ListItem Value="0" Text="- Escolha uma opção -"/>                
                <asp:ListItem Value="2" Text="Consultar Cliente"/>
                <asp:ListItem Value="3" Text="Obter Dados do Cliente"/>
                <asp:ListItem Value="4" Text="Cadastrar Projeto"/>
                <asp:ListItem Value="5" Text="Consultar Projeto"/>
                <asp:ListItem Value="6" Text="Obter Dados do Projeto"/>
                <asp:ListItem Value="7" Text="Cadastrar Sprint"/>
                <asp:ListItem Value="8" Text="Consultar Sprint"/>
                <asp:ListItem Value="9" Text="Obter Dados da Sprint"/>
            </asp:DropDownList>
            
            <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary" OnClick="btnMenu_Click"/>

            <p>
                <asp:Label ID="lblMensagem" runat="server" />
            </p>
        </div>
        <br />
        <div>
            <h2>Seus Projetos:</h2>
            <asp:GridView ID="gridProjeto" runat="server" CssClass="table table-hover" GridLines="None" AutoGenerateColumns="false" HeaderStyle-BackColor="#ccffcc">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText ="Código"/>
                        <asp:BoundField DataField="Nome" HeaderText ="Nome"/>
                        <asp:BoundField DataField="Inicio" HeaderText ="Inicio" DataFormatString = "{0:dd/MM/yyyy}"/>
                        <asp:BoundField DataField="Final" HeaderText ="Final" DataFormatString = "{0:dd/MM/yyyy}"/>
                        <asp:BoundField DataField="Descricao" HeaderText ="Descricao"/>
                    </Columns>
                </asp:GridView>
        </div>
        <br />
        <asp:Button ID="btnLogoff" runat="server" Text="Fechar Sessão" CssClass="btn btn-danger" OnClick="btnLogoff_Click"/>
    </form>
</body>
</html>
