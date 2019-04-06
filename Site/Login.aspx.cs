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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string senha = txtSenha.Text;

            PessoaDAL pessoaDal = new PessoaDAL();
            Pessoa usuarioEncontrado = pessoaDal.PesquisarPorCodigo(codigo);

            if (usuarioEncontrado.Codigo != 0)
            {
                if (senha == usuarioEncontrado.Senha)
                {
                    Session["CodigoUsuarioLogado"] = usuarioEncontrado.Codigo;
                    Session["NomeUsuarioLogado"] = usuarioEncontrado.Nome;

                    Response.Redirect("Default.aspx");
                }
                else
                {
                    lblMensagem.Text = "Senha do usuário incorreta!";
                }
            }
            else
            {
                lblMensagem.Text = "Usuário não encontrado!";
            }

            txtCodigo.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pages/CadastroPessoa.aspx");
        }
    }
}