using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void AoClicarAbrirCadastroCliente(object sender, EventArgs e)
        {
            FrmCadastroCliente cadastroCliente = new FrmCadastroCliente();

            cadastroCliente.Show();
        }

        private void AoClicarAbrirCadastroVeiculo(object sender, EventArgs e)
        {
            FrmCadastroVeiculo cadastroVeiculo = new FrmCadastroVeiculo();

            cadastroVeiculo.Show();
        }

        private void AoClicarAbrirCadastrarLocacao(object sender, EventArgs e)
        {
            //FrmCadastroLocacao cadastroLocacao = new FrmCadastroLocacao();

            //cadastroLocacao.Show();
        }

        private void AoClicarAbrirRelatorio(object sender, EventArgs e)
        {
            FrmRelatorio relatorio = new FrmRelatorio();

            relatorio.Show();
        }
    }
}
