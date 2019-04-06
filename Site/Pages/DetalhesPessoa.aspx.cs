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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensagem.Text = string.Empty;

                int codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL pessoaDal = new PessoaDAL();
                Pessoa cliente = pessoaDal.PesquisarPorCodigo(codigo);

                if(cliente != null && cliente.Codigo != 0)
                {
                    pnlDados.Visible = true;

                    txtNome.Text = cliente.Nome;
                    txtEndereco.Text = cliente.Endereco;
                    txtEmail.Text = cliente.Email;
                }
                else
                {
                    lblMensagem.Text = "Cliente não encontrado.";
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExclui_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL pessoaDal = new PessoaDAL();
                pessoaDal.Excluir(codigo);

                lblMensagem.Text = "Cliente excluído com sucesso";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAtualiza_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa cliente = new Pessoa();
                cliente.Codigo = Convert.ToInt32(txtCodigo.Text);
                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Email = txtEmail.Text;

                PessoaDAL pessoaDal = new PessoaDAL();
                pessoaDal.Atualizar(cliente);

                lblMensagem.Text = "Cliente atualizado com sucesso";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}