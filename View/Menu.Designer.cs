namespace View
{
    partial class FrmMenu
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
            this.btCadastrarCliente = new System.Windows.Forms.Button();
            this.btCadastrarVeiculo = new System.Windows.Forms.Button();
            this.tbCadastroLocacao = new System.Windows.Forms.Button();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosLocadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCadastrarCliente
            // 
            this.btCadastrarCliente.Location = new System.Drawing.Point(13, 44);
            this.btCadastrarCliente.Name = "btCadastrarCliente";
            this.btCadastrarCliente.Size = new System.Drawing.Size(233, 72);
            this.btCadastrarCliente.TabIndex = 0;
            this.btCadastrarCliente.Text = "Cadastrar Cliente";
            this.btCadastrarCliente.UseVisualStyleBackColor = true;
            this.btCadastrarCliente.Click += new System.EventHandler(this.AoClicarAbrirCadastroCliente);
            // 
            // btCadastrarVeiculo
            // 
            this.btCadastrarVeiculo.Location = new System.Drawing.Point(252, 44);
            this.btCadastrarVeiculo.Name = "btCadastrarVeiculo";
            this.btCadastrarVeiculo.Size = new System.Drawing.Size(233, 72);
            this.btCadastrarVeiculo.TabIndex = 1;
            this.btCadastrarVeiculo.Text = "Cadastrar Veículo";
            this.btCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btCadastrarVeiculo.Click += new System.EventHandler(this.AoClicarAbrirCadastroVeiculo);
            // 
            // tbCadastroLocacao
            // 
            this.tbCadastroLocacao.Location = new System.Drawing.Point(13, 132);
            this.tbCadastroLocacao.Name = "tbCadastroLocacao";
            this.tbCadastroLocacao.Size = new System.Drawing.Size(233, 72);
            this.tbCadastroLocacao.TabIndex = 2;
            this.tbCadastroLocacao.Text = "Cadastrar Locação";
            this.tbCadastroLocacao.UseVisualStyleBackColor = true;
            this.tbCadastroLocacao.Click += new System.EventHandler(this.AoClicarAbrirCadastrarLocacao);
            // 
            // btRelatorio
            // 
            this.btRelatorio.Location = new System.Drawing.Point(252, 132);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(233, 72);
            this.btRelatorio.TabIndex = 3;
            this.btRelatorio.Text = "Relatório";
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.AoClicarAbrirRelatorio);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.veículoToolStripMenuItem,
            this.locaçãoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veículoToolStripMenuItem.Text = "Veículo";
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veículosLocadosToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // veículosLocadosToolStripMenuItem
            // 
            this.veículosLocadosToolStripMenuItem.Name = "veículosLocadosToolStripMenuItem";
            this.veículosLocadosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.veículosLocadosToolStripMenuItem.Text = "Veículos locados";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 219);
            this.Controls.Add(this.btRelatorio);
            this.Controls.Add(this.tbCadastroLocacao);
            this.Controls.Add(this.btCadastrarVeiculo);
            this.Controls.Add(this.btCadastrarCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarCliente;
        private System.Windows.Forms.Button btCadastrarVeiculo;
        private System.Windows.Forms.Button tbCadastroLocacao;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosLocadosToolStripMenuItem;
    }
}