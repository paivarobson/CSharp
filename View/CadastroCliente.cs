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
        private enum Status
        {
            enInserindo,
            enEditando,
            enConsultando
        }

        private bool emInsercao = false;
        private bool emEdicao = false;
        private bool emConsulta = false;

        ClienteController clienteController = new ClienteController();
        public FrmCadastroCliente()
        {
            InitializeComponent();

            AlterarStatus(Status.enConsultando);
            HabilitarDesabilitarComponentes();

            this.toolTipFrmCadastroCliente.SetToolTip(this.txbCodigo, "Código");
            this.toolTipFrmCadastroCliente.SetToolTip(this.maskCPF, "Digite o CPF");
            this.toolTipFrmCadastroCliente.SetToolTip(this.txbNome, "Digite o nome");

        }

        private void AlterarStatus(Status status)
        {
            emInsercao = false;
            emEdicao = false;
            emConsulta = false;
            switch (status)
            {
                case Status.enInserindo:
                    emInsercao = true;
                    break;
                case Status.enEditando:
                    emEdicao = true;
                    break;
                default:
                    emConsulta = true;
                    break;
            }
        }

        //CADASTRAR
        private void Cadastrar()
        {
            this.dtGridCadastroCliente.DataSource = MessageBox.Show(clienteController.CadastrarCliente(this.maskCPF.Text, this.txbNome.Text));

            Limpar();

            RecuperarUltimoCadastroCliente();
            Consultar();
            HabilitarDesabilitarComponentes();
            maskCPF.Focus();
            maskCPF.SelectAll();
        }
        //CONSULTAR
        private void Consultar()
        {
            if (!this.txbCodigo.Text.Equals(string.Empty) || 
                !dtGridCadastroCliente.Rows[0].Cells[0].Value.ToString().Equals(string.Empty))
            {
                if (this.txbCodigo.Text.Equals(string.Empty))
                {
                    this.txbCodigo.Text = dtGridCadastroCliente.Rows[0].Cells[0].Value.ToString();
                }
                //Carregar dados no DataGrid
                this.dtGridCadastroCliente.DataSource = 
                    clienteController.ConsultarCliente(Convert.ToInt32(this.txbCodigo.Text));

                if (dtGridCadastroCliente.RowCount > 0)
                {
                    this.txbCodigo.Text = dtGridCadastroCliente.Rows[0].Cells[0].Value.ToString();
                    this.maskCPF.Text = dtGridCadastroCliente.Rows[0].Cells[1].Value.ToString();
                    this.txbNome.Text = dtGridCadastroCliente.Rows[0].Cells[2].Value.ToString();
                }
                else
                {
                    maskCPF.Text = string.Empty;
                    txbNome.Text = string.Empty;
                    dtGridCadastroCliente.DataSource = null;
                    MessageBox.Show("Código inválido. Cliente não cadastrado");
                }

                AlterarStatus(Status.enConsultando);
                HabilitarDesabilitarComponentes();
                txbCodigo.Focus();
                txbCodigo.SelectAll();
            }
        }

        private void RecuperarUltimoCadastroCliente()
        {
            this.dtGridCadastroCliente.DataSource = clienteController.RecuperarUltimoCadastroCliente();

            this.txbCodigo.Text = dtGridCadastroCliente.Rows[0].Cells[0].Value.ToString();
            this.maskCPF.Text = dtGridCadastroCliente.Rows[0].Cells[1].Value.ToString();
            this.txbNome.Text = dtGridCadastroCliente.Rows[0].Cells[2].Value.ToString();

        }
        //ALTERAR
        private void Alterar()
        {
            MessageBox.Show(clienteController.AlterarCliente(
                Convert.ToInt32(this.txbCodigo.Text), this.maskCPF.Text, this.txbNome.Text));

            Consultar();
        }
        //EXCLUIR
        private string Excluir()
        {
            return clienteController.ExcluirCliente(Convert.ToInt32(this.txbCodigo.Text));
        }
        //AO CLICAR BOTÃO ALTERAR
        private void AoClicarAlterarRegistro(object sender, EventArgs e)
        {
            if (!this.txbCodigo.Text.Equals(string.Empty) & !this.maskCPF.Text.Equals(string.Empty))
            {
                AlterarStatus(Status.enEditando);
                HabilitarDesabilitarComponentes();
                maskCPF.Focus();
                maskCPF.SelectAll();
            }
        }
        //AO CLICAR BOTÃO NOVO
        private void AoClicarNovoRegistro(object sender, EventArgs e)
        {
            Limpar();
            AlterarStatus(Status.enInserindo);
            HabilitarDesabilitarComponentes();
            maskCPF.Focus();
            maskCPF.SelectAll();
        }
        //CONTROLE DE HABILITAR/DESABILITAR TODOS OS COMPONENTES DO FORMULÁRIO
        private void HabilitarDesabilitarComponentes()
        {
            //TextBox
            this.txbCodigo.Enabled = emConsulta;
            this.maskCPF.Enabled = emInsercao || emEdicao;
            this.txbNome.Enabled = emInsercao || emEdicao;
            //Botões
            this.btNovo.Enabled = emConsulta;
            this.btAlterar.Enabled = emConsulta &&
                (!this.txbCodigo.Text.Equals(string.Empty) & !this.maskCPF.Text.Equals(string.Empty));
            this.btExcluir.Enabled = emConsulta && 
                (!this.txbCodigo.Text.Equals(string.Empty) & !this.maskCPF.Text.Equals(string.Empty));
            this.btCancelar.Enabled = emInsercao || emEdicao || emConsulta &&
                (!this.txbCodigo.Text.Equals(string.Empty)); ;
            this.btGravar.Enabled = emInsercao || emEdicao;
        }
        //AO CLICAR BOTÃO GRAVAR
        private void Gravar(object sender, EventArgs e)
        {
            maskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (emInsercao)
                Cadastrar();
            else if (emEdicao)
                Alterar();
            else
                Excluir();
        }

        private void ConsultarAoPressionarEnter(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(sender, e);

            if (e.KeyChar == 13)
                Consultar(); 
        }

        private void AoClicarCancelar(object sender, EventArgs e)
        {
            DialogResult confirmacao =
                MessageBox.Show("Tem certeza que deseja cancelar?", "Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirmacao.ToString().ToUpper() == "YES")
            {
                Limpar();
                AlterarStatus(Status.enConsultando);
                HabilitarDesabilitarComponentes();
                txbCodigo.Focus();
                txbCodigo.SelectAll();
            }

        }

        private void Limpar()
        {
            this.txbCodigo.Text = string.Empty;
            this.maskCPF.Text = string.Empty;
            this.txbNome.Text = string.Empty;
            dtGridCadastroCliente.DataSource = null;
        }

        private void AoClicarExcluirRegistro(object sender, EventArgs e)
        {
            DialogResult confirmacao =
                MessageBox.Show("Tem certeza que quer excluir o registro?", "Excluir registro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirmacao.ToString().ToUpper() == "YES")
            {
                Excluir();
                Limpar();
                HabilitarDesabilitarComponentes();
                txbCodigo.Focus();
                txbCodigo.SelectAll();
            }
            
        }

        private void PermitirSomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void PosicionarCursor(object sender, EventArgs e)
        {
            if (maskCPF.Text.Equals("   .   .   -"))
                maskCPF.SelectAll();
        }
    }
}
