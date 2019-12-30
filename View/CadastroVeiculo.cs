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
    public partial class FrmCadastroVeiculo : Form
    {
        private void FrmCadastroVeiculo_Load(object sender, EventArgs e)
        {

        }
        private enum Status
        {
            enInserindo,
            enEditando,
            enConsultando
        }

        private bool emInsercao = false;
        private bool emEdicao = false;
        private bool emConsulta = false;

        VeiculoController veiculoController = new VeiculoController();
        public FrmCadastroVeiculo()
        {
            InitializeComponent();

            AlterarStatus(Status.enConsultando);
            HabilitarDesabilitarComponentes();

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
            this.dtGridCadastroVeiculo.DataSource = MessageBox.Show(veiculoController.CadastrarVeiculo(this.maskPlaca.Text, this.txbDescricao.Text));

            Limpar();

            RecuperarUltimoCadastroVeiculo();
            Consultar();
            HabilitarDesabilitarComponentes();
            maskPlaca.Focus();
            maskPlaca.SelectAll();
        }
        //CONSULTAR
        private void Consultar()
        {
            if (!this.txbCodigo.Text.Equals(string.Empty) ||
                !dtGridCadastroVeiculo.Rows[0].Cells[0].Value.ToString().Equals(string.Empty))
            {
                if (this.txbCodigo.Text.Equals(string.Empty))
                {
                    this.txbCodigo.Text = dtGridCadastroVeiculo.Rows[0].Cells[0].Value.ToString();
                }
                //Carregar dados no DataGrid
                this.dtGridCadastroVeiculo.DataSource =
                    veiculoController.ConsultarVeiculo(Convert.ToInt32(this.txbCodigo.Text));

                if (dtGridCadastroVeiculo.RowCount > 0)
                {
                    this.txbCodigo.Text = dtGridCadastroVeiculo.Rows[0].Cells[0].Value.ToString();
                    this.maskPlaca.Text = dtGridCadastroVeiculo.Rows[0].Cells[1].Value.ToString();
                    this.txbDescricao.Text = dtGridCadastroVeiculo.Rows[0].Cells[2].Value.ToString();
                }
                else
                {
                    maskPlaca.Text = string.Empty;
                    txbDescricao.Text = string.Empty;
                    dtGridCadastroVeiculo.DataSource = null;
                    MessageBox.Show("Código inválido. Veículo não cadastrado");
                }

                AlterarStatus(Status.enConsultando);
                HabilitarDesabilitarComponentes();
                txbCodigo.Focus();
                txbCodigo.SelectAll();
            }
        }

        private void RecuperarUltimoCadastroVeiculo()
        {
            this.dtGridCadastroVeiculo.DataSource = veiculoController.RecuperarUltimoCadastroVeiculo();

            this.txbCodigo.Text = dtGridCadastroVeiculo.Rows[0].Cells[0].Value.ToString();
            this.maskPlaca.Text = dtGridCadastroVeiculo.Rows[0].Cells[1].Value.ToString();
            this.txbDescricao.Text = dtGridCadastroVeiculo.Rows[0].Cells[2].Value.ToString();

        }
        //ALTERAR
        private void Alterar()
        {
            MessageBox.Show(veiculoController.AlterarVeiculo(
                Convert.ToInt32(this.txbCodigo.Text), this.maskPlaca.Text, this.txbDescricao.Text));

            Consultar();
        }
        //EXCLUIR
        private string Excluir()
        {
            return veiculoController.ExcluirVeiculo(Convert.ToInt32(this.txbCodigo.Text));
        }
        //AO PRESSIONAR BOTÃO ALTERAR
        private void AoPressionarAlterarRegistro(object sender, EventArgs e)
        {
            if (!this.txbCodigo.Text.Equals(string.Empty) & !this.maskPlaca.Text.Equals(string.Empty))
            {
                AlterarStatus(Status.enEditando);
                HabilitarDesabilitarComponentes();
                maskPlaca.Focus();
                maskPlaca.SelectAll();
            }
        }
        //AO PRESSIONAR BOTÃO NOVO
        private void AoPressionarNovoRegistro(object sender, EventArgs e)
        {
            Limpar();
            AlterarStatus(Status.enInserindo);
            HabilitarDesabilitarComponentes();
            maskPlaca.Focus();
            maskPlaca.SelectAll();
        }
        //CONTROLE DE HABILITAR/DESABILITAR TODOS OS COMPONENTES DO FORMULÁRIO
        private void HabilitarDesabilitarComponentes()
        {
            //TextBox
            this.txbCodigo.Enabled = emConsulta;
            this.maskPlaca.Enabled = emInsercao || emEdicao;
            this.txbDescricao.Enabled = emInsercao || emEdicao;
            //Botões
            this.btNovo.Enabled = emConsulta;
            this.btAlterar.Enabled = emConsulta &&
                (!this.txbCodigo.Text.Equals(string.Empty) & !this.maskPlaca.Text.Equals(string.Empty));
            this.btExcluir.Enabled = emConsulta &&
                (!this.txbCodigo.Text.Equals(string.Empty) & !this.maskPlaca.Text.Equals(string.Empty));
            this.btCancelar.Enabled = emInsercao || emEdicao || emConsulta &&
                (!this.txbCodigo.Text.Equals(string.Empty));
            this.btGravar.Enabled = emInsercao || emEdicao;
        }
        //AO PRESSIONAR BOTÃO GRAVAR
        private void Gravar(object sender, EventArgs e)
        {
            maskPlaca.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
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

        private void PermitirSomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void AoPressionarCancelar(object sender, EventArgs e)
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
            this.maskPlaca.Text = string.Empty;
            this.txbDescricao.Text = string.Empty;
            dtGridCadastroVeiculo.DataSource = null;
        }

        private void AoPressionarExcluirRegistro(object sender, EventArgs e)
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

        private void PermitirSomenteLetrasENumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void PosicionarCursor(object sender, EventArgs e)
        {
            if (maskPlaca.Text.Equals("   -"))
                maskPlaca.SelectAll();
        }
    }
}
