namespace View
{
    partial class FrmCadastroVeiculo
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
            this.btGravar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.dtGridCadastroVeiculo = new System.Windows.Forms.DataGridView();
            this.maskPlaca = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCadastroVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(536, 133);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 28;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.Gravar);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(561, 12);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(50, 23);
            this.btExcluir.TabIndex = 27;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.AoPressionarExcluirRegistro);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(447, 133);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 26;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.AoPressionarCancelar);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(504, 12);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(50, 23);
            this.btAlterar.TabIndex = 25;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.AoPressionarAlterarRegistro);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(447, 12);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(50, 23);
            this.btNovo.TabIndex = 24;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.AoPressionarNovoRegistro);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cadastro de Veículo";
            // 
            // txbDescricao
            // 
            this.txbDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbDescricao.Enabled = false;
            this.txbDescricao.Location = new System.Drawing.Point(240, 95);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(371, 20);
            this.txbDescricao.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Placa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código:";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Location = new System.Drawing.Point(35, 95);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(68, 20);
            this.txbCodigo.TabIndex = 15;
            this.txbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsultarAoPressionarEnter);
            // 
            // dtGridCadastroVeiculo
            // 
            this.dtGridCadastroVeiculo.AllowUserToAddRows = false;
            this.dtGridCadastroVeiculo.AllowUserToDeleteRows = false;
            this.dtGridCadastroVeiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridCadastroVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCadastroVeiculo.Location = new System.Drawing.Point(12, 187);
            this.dtGridCadastroVeiculo.Name = "dtGridCadastroVeiculo";
            this.dtGridCadastroVeiculo.ReadOnly = true;
            this.dtGridCadastroVeiculo.Size = new System.Drawing.Size(610, 228);
            this.dtGridCadastroVeiculo.TabIndex = 29;
            // 
            // maskPlaca
            // 
            this.maskPlaca.Location = new System.Drawing.Point(125, 95);
            this.maskPlaca.Mask = ">?>?>?\\-0000";
            this.maskPlaca.Name = "maskPlaca";
            this.maskPlaca.Size = new System.Drawing.Size(108, 20);
            this.maskPlaca.TabIndex = 30;
            this.maskPlaca.Click += new System.EventHandler(this.PosicionarCursor);
            this.maskPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSomenteLetrasENumeros);
            // 
            // FrmCadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 427);
            this.Controls.Add(this.maskPlaca);
            this.Controls.Add(this.dtGridCadastroVeiculo);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCodigo);
            this.Name = "FrmCadastroVeiculo";
            this.Text = "CadastroVeiculo";
            this.Load += new System.EventHandler(this.FrmCadastroVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCadastroVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.DataGridView dtGridCadastroVeiculo;
        private System.Windows.Forms.MaskedTextBox maskPlaca;
    }
}