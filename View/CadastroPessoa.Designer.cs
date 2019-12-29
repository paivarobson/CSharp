namespace View
{
    partial class frmCadastroPessoa
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
            this.lbTipo = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.dtGridCadastroPessoa = new System.Windows.Forms.DataGridView();
            this.errorProviderFrmCadastroPessoa = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipFrmCadastroPessoa = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCadastroPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFrmCadastroPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(20, 91);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(68, 20);
            this.txbCodigo.TabIndex = 0;
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
            this.lbNome.Location = new System.Drawing.Point(17, 114);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(44, 15);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(206, 72);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(34, 15);
            this.lbTipo.TabIndex = 4;
            this.lbTipo.Text = "Tipo:";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(94, 91);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(109, 20);
            this.txbCPF.TabIndex = 5;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(20, 132);
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
            this.lbTitulo.Size = new System.Drawing.Size(178, 24);
            this.lbTitulo.TabIndex = 8;
            this.lbTitulo.Text = "Cadastro de Pessoa";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(209, 90);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(149, 21);
            this.cbTipo.TabIndex = 9;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(232, 10);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(50, 23);
            this.btNovo.TabIndex = 10;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(289, 10);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(50, 23);
            this.btAlterar.TabIndex = 11;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(375, 130);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(346, 10);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(50, 23);
            this.btExcluir.TabIndex = 13;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(456, 130);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(75, 23);
            this.btGravar.TabIndex = 14;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            // 
            // dtGridCadastroPessoa
            // 
            this.dtGridCadastroPessoa.AllowUserToAddRows = false;
            this.dtGridCadastroPessoa.AllowUserToDeleteRows = false;
            this.dtGridCadastroPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCadastroPessoa.Location = new System.Drawing.Point(12, 185);
            this.dtGridCadastroPessoa.Name = "dtGridCadastroPessoa";
            this.dtGridCadastroPessoa.ReadOnly = true;
            this.dtGridCadastroPessoa.Size = new System.Drawing.Size(519, 178);
            this.dtGridCadastroPessoa.TabIndex = 15;
            // 
            // errorProviderFrmCadastroPessoa
            // 
            this.errorProviderFrmCadastroPessoa.ContainerControl = this;
            // 
            // frmCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 378);
            this.Controls.Add(this.dtGridCadastroPessoa);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.txbCodigo);
            this.Name = "frmCadastroPessoa";
            this.Text = "Cadastro Pessoa";
            this.Load += new System.EventHandler(this.frmCadastroPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCadastroPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFrmCadastroPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.DataGridView dtGridCadastroPessoa;
        private System.Windows.Forms.ErrorProvider errorProviderFrmCadastroPessoa;
        private System.Windows.Forms.ToolTip toolTipFrmCadastroPessoa;
    }
}