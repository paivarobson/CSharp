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
    public partial class FrmCadastroLocacao : Form
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

        private int locacaoCodigo;
        private int locacaoVeiculoCodigo;
        private int locacaoClienteCodigo;
        private DateTime locacaoData;
        private DateTime locacaoDataDevolucao;
        private decimal locacaoValorDiaria;

        public int LocacaoCodigo { get => locacaoCodigo; set => locacaoCodigo = value; }
        public int LocacaoVeiculoCodigo { get => locacaoVeiculoCodigo; set => locacaoVeiculoCodigo = value; }
        public int LocacaoClienteCodigo { get => locacaoClienteCodigo; set => locacaoClienteCodigo = value; }
        public DateTime LocacaoData { get => locacaoData; set => locacaoData = value; }
        public DateTime LocacaoDataDevolucao { get => locacaoDataDevolucao; set => locacaoDataDevolucao = value; }
        public decimal LocacaoValorDiaria { get => locacaoValorDiaria; set => locacaoValorDiaria = value; }

        LocacaoController locacaoController = new LocacaoController();
        public FrmCadastroLocacao()
        {
            InitializeComponent();

            AlterarStatus(Status.enConsultando);
            HabilitarDesabilitarComponentes();

            txbLocacaoCodigo.Focus();
            txbLocacaoCodigo.SelectAll();
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

        private void FormatarValoresDosCampos()
        {
            LocacaoVeiculoCodigo = Convert.ToInt32(this.txbLocacaoVeiculoCodigo.Text);
            LocacaoClienteCodigo = Convert.ToInt32(this.txbLocacaoClienteCodigo.Text); 
            LocacaoData = Convert.ToDateTime(this.maskLocacaoData.Text);
            LocacaoDataDevolucao = Convert.ToDateTime(this.maskLocacaoDataDevolucao.Text);
            LocacaoValorDiaria = Convert.ToDecimal(this.txbLocacaoValorDiaria.Text);
        }

        //CADASTRAR
        private void Cadastrar()
        {
            FormatarValoresDosCampos();

            this.dtGridCadastroLocacao.DataSource = 
                MessageBox.Show(locacaoController.CadastrarLocacao(
                    LocacaoVeiculoCodigo, 
                    LocacaoClienteCodigo, 
                    LocacaoData, 
                    LocacaoDataDevolucao,
                    locacaoValorDiaria));

            Limpar();

            RecuperarUltimoCadastroLocacao();
            Consultar();
            HabilitarDesabilitarComponentes();
            txbLocacaoVeiculoCodigo.Focus();
            txbLocacaoVeiculoCodigo.SelectAll();
        }
        //CONSULTAR LOCAÇÃO
        private void Consultar()
        {
            if (!this.txbLocacaoCodigo.Text.Equals(string.Empty) ||
                !dtGridCadastroLocacao.Rows[0].Cells[0].Value.ToString().Equals(string.Empty))
            {
                if (this.txbLocacaoCodigo.Text.Equals(string.Empty))
                {
                    this.txbLocacaoCodigo.Text = dtGridCadastroLocacao.Rows[0].Cells[0].Value.ToString();
                }
                //Carregar dados no DataGrid
                this.dtGridCadastroLocacao.DataSource =
                    locacaoController.ConsultarLocacao(Convert.ToInt32(this.txbLocacaoCodigo.Text));

                if (dtGridCadastroLocacao.RowCount > 0)
                {
                    this.txbLocacaoCodigo.Text = dtGridCadastroLocacao.Rows[0].Cells[0].Value.ToString();
                    this.txbLocacaoVeiculoCodigo.Text = dtGridCadastroLocacao.Rows[0].Cells[1].Value.ToString();
                    this.txbLocacaoVeiculoDescricao.Text = dtGridCadastroLocacao.Rows[0].Cells[2].Value.ToString();
                    this.txbLocacaoClienteCodigo.Text = dtGridCadastroLocacao.Rows[0].Cells[3].Value.ToString();
                    this.txbLocacaoClienteNome.Text = dtGridCadastroLocacao.Rows[0].Cells[4].Value.ToString();
                    this.maskLocacaoData.Text = dtGridCadastroLocacao.Rows[0].Cells[5].Value.ToString();
                    this.maskLocacaoDataDevolucao.Text = dtGridCadastroLocacao.Rows[0].Cells[6].Value.ToString();
                    this.txbLocacaoValorDiaria.Text = dtGridCadastroLocacao.Rows[0].Cells[7].Value.ToString();
                }
                else
                {
                    txbLocacaoVeiculoCodigo.Text = string.Empty;
                    txbLocacaoVeiculoDescricao.Text = string.Empty;
                    txbLocacaoClienteCodigo.Text = string.Empty;
                    txbLocacaoClienteNome.Text = string.Empty;
                    maskLocacaoData.Text = string.Empty;
                    maskLocacaoDataDevolucao.Text = string.Empty;
                    txbLocacaoValorDiaria.Text = string.Empty;

                    dtGridCadastroLocacao.DataSource = null;
                    MessageBox.Show("Código inválido. Locação não cadastrado");
                }

                AlterarStatus(Status.enConsultando);
                HabilitarDesabilitarComponentes();
                txbLocacaoCodigo.Focus();
                txbLocacaoCodigo.SelectAll();
            }
        }
        //CONSULTAR VEÍCULO
        private void ConsultarVeiculo()
        {
            if (!this.txbLocacaoVeiculoCodigo.Text.Equals(string.Empty))
            {
                if (locacaoController.ConsultarVeiculo(
                        Convert.ToInt32(this.txbLocacaoVeiculoCodigo.Text)).Rows.Count > 0 )
                {
                    this.txbLocacaoVeiculoDescricao.Text =
                        locacaoController.ConsultarVeiculo(
                            Convert.ToInt32(this.txbLocacaoVeiculoCodigo.Text)).Rows[0]["VEIDES"].ToString();
                }
                else
                {
                    MessageBox.Show("Código inválido. Veículo não cadastrado");
                    txbLocacaoVeiculoCodigo.Focus();
                    txbLocacaoVeiculoCodigo.SelectAll();
                }
            }
        }
        //CONSULTAR CLIENTE
        private void ConsultarCliente()
        {
            if (!this.txbLocacaoClienteCodigo.Text.Equals(string.Empty))
            {
                if (locacaoController.ConsultarCliente(
                        Convert.ToInt32(this.txbLocacaoClienteCodigo.Text)).Rows.Count > 0)
                {
                    this.txbLocacaoClienteNome.Text =
                        locacaoController.ConsultarCliente(
                            Convert.ToInt32(this.txbLocacaoClienteCodigo.Text)).Rows[0]["CLINOM"].ToString();
                }
                else
                {
                    MessageBox.Show("Código inválido. Cliente não cadastrado");
                    txbLocacaoClienteCodigo.Focus();
                    txbLocacaoClienteCodigo.SelectAll();
                }
            }
        }
        private void RecuperarUltimoCadastroLocacao()
        {
            this.dtGridCadastroLocacao.DataSource = locacaoController.RecuperarUltimoCadastroLocacao();

            this.txbLocacaoCodigo.Text = dtGridCadastroLocacao.Rows[0].Cells[0].Value.ToString();
            this.txbLocacaoVeiculoCodigo.Text = dtGridCadastroLocacao.Rows[0].Cells[1].Value.ToString();
            this.txbLocacaoVeiculoDescricao.Text = dtGridCadastroLocacao.Rows[0].Cells[2].Value.ToString();

        }
        //ALTERAR
        private void Alterar()
        {
            FormatarValoresDosCampos();

            MessageBox.Show(locacaoController.AlterarLocacao(
                LocacaoVeiculoCodigo, 
                LocacaoClienteCodigo, 
                LocacaoData, 
                LocacaoDataDevolucao, 
                LocacaoValorDiaria));

            Consultar();
        }
        //EXCLUIR
        private string Excluir()
        {
            return locacaoController.ExcluirLocacao(Convert.ToInt32(this.txbLocacaoCodigo.Text));
        }
        //AO CLICAR BOTÃO ALTERAR
        private void AoClicarAlterarRegistro(object sender, EventArgs e)
        {
            if (!this.txbLocacaoCodigo.Text.Equals(string.Empty) & !this.txbLocacaoVeiculoCodigo.Text.Equals(string.Empty))
            {
                AlterarStatus(Status.enEditando);
                HabilitarDesabilitarComponentes();
                txbLocacaoVeiculoCodigo.Focus();
                txbLocacaoVeiculoCodigo.SelectAll();
            }
        }
        //AO CLICAR BOTÃO NOVO
        private void AoClicarNovoRegistro(object sender, EventArgs e)
        {
            Limpar();
            AlterarStatus(Status.enInserindo);
            HabilitarDesabilitarComponentes();
            txbLocacaoVeiculoCodigo.Focus();
            txbLocacaoVeiculoCodigo.SelectAll();
        }
        //CONTROLE DE HABILITAR/DESABILITAR TODOS OS COMPONENTES DO FORMULÁRIO
        private void HabilitarDesabilitarComponentes()
        {
            //TextBox
            this.txbLocacaoCodigo.Enabled = emConsulta;
            this.txbLocacaoVeiculoCodigo.Enabled = emInsercao || emEdicao;
            this.txbLocacaoClienteCodigo.Enabled = emInsercao || emEdicao;
            this.maskLocacaoData.Enabled = emInsercao || emEdicao;
            this.maskLocacaoDataDevolucao.Enabled = emInsercao || emEdicao;
            this.txbLocacaoValorDiaria.Enabled = emInsercao || emEdicao;
            //Botões
            this.btNovo.Enabled = emConsulta;
            this.btAlterar.Enabled = emConsulta &&
                (!this.txbLocacaoCodigo.Text.Equals(string.Empty) & !this.txbLocacaoVeiculoCodigo.Text.Equals(string.Empty));
            this.btExcluir.Enabled = emConsulta &&
                (!this.txbLocacaoCodigo.Text.Equals(string.Empty) & !this.txbLocacaoVeiculoCodigo.Text.Equals(string.Empty));
            this.btCancelar.Enabled = emInsercao || emEdicao || emConsulta &&
                (!this.txbLocacaoCodigo.Text.Equals(string.Empty)); ;
            this.btGravar.Enabled = emInsercao || emEdicao;
        }
        //AO CLICAR BOTÃO GRAVAR
        private void AoClicarGravar(object sender, EventArgs e)
        {
            if (emInsercao)
                Cadastrar();
            else if (emEdicao)
                Alterar();
            else
                Excluir();
        }

        private void ConsultarLocacaoAoPressionarEnter(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(sender, e);

            if (e.KeyChar == 13)
            {
                ProximoControle(sender, e);
                Consultar();
            }
        }

        private void ProximoControle(object sender, KeyPressEventArgs e)
        {
            this.SelectNextControl((Control)sender, true, true, true, true);
        }

        private void ConsultarVeiculoAoPressionarEnter(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(sender, e);

            if (e.KeyChar == 13)
            {
                ProximoControle(sender, e);
                ConsultarVeiculo();
            }
        }

        private void ConsultarClienteAoPressionarEnter(object sender, KeyPressEventArgs e)
        {
            PermitirSomenteNumeros(sender, e);

            if (e.KeyChar == 13)
            {
                ProximoControle(sender, e);
                ConsultarCliente();
            }
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
                txbLocacaoCodigo.Focus();
                txbLocacaoCodigo.SelectAll();
            }

        }

        private void Limpar()
        {
            this.txbLocacaoCodigo.Text = string.Empty;
            this.txbLocacaoVeiculoCodigo.Text = string.Empty;
            this.txbLocacaoVeiculoDescricao.Text = string.Empty;
            this.txbLocacaoClienteCodigo.Text = string.Empty;
            this.txbLocacaoClienteNome.Text = string.Empty;
            this.maskLocacaoData.Text = string.Empty;
            this.maskLocacaoDataDevolucao.Text = string.Empty;            
            this.txbLocacaoValorDiaria.Text = string.Empty;            
            dtGridCadastroLocacao.DataSource = null;
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
                txbLocacaoCodigo.Focus();
                txbLocacaoCodigo.SelectAll();
            }

        }
        private void PermitirSomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void LimparDescricaoVeiculo(object sender, EventArgs e)
        {
            txbLocacaoVeiculoDescricao.Clear();
        }

        private void LimparNomeCliente(object sender, EventArgs e)
        {
            txbLocacaoClienteNome.Clear();
        }
    }
}
