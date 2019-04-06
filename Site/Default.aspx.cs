using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuarioLogado = Convert.ToString(Session["NomeUsuarioLogado"]);
            int codigoUsuarioLogado = Convert.ToInt32(Session["CodigoUsuarioLogado"]);

            lblUsuarioLogado.Text = usuarioLogado;

            ProjetoDAL dal = new ProjetoDAL();
            gridProjeto.DataSource = dal.ListarProjetosPorUsuario(codigoUsuarioLogado);
            gridProjeto.DataBind();

        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            string opcaoSelecionada = ddlMenu.SelectedValue;

            switch (opcaoSelecionada)
            {
                case "0":
                    lblMensagem.Text = "Por favor, selecione uma opção válida!";
                    break;
                case "1":
                    Response.Redirect("/Pages/CadastroPessoa.aspx");
                    break;
                case "2":
                    Response.Redirect("/Pages/ConsultaPessoa.aspx");
                    break;
                case "3":
                    Response.Redirect("/Pages/DetalhesPessoa.aspx");
                    break;
                case "4":
                    Response.Redirect("/Pages/CadastroProjeto.aspx");
                    break;
                case "5":
                    Response.Redirect("/Pages/ConsultaProjeto.aspx");
                    break;
                case "6":
                    Response.Redirect("/Pages/DetalhesProjeto.aspx");
                    break;
                case "7":
                    Response.Redirect("/Pages/CadastroSprint.aspx");
                    break;
                case "8":
                    Response.Redirect("/Pages/ConsultaSprint.aspx");
                    break;
                case "9":
                    Response.Redirect("/Pages/DetalhesSprint.aspx");
                    break;              
                default:
                    break;
            }
        }

        protected void btnLogoff_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }
    }
}