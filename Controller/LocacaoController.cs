using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Controller
{
    public class LocacaoController
    {
        LocacaoDados locacaoDados = new LocacaoDados();
        VeiculoDados veiculoDados = new VeiculoDados();
        ClienteDados clienteDados = new ClienteDados();

        //CADASTRAR
        public string CadastrarLocacao(
            int veiculoCodigo,
            int clienteCodigo,
            DateTime locacaoData,
            DateTime locacaoDataDevolucao,
            decimal locacaoValorDiaria)
        {
            locacaoDados.VeiculoCodigo = veiculoCodigo;
            locacaoDados.ClienteCodigo = clienteCodigo;
            locacaoDados.LocacaoData = locacaoData;
            locacaoDados.LocacaoDataDevolucao = locacaoDataDevolucao;
            locacaoDados.LocacaoValorDiaria = locacaoValorDiaria;

            return locacaoDados.CadastrarLocacao(locacaoDados) + 
                " e " + veiculoDados.LocarVeiculo(veiculoDados);
        }
        //ALTERAR
        public string AlterarLocacao(
            int veiculoCodigo,
            int clienteCodigo,
            DateTime locacaoData,
            DateTime locacaoDataDevolucao,
            decimal locacaoValorDiaria)
        {
            locacaoDados.VeiculoCodigo = veiculoCodigo;
            locacaoDados.ClienteCodigo = clienteCodigo;
            locacaoDados.LocacaoData = locacaoData;
            locacaoDados.LocacaoDataDevolucao = locacaoDataDevolucao;
            locacaoDados.LocacaoValorDiaria = locacaoValorDiaria;

            return locacaoDados.AlterarLocacao(locacaoDados);
        }

        //EXCLUIR
        public string ExcluirLocacao(int locacaoCodigo)
        {
            locacaoDados.LocacaoCodigo = locacaoCodigo;

            return locacaoDados.ExcluirLocacao(locacaoDados);
        }
        //CONSULTAR LOCAÇÃO
        public DataTable ConsultarLocacao(int locacaoCodigo)
        {
            locacaoDados.LocacaoCodigo = locacaoCodigo;

            return locacaoDados.ConsultarLocacao(locacaoDados);
        }
        //CONSULTAR VEÍCULO
        public DataTable ConsultarVeiculo(int veiculoCodigo)
        {
            veiculoDados.VeiculoCodigo = veiculoCodigo;

            return veiculoDados.ConsultarVeiculo(veiculoDados);
        }
        //CONSULTAR CLIENTE
        public DataTable ConsultarCliente(int clienteCodigo)
        {
            clienteDados.ClienteCodigo = clienteCodigo;

            return clienteDados.ConsultarCliente(clienteDados);
        }

        //RECUPERAR ÚLTIMO REGISTRO CADASTRADO
        public DataTable RecuperarUltimoCadastroLocacao()
        {
            LocacaoDados locacaoDados = new LocacaoDados();

            return locacaoDados.RecuperarUltimoCadastroLocacao(locacaoDados);
        }

        public string LiberarVeiculoParaLocacao(int veiculoCodigo)
        {
            veiculoDados.VeiculoCodigo = veiculoCodigo;

            return veiculoDados.LiberarVeiculoParaLocacao(veiculoDados);
        }
    }
}
