using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Controller
{
    public class ClienteController
    {
        //CADASTRAR
        public string CadastrarCliente(string clienteCPF, string clienteNome)
        {
            ClienteDados clienteDados = new ClienteDados();
            clienteDados.ClienteCPF = clienteCPF;
            clienteDados.ClienteNome = clienteNome;

            return clienteDados.CadastrarCliente(clienteDados);
        }
        //ALTERAR
        public string AlterarCliente(int clienteCodigo, string clienteCPF, string clienteNome)
        {
            ClienteDados clienteDados = new ClienteDados();
            clienteDados.ClienteCodigo = clienteCodigo;
            clienteDados.ClienteCPF = clienteCPF;
            clienteDados.ClienteNome = clienteNome;

            return clienteDados.AlterarCliente(clienteDados);
        }

        //EXCLUIR
        public string ExcluirCliente(int clienteCodigo)
        {
            ClienteDados clienteDados = new ClienteDados();
            clienteDados.ClienteCodigo = clienteCodigo;

            return clienteDados.ExcluirCliente(clienteDados);
        }
        //CONSULTAR
        public DataTable ConsultarCliente(int clienteCodigo)
        {
            ClienteDados clienteDados = new ClienteDados();
            clienteDados.ClienteCodigo = clienteCodigo;

            return clienteDados.ConsultarCliente(clienteDados);
        }
    }
}
