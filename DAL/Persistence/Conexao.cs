using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // ado.net -> SQL server

namespace DAL.Persistence
{
    public class Conexao
    {
        //Atributos
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Metodo - Abrir conexao
        protected void AbrirConexao()
        {
            try
            {
                // Connection String
                Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sistemaDB.mdf;Integrated Security=True;Connect Timeout=30"); 
                Con.Open();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        // Metodo - Fechar Conexao
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
