using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class VeiculoDados
    {

        private int veiculoCodigo;
        private string veiculoPlaca;
        private string veiculoDescricao;

        public int VeiculoCodigo { get => veiculoCodigo; set => veiculoCodigo = value; }
        public string VeiculoPlaca { get => veiculoPlaca; set => veiculoPlaca = value; }
        public string VeiculoDescricao { get => veiculoDescricao; set => veiculoDescricao = value; }

        public VeiculoDados()
        {

        }

        SqlCommand sqlCommand = new SqlCommand();
        SqlConnection sqlConnection = new SqlConnection();

        public VeiculoDados(int veiculoCodigo, string veiculoPlaca, string veiculoDescricao)
        {
            this.VeiculoCodigo = veiculoCodigo;
            this.VeiculoPlaca = veiculoPlaca;
            this.VeiculoDescricao = veiculoDescricao;
        }
        //CADASTRAR
        public string CadastrarVeiculo(VeiculoDados Veiculo)
        {
            string mensagem = "";

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_cadastrarVeiculo";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //Parãmetro Placa
                SqlParameter PVeiculoPlaca = new SqlParameter();
                PVeiculoPlaca.ParameterName = "@veiculoPlaca";
                PVeiculoPlaca.SqlDbType = SqlDbType.VarChar;
                PVeiculoPlaca.Size = 7;
                PVeiculoPlaca.Value = Veiculo.VeiculoPlaca;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(PVeiculoPlaca);
                //Parãmetro NOME
                SqlParameter PVeiculoDescricao = new SqlParameter();
                PVeiculoDescricao.ParameterName = "@veiculoDescricao";
                PVeiculoDescricao.SqlDbType = SqlDbType.VarChar;
                PVeiculoDescricao.Size = 50;
                PVeiculoDescricao.Value = Veiculo.VeiculoDescricao;
                sqlCommand.Parameters.Add(PVeiculoDescricao);

                mensagem = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Cadastro realizado com sucesso" : "Algo de errado ocorreu e não foi possível inserir o registro";

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
        //ALTERAR
        public string AlterarVeiculo(VeiculoDados Veiculo)
        {
            string mensagem = "";

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_alterarVeiculo";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //Parãmetro CÓDIGO
                SqlParameter PVeiculoCodigo = new SqlParameter();
                PVeiculoCodigo.ParameterName = "@veiculoCodigo";
                PVeiculoCodigo.SqlDbType = SqlDbType.Int;
                PVeiculoCodigo.Value = Veiculo.VeiculoCodigo;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(PVeiculoCodigo);
                //Parãmetro Placa
                SqlParameter PVeiculoPlaca = new SqlParameter();
                PVeiculoPlaca.ParameterName = "@veiculoPlaca";
                PVeiculoPlaca.SqlDbType = SqlDbType.VarChar;
                PVeiculoPlaca.Size = 7;
                PVeiculoPlaca.Value = Veiculo.VeiculoPlaca;
                sqlCommand.Parameters.Add(PVeiculoPlaca);
                //Parãmetro NOME
                SqlParameter PVeiculoDescricao = new SqlParameter();
                PVeiculoDescricao.ParameterName = "@veiculoDescricao";
                PVeiculoDescricao.SqlDbType = SqlDbType.VarChar;
                PVeiculoDescricao.Size = 50;
                PVeiculoDescricao.Value = Veiculo.VeiculoDescricao;
                sqlCommand.Parameters.Add(PVeiculoDescricao);

                mensagem = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Alteração realizada com sucesso" : "Algo de errado ocorreu e não foi possível alterar o registro";

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
        public string ExcluirVeiculo(VeiculoDados Veiculo)
        {
            string mensagem = "";

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_excluirVeiculo";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parãmetro CÓDIGO
                SqlParameter PVeiculoCodigo = new SqlParameter();
                PVeiculoCodigo.ParameterName = "@veiculoCodigo";
                PVeiculoCodigo.SqlDbType = SqlDbType.Int;
                PVeiculoCodigo.Value = Veiculo.VeiculoCodigo;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(PVeiculoCodigo);

                mensagem = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Exclusão realizada com sucesso" : "Algo de errado ocorreu e não foi possível excluir o registro";

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
        public DataTable ConsultarVeiculo(VeiculoDados Veiculo)
        {
            DataTable dataTableVeiculo = new DataTable("veiculo");

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_consultarVeiculo";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parãmetro CÓDIGO
                SqlParameter PVeiculoCodigo = new SqlParameter();
                PVeiculoCodigo.ParameterName = "@veiculoCodigo";
                PVeiculoCodigo.SqlDbType = SqlDbType.Int;
                PVeiculoCodigo.Value = Veiculo.VeiculoCodigo;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(PVeiculoCodigo);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTableVeiculo);
            }
            catch (Exception e)
            {
                dataTableVeiculo = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            return dataTableVeiculo;
        }
        //RECUPERAR ÚLTIMO REGISTRO CADASTRADO
        public DataTable RecuperarUltimoCadastroVeiculo(VeiculoDados Veiculo)
        {
            DataTable dataTableVeiculo = new DataTable("veiculo");

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_recuperarUltimoCadastroVeiculo";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTableVeiculo);
            }
            catch (Exception)
            {
                dataTableVeiculo = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            return dataTableVeiculo;
        }        
        //LOCAR VEÍCULO
        public string LocarVeiculo(VeiculoDados Veiculo)
        {
            string mensagem = "";

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_LocarVeiculo";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //Parãmetro CÓDIGO
                SqlParameter PVeiculoCodigo = new SqlParameter();
                PVeiculoCodigo.ParameterName = "@veiculoCodigo";
                PVeiculoCodigo.SqlDbType = SqlDbType.Int;
                PVeiculoCodigo.Value = Veiculo.VeiculoCodigo;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(PVeiculoCodigo);

                mensagem = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Veículo locado com sucesso" : "Algo de errado ocorreu e não foi possível alterar o registro";

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
        //LIBERAR VEÍCULO PARA LOCAÇÃO
        public string LiberarVeiculoParaLocacao(VeiculoDados Veiculo)
        {
            string mensagem = "";

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_LiberarVeiculo";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //Parãmetro CÓDIGO
                SqlParameter PVeiculoCodigo = new SqlParameter();
                PVeiculoCodigo.ParameterName = "@veiculoCodigo";
                PVeiculoCodigo.SqlDbType = SqlDbType.Int;
                PVeiculoCodigo.Value = Veiculo.VeiculoCodigo;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(PVeiculoCodigo);

                mensagem = sqlCommand.ExecuteNonQuery() == 1 ?
                    "Veículo liberado para locação com sucesso" : "Algo de errado ocorreu e não foi possível alterar o registro";

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
    }
}
