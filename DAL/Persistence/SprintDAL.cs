using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //bIBLIOTECA DE ACESSO AO SQL SERVER
using DAL.Model;

namespace DAL.Persistence
{
    public class SprintDAL : Conexao
    {
        //Metodo para gravar dados: INSERT
        public void Gravar(Sprint s)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Sprint(Numero, Inicio, Final, Objetivo, Codigo_Projeto) values(@v1,@v2,@v3,@v4,@v5)", Con);

                Cmd.Parameters.AddWithValue("@v1", s.Numero);
                Cmd.Parameters.AddWithValue("@v2", s.Inicio);
                Cmd.Parameters.AddWithValue("@v3", s.Final);
                Cmd.Parameters.AddWithValue("@v4", s.Objetivo);
                Cmd.Parameters.AddWithValue("@v5", s.Codigo_Projeto);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Gravar a Sprint" + ex.Message); ;
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para atualizar dados:UPDATE
        public void Atualizar (Sprint s)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Sprint set Numero=@v1, Inicio=@v2, Final=@v3, Objetivo=@v4, Codigo_Projeto=@v5 where Codigo=@v6", Con);

                Cmd.Parameters.AddWithValue("@v1", s.Numero);
                Cmd.Parameters.AddWithValue("@v2", s.Inicio);
                Cmd.Parameters.AddWithValue("@v3", s.Final);
                Cmd.Parameters.AddWithValue("@v4", s.Objetivo);
                Cmd.Parameters.AddWithValue("@v5", s.Codigo_Projeto);
                Cmd.Parameters.AddWithValue("@v6", s.Codigo);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception( "Erro ao atualizar a Sprint " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para excluir dados:DELETE
        public void Excluir (int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Sprint where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir a Sprint" + ex.Message); ;
            }
            finally
            {
                FecharConexao();
            }
        }
        // Metodo para obter 1 pessoa pelo codigo:SELECT
        public Sprint PesquisarPorCodigo (int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Sprint where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Dr = Cmd.ExecuteReader();

                Sprint sprintEncontrada = new Sprint();

                if (Dr.Read())
                {
                    sprintEncontrada.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    sprintEncontrada.Numero = Convert.ToInt32(Dr["Numero"]);
                    sprintEncontrada.Inicio = Convert.ToDateTime(Dr["Inicio"]);
                    sprintEncontrada.Final = Convert.ToDateTime(Dr["Final"]);
                    sprintEncontrada.Objetivo = Convert.ToString(Dr["Objetivo"]);
                    sprintEncontrada.Codigo_Projeto = Convert.ToInt32(Dr["Codigo_Projeto"]);
                }
                return sprintEncontrada;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar Sprint" + ex.Message); 
            }
            finally
            {
                FecharConexao();
            }
        }
        // Metodo para listar todas as pessoas:SELECT
        public List<Sprint> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Sprint", Con);

                Dr = Cmd.ExecuteReader();

                List<Sprint> listaSprint = new List<Sprint>();

                while (Dr.Read())
                {
                    Sprint SprintEncontrada = new Sprint();

                    SprintEncontrada.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    SprintEncontrada.Numero = Convert.ToInt32(Dr["Numero"]);
                    SprintEncontrada.Inicio = Convert.ToDateTime(Dr["Inicio"]);
                    SprintEncontrada.Final = Convert.ToDateTime(Dr["Final"]);
                    SprintEncontrada.Objetivo = Convert.ToString(Dr["Objetivo"]);
                    SprintEncontrada.Codigo_Projeto = Convert.ToInt32(Dr["Codigo_Projeto"]);
                    listaSprint.Add(SprintEncontrada);
                }
                return listaSprint;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao lista a Sprint " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }


}
//regra de negocio da nossa aplicacao - consultas!
//SELECT, UPLODE, INSERT, DELETE, OBTERPORID
