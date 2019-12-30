using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Controller
{
    public class VeiculoController
    {
        VeiculoDados veiculoDados = new VeiculoDados();

        //CADASTRAR
        public string CadastrarVeiculo(string veiculoPlaca, string veiculoDescricao)
        {
            veiculoDados.VeiculoPlaca = veiculoPlaca;
            veiculoDados.VeiculoDescricao = veiculoDescricao;

            return veiculoDados.CadastrarVeiculo(veiculoDados);
        }
        //ALTERAR
        public string AlterarVeiculo(int veiculoCodigo, string veiculoPlaca, string veiculoDescricao)
        {
            veiculoDados.VeiculoCodigo = veiculoCodigo;
            veiculoDados.VeiculoPlaca = veiculoPlaca;
            veiculoDados.VeiculoDescricao = veiculoDescricao;

            return veiculoDados.AlterarVeiculo(veiculoDados);
        }

        //EXCLUIR
        public string ExcluirVeiculo(int veiculoCodigo)
        {
            veiculoDados.VeiculoCodigo = veiculoCodigo;

            return veiculoDados.ExcluirVeiculo(veiculoDados);
        }
        //CONSULTAR
        public DataTable ConsultarVeiculo(int veiculoCodigo)
        {
            veiculoDados.VeiculoCodigo = veiculoCodigo;

            return veiculoDados.ConsultarVeiculo(veiculoDados);
        }
        //RECUPERAR ÚLTIMO REGISTRO CADASTRADO
        public DataTable RecuperarUltimoCadastroVeiculo()
        {
            VeiculoDados veiculoDados = new VeiculoDados();

            return veiculoDados.RecuperarUltimoCadastroVeiculo(veiculoDados);
        }
    }
}
