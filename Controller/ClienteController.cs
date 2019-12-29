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
        public static string CadastrarCliente(string clienteCPF, string clienteNome, bool clienteTipo)
        {
            ClienteDados clienteDados = new ClienteDados();
            clienteDados.ClienteCPF = clienteCPF;
            clienteDados.ClienteNome = clienteNome;
            clienteDados.ClienteTipo = clienteTipo;

            return clienteDados.CadastrarCliente(clienteDados);
        }
        //ALTERAR
        public static string AlterarCliente(int clienteCodigo, string clienteCPF, string clienteNome, bool clienteTipo)
        {
            ClienteDados clienteDados = new ClienteDados();
            clienteDados.ClienteCodigo = clienteCodigo;
            clienteDados.ClienteCPF = clienteCPF;
            clienteDados.ClienteNome = clienteNome;
            clienteDados.ClienteTipo = clienteTipo;

            return clienteDados.AlterarCliente(clienteDados);
        }

        //EXCLUIR
        public static string ExcluirCliente(int clienteCodigo)
        {
            ClienteDados clienteDados = new ClienteDados();
            clienteDados.ClienteCodigo = clienteCodigo;

            return clienteDados.ExcluirCliente(clienteDados);
        }
        //CONSULTAR
        public static DataTable ConsultarCliente(int clienteCodigo)
        {
            ClienteDados clienteDados = new ClienteDados();
            clienteDados.ClienteCodigo = clienteCodigo;

            return clienteDados.ConsultarCliente(clienteDados);
        }
    }
}
