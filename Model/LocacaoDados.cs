using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class LocacaoDados
    {
        private int locacaoCodigo;
        private int veiculoCodigo;
        private int clienteCodigo;
        private DateTime locacaoData;
        private DateTime locacaoDataDevolucao;
        private decimal locacaoValorDiaria;

        public int LocacaoCodigo { get => locacaoCodigo; set => locacaoCodigo = value; }
        public DateTime LocacaoData { get => locacaoData; set => locacaoData = value; }
        public DateTime LocacaoDataDevolucao { get => locacaoDataDevolucao; set => locacaoDataDevolucao = value; }
        public decimal LocacaoValorDiaria { get => locacaoValorDiaria; set => locacaoValorDiaria = value; }
        public int ClienteCodigo { get => clienteCodigo; set => clienteCodigo = value; }
        public int VeiculoCodigo { get => veiculoCodigo; set => veiculoCodigo = value; }

        public LocacaoDados()
        {

        }

        SqlCommand sqlCommand = new SqlCommand();
        SqlConnection sqlConnection = new SqlConnection();

        public LocacaoDados(
            int locacaoCodigo, 
            int veiculoCodigo,
            int clienteCodigo,
            DateTime locacaoData, 
            DateTime locacaoDataDevolucao, 
            decimal locacaoValorDiaria)
        {
            this.LocacaoCodigo = locacaoCodigo;
            this.LocacaoData = locacaoData;
            this.LocacaoDataDevolucao = locacaoDataDevolucao;
            this.LocacaoValorDiaria = locacaoValorDiaria;
            this.VeiculoCodigo = veiculoCodigo;
            this.ClienteCodigo = clienteCodigo;
        }
        //CADASTRAR
        public string CadastrarLocacao(LocacaoDados Locacao)
        {
            string mensagem = "";

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_cadastrarLocacao";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //Parãmetro CÓDIGO VEÍCULO
                SqlParameter PVeiculoCodigo = new SqlParameter();
                PVeiculoCodigo.ParameterName = "@veiculoCodigo";
                PVeiculoCodigo.SqlDbType = SqlDbType.Int;
                PVeiculoCodigo.Value = Locacao.VeiculoCodigo;
                sqlCommand.Parameters.Add(PVeiculoCodigo);
                //Parãmetro CÓDIGO CLIENTE
                SqlParameter PClienteCodigo = new SqlParameter();
                PClienteCodigo.ParameterName = "@clienteCodigo";
                PClienteCodigo.SqlDbType = SqlDbType.Int;
                PClienteCodigo.Value = Locacao.clienteCodigo;
                sqlCommand.Parameters.Add(PClienteCodigo);
                //Parãmetro DATA
                SqlParameter PLocacaoData = new SqlParameter();
                PLocacaoData.ParameterName = "@locacaoData";
                PLocacaoData.SqlDbType = SqlDbType.DateTime;
                PLocacaoData.Value = Locacao.locacaoData;
                sqlCommand.Parameters.Add(PLocacaoData);
                //Parãmetro DATA DEVOLUÇÃO
                SqlParameter PLocacaoDataDevolucao = new SqlParameter();
                PLocacaoDataDevolucao.ParameterName = "@locacaoDataDevolucao";
                PLocacaoDataDevolucao.SqlDbType = SqlDbType.DateTime;
                PLocacaoDataDevolucao.Value = Locacao.locacaoDataDevolucao;
                sqlCommand.Parameters.Add(PLocacaoDataDevolucao);
                //Parãmetro VALOR DIÁRIA
                SqlParameter PLocacaoValorDiaria = new SqlParameter();
                PLocacaoValorDiaria.ParameterName = "@locacaoValorDiaria";
                PLocacaoValorDiaria.SqlDbType = SqlDbType.Decimal;
                PLocacaoValorDiaria.Value = Locacao.locacaoValorDiaria;
                sqlCommand.Parameters.Add(PLocacaoValorDiaria);

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
        public string AlterarLocacao(LocacaoDados Locacao)
        {
            string mensagem = "";

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_alterarLocacao";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //Parãmetro CÓDIGO LOCAÇÂO
                SqlParameter PLocacaoCodigo = new SqlParameter();
                PLocacaoCodigo.ParameterName = "@locacaoCodigo";
                PLocacaoCodigo.SqlDbType = SqlDbType.Int;
                PLocacaoCodigo.Value = Locacao.LocacaoCodigo;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(PLocacaoCodigo);
                //Parãmetro CÓDIGO VEÍCULO
                SqlParameter PVeiculoCodigo = new SqlParameter();
                PVeiculoCodigo.ParameterName = "@veiculoCodigo";
                PVeiculoCodigo.SqlDbType = SqlDbType.Int;
                PVeiculoCodigo.Value = Locacao.VeiculoCodigo;
                sqlCommand.Parameters.Add(PVeiculoCodigo);
                //Parãmetro CÓDIGO CLIENTE
                SqlParameter PClienteCodigo = new SqlParameter();
                PClienteCodigo.ParameterName = "@clienteCodigo";
                PClienteCodigo.SqlDbType = SqlDbType.Int;
                PClienteCodigo.Value = Locacao.clienteCodigo;
                sqlCommand.Parameters.Add(PClienteCodigo);
                //Parãmetro DATA
                SqlParameter PLocacaoData = new SqlParameter();
                PLocacaoData.ParameterName = "@locacaoData";
                PLocacaoData.SqlDbType = SqlDbType.DateTime;
                PLocacaoData.Value = Locacao.locacaoData;
                sqlCommand.Parameters.Add(PLocacaoData);
                //Parãmetro DATA DEVOLUÇÃO
                SqlParameter PLocacaoDataDevolucao = new SqlParameter();
                PLocacaoDataDevolucao.ParameterName = "@locacaoDataDevolucao";
                PLocacaoDataDevolucao.SqlDbType = SqlDbType.DateTime;
                PLocacaoDataDevolucao.Value = Locacao.locacaoDataDevolucao;
                sqlCommand.Parameters.Add(PLocacaoDataDevolucao);
                //Parãmetro VALOR DIÁRIA
                SqlParameter PLocacaoValorDiaria = new SqlParameter();
                PLocacaoValorDiaria.ParameterName = "@locacaoValorDiaria";
                PLocacaoValorDiaria.SqlDbType = SqlDbType.Decimal;
                PLocacaoValorDiaria.Value = Locacao.locacaoValorDiaria;
                sqlCommand.Parameters.Add(PLocacaoValorDiaria);

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
        public string ExcluirLocacao(LocacaoDados Locacao)
        {
            string mensagem = "";

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_excluirLocacao";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parãmetro CÓDIGO LOCAÇÃO
                SqlParameter PLocacaoCodigo = new SqlParameter();
                PLocacaoCodigo.ParameterName = "@LocacaoCodigo";
                PLocacaoCodigo.SqlDbType = SqlDbType.Int;
                PLocacaoCodigo.Value = Locacao.LocacaoCodigo;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(PLocacaoCodigo);

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
        public DataTable ConsultarLocacao(LocacaoDados Locacao)
        {
            DataTable dataTableLocacao = new DataTable("locacao");

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_consultarLocacao";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parãmetro CÓDIGO LOCAÇÃO
                SqlParameter PLocacaoCodigo = new SqlParameter();
                PLocacaoCodigo.ParameterName = "@locacaoCodigo";
                PLocacaoCodigo.SqlDbType = SqlDbType.Int;
                PLocacaoCodigo.Value = Locacao.LocacaoCodigo;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(PLocacaoCodigo);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTableLocacao);
            }
            catch (Exception e)
            {
                dataTableLocacao = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            return dataTableLocacao;
        }
        //CONSULTAR VEÍCULO
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
                //Parãmetro CÓDIGO VEÍCULO
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
        //CONSULTAR CLIENTE
        public DataTable ConsultarCliente(ClienteDados Locacao)
        {
            DataTable dataTableCliente = new DataTable("cliente");

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_consultarCliente";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Parãmetro CÓDIGO CLIENTE
                SqlParameter PClienteCodigo = new SqlParameter();
                PClienteCodigo.ParameterName = "@clienteCodigo";
                PClienteCodigo.SqlDbType = SqlDbType.Int;
                PClienteCodigo.Value = Locacao.ClienteCodigo;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add(PClienteCodigo);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTableCliente);
            }
            catch (Exception e)
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
        //RECUPERAR ÚLTIMO REGISTRO CADASTRADO
        public DataTable RecuperarUltimoCadastroLocacao(LocacaoDados Locacao)
        {
            DataTable dataTableLocacao = new DataTable("locacao");

            try
            {
                //Conexão BD
                sqlConnection.ConnectionString = ConexaoDB.conexao;
                sqlConnection.Open();
                //Acesso ao BD via procedure
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "proc_recuperarUltimoCadastroLocacao";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTableLocacao);
            }
            catch (Exception)
            {
                dataTableLocacao = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

            return dataTableLocacao;
        }
    }
}
