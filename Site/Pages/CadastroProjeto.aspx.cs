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
    public partial class CadastroProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Projeto novoProjeto = new Projeto();

                novoProjeto.Nome = txtNome.Text;
                novoProjeto.Inicio = Convert.ToDateTime(txtInicio.Text);
                novoProjeto.Final = Convert.ToDateTime(txtInicio.Text);
                novoProjeto.Descricao = txtDescricao.Text;

                ProjetoDAL projetoDal = new ProjetoDAL();

                projetoDal.Gravar(novoProjeto);

                txtNome.Text = string.Empty;
                txtInicio.Text = string.Empty;
                txtFinal.Text = string.Empty;
                txtDescricao.Text = string.Empty;

                lblMensagem.Text = "Projeto " + novoProjeto.Nome + " cadastrado com sucesso";
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}