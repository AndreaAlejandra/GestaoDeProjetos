using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class ConsultaSprint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SprintDAL SprintDal = new SprintDAL();

                gridSprint.DataSource = SprintDal.Listar(); //Popular o grid
                gridSprint.DataBind(); //Exibe o conteudo do grid

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

    }
}