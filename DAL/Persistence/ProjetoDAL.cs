using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //bIBLIOTECA DE ACESSO AO SQL SERVER
using DAL.Model;

namespace DAL.Persistence
{
    public class ProjetoDAL : Conexao
    {
        //Metodo para gravar dados: INSERT
        public void Gravar(Projeto p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Projeto(Nome, Inicio, Final, Descricao) values(@v1,@v2,@v3,@v4)", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Inicio);
                Cmd.Parameters.AddWithValue("@v3", p.Final);
                Cmd.Parameters.AddWithValue("@v4", p.Descricao);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Gravar o Projeto" + ex.Message);

            }
            finally
            {
                FecharConexao();
            }
        }


        // Metodo para atualizar dados:UPDATE
        public void Atualizar(Projeto p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Projeto set Nome=@v1, Inicio=@v2, Final=@v3, Descricao=@v4 where Codigo=@v5", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Inicio);
                Cmd.Parameters.AddWithValue("@v3", p.Final);
                Cmd.Parameters.AddWithValue("@v4", p.Descricao);
                Cmd.Parameters.AddWithValue("@v5", p.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar Projeto " + ex.Message);
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
                Cmd = new SqlCommand("delete from Projeto where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir o Projeto" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para obter 1 pessoa pelo codigo:SELECT
        public Projeto PesquisarPorCodigo (int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Projeto where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Dr = Cmd.ExecuteReader();

                Projeto projetoEncontrado = new Projeto();

                if (Dr.Read())
                {
                    projetoEncontrado.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    projetoEncontrado.Nome = Convert.ToString(Dr["Nome"]);
                    projetoEncontrado.Inicio = Convert.ToDateTime(Dr["Inicio"]);
                    projetoEncontrado.Final = Convert.ToDateTime(Dr["Final"]);
                    projetoEncontrado.Descricao = Convert.ToString(Dr["Descricao"]);
                }
                return projetoEncontrado;
            
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao pesquisar Projeto" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para listar todas as pessoas:SELECT
        public List<Projeto>Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Projeto", Con);

                Dr = Cmd.ExecuteReader();

                List<Projeto> listaProjeto = new List<Projeto>();

                while (Dr.Read())
                {
                    Projeto projetoEncontrado = new Projeto();

                    projetoEncontrado.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    projetoEncontrado.Nome = Convert.ToString(Dr["Nome"]);
                    projetoEncontrado.Inicio = Convert.ToDateTime(Dr["Inicio"]);
                    projetoEncontrado.Final = Convert.ToDateTime(Dr["Final"]);
                    projetoEncontrado.Descricao = Convert.ToString(Dr["Descricao"]);

                    listaProjeto.Add(projetoEncontrado);
                }
                return listaProjeto;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar os Projetos" + ex.Message); 
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para listar todas as pessoas:SELECT
        public List<Projeto> ListarProjetosPorUsuario(int codigoUsuario)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Projeto proj inner join Usuario_Projeto usuproj on proj.Codigo = usuproj.Codigo_Projeto where usuproj.Codigo_Usuario = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", codigoUsuario);

                Dr = Cmd.ExecuteReader();

                List<Projeto> listaProjeto = new List<Projeto>();

                while (Dr.Read())
                {
                    Projeto projetoEncontrado = new Projeto();

                    projetoEncontrado.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    projetoEncontrado.Nome = Convert.ToString(Dr["Nome"]);
                    projetoEncontrado.Inicio = Convert.ToDateTime(Dr["Inicio"]);
                    projetoEncontrado.Final = Convert.ToDateTime(Dr["Final"]);
                    projetoEncontrado.Descricao = Convert.ToString(Dr["Descricao"]);

                    listaProjeto.Add(projetoEncontrado);
                }
                return listaProjeto;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar os Projetos" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Metodo para gravar dados: INSERT
        public void GravarNovoUsuarioNoProjeto(int codigoUsuario, int codigoProjeto)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Usuario_Projeto(Codigo_Usuario, Codigo_Projeto) values(@v1,@v2)", Con);

                Cmd.Parameters.AddWithValue("@v1", codigoUsuario);
                Cmd.Parameters.AddWithValue("@v2", codigoProjeto);

                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Gravar o Usuario no Projeto " + ex.Message);

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
