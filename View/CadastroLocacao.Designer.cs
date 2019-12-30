namespace View
{
    partial class FrmCadastroLocacao
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
            this.txbValorDiaria = new System.Windows.Forms.TextBox();
            this.txbCodigoVeiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCodigoLocacao = new System.Windows.Forms.TextBox();
            this.txbDescricaoVeiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDataDevolucao = new System.Windows.Forms.TextBox();
            this.dtGridCadastroLocacao = new System.Windows.Forms.DataGridView();
            this.txbDescricaoCliente = new System.Windows.Forms.TextBox();
            this.txbCodigoCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCadastroLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Location = new System.Drawing.Point(528, 104);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 12;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(553, 9);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(50, 23);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(447, 104);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Enabled = false;
            this.btAlterar.Location = new System.Drawing.Point(496, 9);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(50, 23);
            this.btAlterar.TabIndex = 1;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(439, 9);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(50, 23);
            this.btNovo.TabIndex = 0;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Locação de veículo";
            // 
            // txbValorDiaria
            // 
            this.txbValorDiaria.Location = new System.Drawing.Point(225, 107);
            this.txbValorDiaria.Name = "txbValorDiaria";
            this.txbValorDiaria.Size = new System.Drawing.Size(68, 20);
            this.txbValorDiaria.TabIndex = 10;
            // 
            // txbCodigoVeiculo
            // 
            this.txbCodigoVeiculo.Location = new System.Drawing.Point(74, 63);
            this.txbCodigoVeiculo.Name = "txbCodigoVeiculo";
            this.txbCodigoVeiculo.Size = new System.Drawing.Size(47, 20);
            this.txbCodigoVeiculo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Valor diária:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Veículo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código:";
            // 
            // txbCodigoLocacao
            // 
            this.txbCodigoLocacao.Enabled = false;
            this.txbCodigoLocacao.Location = new System.Drawing.Point(21, 63);
            this.txbCodigoLocacao.MaxLength = 4;
            this.txbCodigoLocacao.Name = "txbCodigoLocacao";
            this.txbCodigoLocacao.Size = new System.Drawing.Size(46, 20);
            this.txbCodigoLocacao.TabIndex = 3;
            // 
            // txbDescricaoVeiculo
            // 
            this.txbDescricaoVeiculo.Enabled = false;
            this.txbDescricaoVeiculo.Location = new System.Drawing.Point(121, 63);
            this.txbDescricaoVeiculo.Name = "txbDescricaoVeiculo";
            this.txbDescricaoVeiculo.Size = new System.Drawing.Size(183, 20);
            this.txbDescricaoVeiculo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cliente:";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(21, 107);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(96, 20);
            this.txbData.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Data início:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Data fim:";
            // 
            // txbDataDevolucao
            // 
            this.txbDataDevolucao.Location = new System.Drawing.Point(123, 107);
            this.txbDataDevolucao.Name = "txbDataDevolucao";
            this.txbDataDevolucao.Size = new System.Drawing.Size(96, 20);
            this.txbDataDevolucao.TabIndex = 9;
            // 
            // dtGridCadastroLocacao
            // 
            this.dtGridCadastroLocacao.AllowUserToAddRows = false;
            this.dtGridCadastroLocacao.AllowUserToDeleteRows = false;
            this.dtGridCadastroLocacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridCadastroLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCadastroLocacao.Location = new System.Drawing.Point(12, 157);
            this.dtGridCadastroLocacao.Name = "dtGridCadastroLocacao";
            this.dtGridCadastroLocacao.ReadOnly = true;
            this.dtGridCadastroLocacao.Size = new System.Drawing.Size(604, 297);
            this.dtGridCadastroLocacao.TabIndex = 13;
            // 
            // txbDescricaoCliente
            // 
            this.txbDescricaoCliente.AcceptsReturn = true;
            this.txbDescricaoCliente.Enabled = false;
            this.txbDescricaoCliente.Location = new System.Drawing.Point(357, 63);
            this.txbDescricaoCliente.Name = "txbDescricaoCliente";
            this.txbDescricaoCliente.Size = new System.Drawing.Size(248, 20);
            this.txbDescricaoCliente.TabIndex = 7;
            // 
            // txbCodigoCliente
            // 
            this.txbCodigoCliente.Location = new System.Drawing.Point(310, 63);
            this.txbCodigoCliente.Name = "txbCodigoCliente";
            this.txbCodigoCliente.Size = new System.Drawing.Size(47, 20);
            this.txbCodigoCliente.TabIndex = 6;
            // 
            // FrmCadastroLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 466);
            this.Controls.Add(this.txbDescricaoCliente);
            this.Controls.Add(this.txbCodigoCliente);
            this.Controls.Add(this.dtGridCadastroLocacao);
            this.Controls.Add(this.txbDataDevolucao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbDescricaoVeiculo);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbValorDiaria);
            this.Controls.Add(this.txbCodigoVeiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCodigoLocacao);
            this.Name = "FrmCadastroLocacao";
            this.Text = "Locacao";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCadastroLocacao)).EndInit();
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
        private System.Windows.Forms.TextBox txbValorDiaria;
        private System.Windows.Forms.TextBox txbCodigoVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCodigoLocacao;
        private System.Windows.Forms.TextBox txbDescricaoVeiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDataDevolucao;
        private System.Windows.Forms.DataGridView dtGridCadastroLocacao;
        private System.Windows.Forms.TextBox txbDescricaoCliente;
        private System.Windows.Forms.TextBox txbCodigoCliente;
    }
}