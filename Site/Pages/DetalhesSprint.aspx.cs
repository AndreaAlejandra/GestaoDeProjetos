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
    public partial class DetalheSprint : System.Web.UI.Page
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

                SprintDAL sprintDal = new SprintDAL();
                Sprint sprint = sprintDal.PesquisarPorCodigo(codigo);

                if (sprint != null && sprint.Codigo != 0)
                {
                    pnlDados.Visible = true;

                    txtNumero.Text = Convert.ToString(sprint.Numero);
                    txtInicio.Text = sprint.Inicio.ToString("dd-MM-yyyy");
                    txtFinal.Text = sprint.Final.ToString("dd-MM-yyyy");
                    txtDescricao.Text = Convert.ToString(sprint.Objetivo);
                    txtCodigoProjeto.Text = Convert.ToString(sprint.Codigo_Projeto); 
                }
                else
                {
                    lblMensagem.Text = "Sprint não encontrada.";
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

                SprintDAL sprintDal = new SprintDAL();
                sprintDal.Excluir(codigo);

                lblMensagem.Text = "Sprint excluída com sucesso";

                txtCodigo.Text = string.Empty;
                txtNumero.Text = string.Empty;
                txtInicio.Text = string.Empty;
                txtFinal.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtCodigoProjeto.Text = string.Empty;
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
                Sprint sprint = new Sprint();
                sprint.Codigo = Convert.ToInt32(txtCodigo.Text);
                sprint.Numero = Convert.ToInt32(txtCodigo.Text);
                sprint.Inicio = Convert.ToDateTime(txtInicio.Text);
                sprint.Final = Convert.ToDateTime(txtFinal.Text);
                sprint.Objetivo = txtDescricao.Text;
                sprint.Codigo_Projeto = Convert.ToInt32(txtCodigoProjeto.Text); 

                SprintDAL sprintDal = new SprintDAL();
                sprintDal.Atualizar(sprint);

                lblMensagem.Text = "Projeto atualizado com sucesso";

                txtCodigo.Text = string.Empty;
                txtNumero.Text = string.Empty;
                txtInicio.Text = string.Empty;
                txtFinal.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtCodigoProjeto.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}
    
