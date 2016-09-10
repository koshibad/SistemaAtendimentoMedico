namespace SistemaAtendimentoMedico.View
{
    partial class FrmMaterial
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
            this.tsMenus = new System.Windows.Forms.ToolStrip();
            this.tbNovo = new System.Windows.Forms.ToolStripButton();
            this.tbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tbInserir = new System.Windows.Forms.ToolStripButton();
            this.tbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tbCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnBusca = new System.Windows.Forms.Panel();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbFinalidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tsMenus.SuspendLayout();
            this.pnBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenus
            // 
            this.tsMenus.BackColor = System.Drawing.Color.Transparent;
            this.tsMenus.Font = new System.Drawing.Font("Candara", 10F);
            this.tsMenus.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsMenus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNovo,
            this.tbAlterar,
            this.tbExcluir,
            this.tbInserir,
            this.tbSalvar,
            this.tbCancelar});
            this.tsMenus.Location = new System.Drawing.Point(0, 0);
            this.tsMenus.Name = "tsMenus";
            this.tsMenus.Padding = new System.Windows.Forms.Padding(0);
            this.tsMenus.Size = new System.Drawing.Size(999, 45);
            this.tsMenus.TabIndex = 0;
            // 
            // tbNovo
            // 
            this.tbNovo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNovo.Margin = new System.Windows.Forms.Padding(5);
            this.tbNovo.Name = "tbNovo";
            this.tbNovo.Padding = new System.Windows.Forms.Padding(5);
            this.tbNovo.Size = new System.Drawing.Size(63, 35);
            this.tbNovo.Text = "Novo";
            this.tbNovo.Click += new System.EventHandler(this.tbNovo_Click);
            // 
            // tbAlterar
            // 
            this.tbAlterar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlterar.Margin = new System.Windows.Forms.Padding(5);
            this.tbAlterar.Name = "tbAlterar";
            this.tbAlterar.Padding = new System.Windows.Forms.Padding(5);
            this.tbAlterar.Size = new System.Drawing.Size(73, 35);
            this.tbAlterar.Text = "Alterar";
            this.tbAlterar.Click += new System.EventHandler(this.tbAlterar_Click);
            // 
            // tbExcluir
            // 
            this.tbExcluir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.tbExcluir.Name = "tbExcluir";
            this.tbExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.tbExcluir.Size = new System.Drawing.Size(73, 35);
            this.tbExcluir.Text = "Excluir";
            this.tbExcluir.Click += new System.EventHandler(this.tbExcluir_Click);
            // 
            // tbInserir
            // 
            this.tbInserir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbInserir.Margin = new System.Windows.Forms.Padding(5);
            this.tbInserir.Name = "tbInserir";
            this.tbInserir.Padding = new System.Windows.Forms.Padding(5);
            this.tbInserir.Size = new System.Drawing.Size(70, 35);
            this.tbInserir.Text = "Inserir";
            this.tbInserir.Visible = false;
            this.tbInserir.Click += new System.EventHandler(this.tbInserir_Click);
            // 
            // tbSalvar
            // 
            this.tbSalvar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.tbSalvar.Name = "tbSalvar";
            this.tbSalvar.Padding = new System.Windows.Forms.Padding(5);
            this.tbSalvar.Size = new System.Drawing.Size(67, 35);
            this.tbSalvar.Text = "Salvar";
            this.tbSalvar.Visible = false;
            this.tbSalvar.Click += new System.EventHandler(this.tbSalvar_Click);
            // 
            // tbCancelar
            // 
            this.tbCancelar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.tbCancelar.Name = "tbCancelar";
            this.tbCancelar.Padding = new System.Windows.Forms.Padding(5);
            this.tbCancelar.Size = new System.Drawing.Size(85, 35);
            this.tbCancelar.Text = "Cancelar";
            this.tbCancelar.Visible = false;
            this.tbCancelar.Click += new System.EventHandler(this.tbCancelar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(385, 66);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 255;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(339, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nome:";
            // 
            // pnBusca
            // 
            this.pnBusca.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnBusca.Controls.Add(this.txtPesquisaNome);
            this.pnBusca.Controls.Add(this.label14);
            this.pnBusca.Controls.Add(this.btnPesquisar);
            this.pnBusca.Location = new System.Drawing.Point(283, 313);
            this.pnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.pnBusca.Name = "pnBusca";
            this.pnBusca.Size = new System.Drawing.Size(449, 71);
            this.pnBusca.TabIndex = 57;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(69, 26);
            this.txtPesquisaNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaNome.MaxLength = 255;
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaNome.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Nome:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(311, 10);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 50);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgResultado
            // 
            this.dgResultado.AllowUserToAddRows = false;
            this.dgResultado.AllowUserToDeleteRows = false;
            this.dgResultado.AllowUserToOrderColumns = true;
            this.dgResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.Location = new System.Drawing.Point(12, 393);
            this.dgResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgResultado.MultiSelect = false;
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.RowHeadersVisible = false;
            this.dgResultado.RowTemplate.Height = 24;
            this.dgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResultado.Size = new System.Drawing.Size(972, 160);
            this.dgResultado.TabIndex = 58;
            this.dgResultado.DataSourceChanged += new System.EventHandler(this.dgResultado_DataSourceChanged);
            this.dgResultado.CurrentCellChanged += new System.EventHandler(this.dgResultado_CurrentCellChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.White;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Enabled = false;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(385, 107);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(339, 24);
            this.cbCategoria.TabIndex = 64;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(302, 111);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 63;
            this.label16.Text = "Categoria:";
            // 
            // cbFinalidade
            // 
            this.cbFinalidade.BackColor = System.Drawing.Color.White;
            this.cbFinalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinalidade.Enabled = false;
            this.cbFinalidade.FormattingEnabled = true;
            this.cbFinalidade.Location = new System.Drawing.Point(385, 156);
            this.cbFinalidade.Margin = new System.Windows.Forms.Padding(4);
            this.cbFinalidade.Name = "cbFinalidade";
            this.cbFinalidade.Size = new System.Drawing.Size(339, 24);
            this.cbFinalidade.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Finalidade:";
            // 
            // cbFabricante
            // 
            this.cbFabricante.BackColor = System.Drawing.Color.White;
            this.cbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFabricante.Enabled = false;
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(385, 205);
            this.cbFabricante.Margin = new System.Windows.Forms.Padding(4);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(339, 24);
            this.cbFabricante.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Fabricante:";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Enabled = false;
            this.txtValorUnit.Location = new System.Drawing.Point(385, 254);
            this.txtValorUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorUnit.MaxLength = 10;
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(121, 22);
            this.txtValorUnit.TabIndex = 69;
            this.txtValorUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Valor Unit. (R$) :";
            // 
            // FrmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.txtValorUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFabricante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFinalidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgResultado);
            this.Controls.Add(this.pnBusca);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMaterial";
            this.tsMenus.ResumeLayout(false);
            this.tsMenus.PerformLayout();
            this.pnBusca.ResumeLayout(false);
            this.pnBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenus;
        private System.Windows.Forms.ToolStripButton tbInserir;
        private System.Windows.Forms.ToolStripButton tbExcluir;
        private System.Windows.Forms.ToolStripButton tbNovo;
        private System.Windows.Forms.ToolStripButton tbAlterar;
        private System.Windows.Forms.ToolStripButton tbSalvar;
        private System.Windows.Forms.ToolStripButton tbCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnBusca;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.DataGridView dgResultado;
        public System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox cbFinalidade;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label label6;
    }
}