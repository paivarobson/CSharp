using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ClienteDados
    {
        private int clienteCodigo;
        private string clienteCPF;
        private string clienteNome;
        private bool clienteTipo;

        public int ClienteCodigo { get => clienteCodigo; set => clienteCodigo = value; }
        public string ClienteCPF { get => clienteCPF; set => clienteCPF = value; }
        public string ClienteNome { get => clienteNome; set => clienteNome = value; }
        public bool ClienteTipo { get => clienteTipo; set => clienteTipo = value; }

        public ClienteDados()
        {

        }

        public ClienteDados(int clienteCodigo, string clienteCPF, string clienteNome, bool clienteTipo)
        {
            this.ClienteCodigo = clienteCodigo;
            this.ClienteCPF = clienteCPF;
            this.ClienteNome = clienteNome;
            this.ClienteTipo = clienteTipo;
        }        
        //CADASTRAR
        public string CadastrarCliente(ClienteDados Cliente)
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
                sqlCommand.CommandText = "proc_cadastrarCliente";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                
                //Parãmetro CÓDIGO
                SqlParameter PClienteCodigo = new SqlParameter();
                PClienteCodigo.ParameterName = "@clienteCodigo";
                PClienteCodigo.SqlDbType = SqlDbType.Int;
                PClienteCodigo.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(PClienteCodigo);
                //Parãmetro CPF
                SqlParameter PClienteCPF = new SqlParameter();
                PClienteCPF.ParameterName = "@clienteCPF";
                PClienteCPF.SqlDbType = SqlDbType.VarChar;
                PClienteCPF.Size = 11;
                PClienteCPF.Value = Cliente.ClienteCPF;
                sqlCommand.Parameters.Add(PClienteCPF);
                //Parãmetro NOME
                SqlParameter PClienteNome = new SqlParameter();
                PClienteNome.ParameterName = "@clienteNome";
                PClienteNome.SqlDbType = SqlDbType.VarChar;
                PClienteNome.Size = 50;
                PClienteNome.Value = Cliente.ClienteNome;
                sqlCommand.Parameters.Add(PClienteNome);
                //Parãmetro TIPO
                SqlParameter PClienteTipo = new SqlParameter();
                PClienteTipo.ParameterName = "@clienteTipo";
                PClienteTipo.SqlDbType = SqlDbType.Char;
                PClienteTipo.Value = Cliente.ClienteTipo;
                sqlCommand.Parameters.Add(PClienteTipo);

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

            return mensagem;
        }
        //ALTERAR
        public string AlterarCliente(ClienteDados Cliente)
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
                sqlCommand.CommandText = "proc_alterarCliente";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //Parãmetro CÓDIGO
                SqlParameter PClienteCodigo = new SqlParameter();
                PClienteCodigo.ParameterName = "@clienteCodigo";
                PClienteCodigo.SqlDbType = SqlDbType.Int;
                PClienteCodigo.Value = Cliente.ClienteCodigo;
                sqlCommand.Parameters.Add(PClienteCodigo);
                //Parãmetro CPF
                SqlParameter PClienteCPF = new SqlParameter();
                PClienteCPF.ParameterName = "@clienteCPF";
                PClienteCPF.SqlDbType = SqlDbType.VarChar;
                PClienteCPF.Size = 11;
                PClienteCPF.Value = Cliente.ClienteCPF;
                sqlCommand.Parameters.Add(PClienteCPF);
                //Parãmetro NOME
                SqlParameter PClienteNome = new SqlParameter();
                PClienteNome.ParameterName = "@clienteNome";
                PClienteNome.SqlDbType = SqlDbType.VarChar;
                PClienteNome.Size = 50;
                PClienteNome.Value = Cliente.ClienteNome;
                sqlCommand.Parameters.Add(PClienteNome);
                //Parãmetro TIPO
                SqlParameter PClienteTipo = new SqlParameter();
                PClienteTipo.ParameterName = "@clienteTipo";
                PClienteTipo.SqlDbType = SqlDbType.Char;
                PClienteTipo.Value = Cliente.ClienteTipo;
                sqlCommand.Parameters.Add(PClienteTipo);

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

            return mensagem;
        }
        //EXCLUIR
        public string ExcluirCliente(ClienteDados Cliente)
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
                sqlCommand.CommandText = "proc_excluirCliente";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parãmetro CÓDIGO
                SqlParameter PClienteCodigo = new SqlParameter();
                PClienteCodigo.ParameterName = "@clienteCodigo";
                PClienteCodigo.SqlDbType = SqlDbType.Int;
                PClienteCodigo.Value = Cliente.ClienteCodigo;
                sqlCommand.Parameters.Add(PClienteCodigo);

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

            return mensagem;
        }
        //CONSULTAR
        public DataTable ConsultarCliente(ClienteDados Cliente)
        {
            DataTable dataTableCliente = new DataTable("cliente");
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_consultarCliente";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parãmetro CÓDIGO
                SqlParameter PClienteCodigo = new SqlParameter();
                PClienteCodigo.ParameterName = "@clienteCodigo";
                PClienteCodigo.SqlDbType = SqlDbType.Int;
                PClienteCodigo.Value = Cliente.ClienteCodigo;
                sqlCommand.Parameters.Add(PClienteCodigo);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTableCliente);
            }
            catch (Exception)
            {
                dataTableCliente = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            return dataTableCliente;
        }
    }
}
