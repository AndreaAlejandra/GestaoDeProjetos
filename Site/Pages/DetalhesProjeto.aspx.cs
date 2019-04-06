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
    public partial class DetalhesProjeto : System.Web.UI.Page
    {
        public object DateTimeFinal { get; private set; }
        public object DateTimeInicio { get; private set; }

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

                ProjetoDAL projetoDal = new ProjetoDAL();
                Projeto projeto = projetoDal.PesquisarPorCodigo(codigo);

                if (projeto != null && projeto.Codigo != 0)
                {
                    pnlDados.Visible = true;

                    txtNome.Text = projeto.Nome;
                    txtInicio.Text = projeto.Inicio.ToString("dd-MM-yyyy");
                    txtFinal.Text = projeto.Final.ToString("dd-MM-yyyy");
                    txtDescricao.Text = projeto.Descricao;
                }
                else
                {
                    lblMensagem.Text = "Projeto não encontrado.";
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

                ProjetoDAL projetoDal = new ProjetoDAL();
                projetoDal.Excluir(codigo);

                lblMensagem.Text = "Projeto excluído com sucesso";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtInicio.Text = string.Empty;
                txtFinal.Text = string.Empty;
                txtDescricao.Text = string.Empty;
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
                Projeto projeto = new Projeto();
                projeto.Codigo = Convert.ToInt32(txtCodigo.Text);
                projeto.Nome = txtNome.Text;
                projeto.Inicio = Convert.ToDateTime(txtInicio.Text);
                projeto.Final = Convert.ToDateTime(txtInicio.Text);
                projeto.Descricao = txtDescricao.Text;

                ProjetoDAL projetoDal = new ProjetoDAL();
                projetoDal.Atualizar(projeto);

                lblMensagem.Text = "Projeto atualizado com sucesso";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtInicio.Text = string.Empty;
                txtFinal.Text = string.Empty;
                txtDescricao.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoProjeto = Convert.ToInt32(txtCodigo.Text);
                int codigoUsuario = Convert.ToInt32(txtCodigoUsuario.Text);

                ProjetoDAL dal = new ProjetoDAL();
                dal.GravarNovoUsuarioNoProjeto(codigoUsuario, codigoProjeto);
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}
        