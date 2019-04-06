using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //bIBLIOTECA DE ACESSO AO SQL SERVER
using DAL.Model;

namespace DAL.Persistence
{
    public class PessoaDAL : Conexao
    {
        //Metodo para gravar dados: INSERT
        public void Gravar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Pessoa(Nome, Endereco, Email, Senha) values(@v1,@v2,@v3,@v4)", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Senha);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(" Erro ao Gravar o Cliente " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para atualizar dados:UPDATE
        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Pessoa set Nome=@v1, Endereco=@v2, Email=@v3 where Codigo=@v4", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o Cliente" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para excluir dados:DELETE
        public void Excluir(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Pessoa where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o Cliente" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para obter 1 pessoa pelo codigo:SELECT
        public Pessoa PesquisarPorCodigo(int Codigo)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa where Codigo=@v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Dr = Cmd.ExecuteReader();

                Pessoa pessoaEncontrada = new Pessoa();

                if (Dr.Read())
                {
                    pessoaEncontrada.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    pessoaEncontrada.Nome = Convert.ToString(Dr["Nome"]);
                    pessoaEncontrada.Endereco = Convert.ToString(Dr["Endereco"]);
                    pessoaEncontrada.Email = Convert.ToString(Dr["Email"]);
                    pessoaEncontrada.Senha = Convert.ToString(Dr["Senha"]);
                }

                return pessoaEncontrada;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar o Cliente" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // Metodo para listar todas as pessoas:SELECT
        public List<Pessoa> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa", Con);

                Dr = Cmd.ExecuteReader();

                List<Pessoa> listaPessoas = new List<Pessoa>();

                while (Dr.Read())
                {
                    Pessoa pessoaEncontrada = new Pessoa();

                    pessoaEncontrada.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    pessoaEncontrada.Nome = Convert.ToString(Dr["Nome"]);
                    pessoaEncontrada.Endereco = Convert.ToString(Dr["Endereco"]);
                    pessoaEncontrada.Email = Convert.ToString(Dr["Email"]);

                    listaPessoas.Add(pessoaEncontrada);
                }

                return listaPessoas;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar os Clientes" + ex.Message);
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