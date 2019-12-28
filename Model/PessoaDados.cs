using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    class PessoaDados
    {
        private int pessoaCodigo;
        private string pessoaCPF;
        private string pessoaNome;
        private bool pessoaTipo;

        public int PessoaCodigo { get => pessoaCodigo; set => pessoaCodigo = value; }
        public string PessoaCPF { get => pessoaCPF; set => pessoaCPF = value; }
        public string PessoaNome { get => pessoaNome; set => pessoaNome = value; }
        public bool PessoaTipo { get => pessoaTipo; set => pessoaTipo = value; }

        public PessoaDados()
        {

        }

        public PessoaDados(int pessoaCodigo, string pessoaCPF, string pessoaNome, bool pessoaTipo)
        {
            this.PessoaCodigo = pessoaCodigo;
            this.PessoaCPF = pessoaCPF;
            this.PessoaNome = pessoaNome;
            this.PessoaTipo = pessoaTipo;
        }        
        //Cadastrar
        public void CadastrarPessoa(PessoaDados Pessoa)
        {
            string mensagem = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_cadastrarPessoa";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                
                //Parãmetro CÓDIGO
                SqlParameter PPessoaCodigo = new SqlParameter();
                PPessoaCodigo.ParameterName = "@pessoaCodigo";
                PPessoaCodigo.SqlDbType = SqlDbType.Int;
                PPessoaCodigo.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(PPessoaCodigo);
                //Parãmetro CPF
                SqlParameter PPessoaCPF = new SqlParameter();
                PPessoaCPF.ParameterName = "@pessoaCPF";
                PPessoaCPF.SqlDbType = SqlDbType.VarChar;
                PPessoaCPF.Size = 11;
                PPessoaCPF.Value = Pessoa.PessoaCPF;
                sqlCommand.Parameters.Add(PPessoaCPF);
                //Parãmetro NOME
                SqlParameter PPessoaNome = new SqlParameter();
                PPessoaNome.ParameterName = "@pessoaNome";
                PPessoaNome.SqlDbType = SqlDbType.VarChar;
                PPessoaNome.Size = 50;
                PPessoaNome.Value = Pessoa.PessoaNome;
                sqlCommand.Parameters.Add(PPessoaNome);
                //Parãmetro TIPO
                SqlParameter PPessoaTipo = new SqlParameter();
                PPessoaTipo.ParameterName = "@pessoaTipo";
                PPessoaTipo.SqlDbType = SqlDbType.Char;
                PPessoaTipo.Value = Pessoa.PessoaTipo;
                sqlCommand.Parameters.Add(PPessoaTipo);

                mensagem = sqlCommand.ExecuteNonQuery() == 1 ? 
                    "Cadastro realizado com sucesso" : "Algo de errado ocorreu e não foi possível inserir o registro";

            } catch(Exception e)
            {
                mensagem = e.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }
        //Alterar
        public void AlterarPessoa(PessoaDados Pessoa)
        {
            string mensagem = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_alterarPessoa";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //Parãmetro CÓDIGO
                SqlParameter PPessoaCodigo = new SqlParameter();
                PPessoaCodigo.ParameterName = "@pessoaCodigo";
                PPessoaCodigo.SqlDbType = SqlDbType.Int;
                PPessoaCodigo.Value = Pessoa.PessoaCodigo;
                sqlCommand.Parameters.Add(PPessoaCodigo);
                //Parãmetro CPF
                SqlParameter PPessoaCPF = new SqlParameter();
                PPessoaCPF.ParameterName = "@pessoaCPF";
                PPessoaCPF.SqlDbType = SqlDbType.VarChar;
                PPessoaCPF.Size = 11;
                PPessoaCPF.Value = Pessoa.PessoaCPF;
                sqlCommand.Parameters.Add(PPessoaCPF);
                //Parãmetro NOME
                SqlParameter PPessoaNome = new SqlParameter();
                PPessoaNome.ParameterName = "@pessoaNome";
                PPessoaNome.SqlDbType = SqlDbType.VarChar;
                PPessoaNome.Size = 50;
                PPessoaNome.Value = Pessoa.PessoaNome;
                sqlCommand.Parameters.Add(PPessoaNome);
                //Parãmetro TIPO
                SqlParameter PPessoaTipo = new SqlParameter();
                PPessoaTipo.ParameterName = "@pessoaTipo";
                PPessoaTipo.SqlDbType = SqlDbType.Char;
                PPessoaTipo.Value = Pessoa.PessoaTipo;
                sqlCommand.Parameters.Add(PPessoaTipo);

                mensagem = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Cadastro realizado com sucesso" : "Algo de errado ocorreu e não foi possível alterar o registro";

            }
            catch (Exception e)
            {
                mensagem = e.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }
        //Excluir
        public void ExcluirPessoa(PessoaDados Pessoa)
        {
            string mensagem = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_excluirPessoa";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //Parãmetro CÓDIGO
                SqlParameter PPessoaCodigo = new SqlParameter();
                PPessoaCodigo.ParameterName = "@pessoaCodigo";
                PPessoaCodigo.SqlDbType = SqlDbType.Int;
                PPessoaCodigo.Value = Pessoa.PessoaCodigo;
                sqlCommand.Parameters.Add(PPessoaCodigo);

                mensagem = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Cadastro realizado com sucesso" : "Algo de errado ocorreu e não foi possível excluir o registro";

            }
            catch (Exception e)
            {
                mensagem = e.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }
        //Consultar
        public DataTable ConsultarPessoa(PessoaDados Pessoa)
        {
            DataTable dataTablePessoa = new DataTable("pessoa");
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection.ConnectionString = ConexaoDB.conexao;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_consultarPessoa";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parãmetro CÓDIGO
                SqlParameter PPessoaCodigo = new SqlParameter();
                PPessoaCodigo.ParameterName = "@pessoaCodigo";
                PPessoaCodigo.SqlDbType = SqlDbType.Int;
                PPessoaCodigo.Value = Pessoa.PessoaCodigo;
                sqlCommand.Parameters.Add(PPessoaCodigo);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTablePessoa);
            }
            catch (Exception)
            {
                dataTablePessoa = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            return dataTablePessoa;
        }
    }
}
