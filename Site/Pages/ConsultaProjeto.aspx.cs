using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class ConsultaProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ProjetoDAL projetoDal = new ProjetoDAL();

                gridProjeto.DataSource = projetoDal.Listar(); //Popular o grid
                gridProjeto.DataBind(); //Exibe o conteudo do grid
                
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}