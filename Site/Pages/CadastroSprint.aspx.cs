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
    public partial class CadastroSprint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Sprint novaSprint = new Sprint();

                novaSprint.Numero = Convert.ToInt32(txtNumero.Text);
                novaSprint.Inicio = Convert.ToDateTime(txtInicio.Text);
                novaSprint.Final = Convert.ToDateTime(txtFinal.Text);
                novaSprint.Objetivo = txtDescricao.Text;
                novaSprint.Codigo_Projeto = Convert.ToInt32(txtCodigoProjeto.Text);

                SprintDAL projetoDal = new SprintDAL();

                projetoDal.Gravar(novaSprint);

                txtNumero.Text = string.Empty;
                txtInicio.Text = string.Empty;
                txtFinal.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtCodigoProjeto.Text = string.Empty;

                lblMensagem.Text = "Sprint " + novaSprint.Numero + " cadastrado com sucesso";
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}
