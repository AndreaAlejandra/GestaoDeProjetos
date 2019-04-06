using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa novaPessoa = new Pessoa();

                novaPessoa.Nome = txtNome.Text;
                novaPessoa.Endereco = txtEndereco.Text;
                novaPessoa.Email = txtEmail.Text;
                novaPessoa.Senha = txtSenha.Text;

                PessoaDAL pessoaDal = new PessoaDAL();

                pessoaDal.Gravar(novaPessoa);

                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;

                lblMensagem.Text = "Cliente " + novaPessoa.Nome + " cadastrado com sucesso";

                Response.Redirect("../Login.aspx");
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

       
    }
}