namespace View
{
    partial class FrmCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.dtGridCadastroCliente = new System.Windows.Forms.DataGridView();
            this.errorProviderFrmCadastroCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipFrmCadastroCliente = new System.Windows.Forms.ToolTip(this.components);
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCadastroCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFrmCadastroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCodigo
            // 
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Location = new System.Drawing.Point(20, 91);
            this.txbCodigo.MaxLength = 4;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(68, 20);
            this.txbCodigo.TabIndex = 0;
            this.txbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consultarAoPressionarEnter);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(17, 72);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(49, 15);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(91, 73);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(33, 15);
            this.lbCPF.TabIndex = 2;
            this.lbCPF.Text = "CPF:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(206, 73);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(44, 15);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNome.Enabled = false;
            this.txbNome.Location = new System.Drawing.Point(209, 91);
            this.txbNome.MaxLength = 50;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(338, 20);
            this.txbNome.TabIndex = 6;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(21, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(174, 24);
            this.lbTitulo.TabIndex = 8;
            this.lbTitulo.Text = "Cadastro de Cliente";
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(310, 9);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 10;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.AoPressionarNovoRegistro);
            // 
            // btAlterar
            // 
            this.btAlterar.Enabled = false;
            this.btAlterar.Location = new System.Drawing.Point(391, 9);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 11;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.AoPressionarAlterarRegistro);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(391, 130);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.AoPressionarCancelar);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(472, 9);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 13;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.AoPressionarExcluirRegistro);
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Location = new System.Drawing.Point(472, 130);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 14;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.Gravar);
            // 
            // dtGridCadastroCliente
            // 
            this.dtGridCadastroCliente.AllowUserToAddRows = false;
            this.dtGridCadastroCliente.AllowUserToDeleteRows = false;
            this.dtGridCadastroCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridCadastroCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCadastroCliente.Location = new System.Drawing.Point(12, 159);
            this.dtGridCadastroCliente.Name = "dtGridCadastroCliente";
            this.dtGridCadastroCliente.ReadOnly = true;
            this.dtGridCadastroCliente.Size = new System.Drawing.Size(543, 204);
            this.dtGridCadastroCliente.TabIndex = 15;
            // 
            // errorProviderFrmCadastroCliente
            // 
            this.errorProviderFrmCadastroCliente.ContainerControl = this;
            // 
            // maskCPF
            // 
            this.maskCPF.Location = new System.Drawing.Point(95, 91);
            this.maskCPF.Mask = "000\\.000\\.000\\-00";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(108, 20);
            this.maskCPF.TabIndex = 16;
            this.maskCPF.Click += new System.EventHandler(this.posicionarCursor);
            this.maskCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSomenteNumeros);
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 378);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.dtGridCadastroCliente);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.txbCodigo);
            this.Name = "FrmCadastroCliente";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCadastroCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFrmCadastroCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.DataGridView dtGridCadastroCliente;
        private System.Windows.Forms.ErrorProvider errorProviderFrmCadastroCliente;
        private System.Windows.Forms.ToolTip toolTipFrmCadastroCliente;
        private System.Windows.Forms.MaskedTextBox maskCPF;
    }
}