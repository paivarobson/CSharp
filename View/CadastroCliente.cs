using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class FrmCadastroCliente : Form
    {
        private bool emInsercao = false;
        private bool emEdicao = false;
        public FrmCadastroCliente()
        {
            InitializeComponent();

            this.toolTipFrmCadastroCliente.SetToolTip(this.txbCodigo, "Código");
            this.toolTipFrmCadastroCliente.SetToolTip(this.txbCPF, "Digite o CPF");
            this.toolTipFrmCadastroCliente.SetToolTip(this.txbNome, "Digite o nome");
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            
        }
        //CADASTRAR
        private void Cadastrar()
        {
            this.dtGridCadastroCliente.DataSource = ClienteController.CadastrarCliente(this.txbCPF.Text, this.txbNome.Text);
        }
        //CONSULTAR
        private void Consultar()
        {
            this.dtGridCadastroCliente.DataSource = ClienteController.ConsultarCliente(Convert.ToInt32(this.txbCodigo.Text));
        }

        private void Gravar(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void consultarAoPressionarEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Consultar();
        }
    }
}
