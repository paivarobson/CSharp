using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace Controller
{
    public class PessoaController
    {
        //CADASTRAR
        public static string CadastrarPessoa(string pessoaCPF, string pessoaNome, bool pessoaTipo)
        {
            PessoaDados pessoaDados = new PessoaDados();
            pessoaDados.PessoaCPF = pessoaCPF;
            pessoaDados.PessoaNome = pessoaNome;
            pessoaDados.PessoaTipo = pessoaTipo;

            return pessoaDados.CadastrarPessoa(pessoaDados);
        }
        //ALTERAR
        public static string AlterarPessoa(int pessoaCodigo, string pessoaCPF, string pessoaNome, bool pessoaTipo)
        {
            PessoaDados pessoaDados = new PessoaDados();
            pessoaDados.PessoaCodigo = pessoaCodigo;
            pessoaDados.PessoaCPF = pessoaCPF;
            pessoaDados.PessoaNome = pessoaNome;
            pessoaDados.PessoaTipo = pessoaTipo;

            return pessoaDados.AlterarPessoa(pessoaDados);
        }

        //EXCLUIR
        public static string ExcluirPessoa(int pessoaCodigo)
        {
            PessoaDados pessoaDados = new PessoaDados();
            pessoaDados.PessoaCodigo = pessoaCodigo;

            return pessoaDados.ExcluirPessoa(pessoaDados);
        }
        //CONSULTAR
        public static DataTable ConsultarPessoa(int pessoaCodigo)
        {
            PessoaDados pessoaDados = new PessoaDados();
            pessoaDados.PessoaCodigo = pessoaCodigo;

            return pessoaDados.ConsultarPessoa(pessoaDados);
        }
    }
}
