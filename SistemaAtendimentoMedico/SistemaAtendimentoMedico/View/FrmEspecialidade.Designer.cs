namespace SistemaAtendimentoMedico.View
{
    partial class FrmEspecialidade
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
            this.txtRemuneracaoConvenio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnBusca = new System.Windows.Forms.Panel();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.txtRemuneracaoParticular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // txtRemuneracaoConvenio
            // 
            this.txtRemuneracaoConvenio.Enabled = false;
            this.txtRemuneracaoConvenio.Location = new System.Drawing.Point(461, 140);
            this.txtRemuneracaoConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemuneracaoConvenio.MaxLength = 6;
            this.txtRemuneracaoConvenio.Name = "txtRemuneracaoConvenio";
            this.txtRemuneracaoConvenio.Size = new System.Drawing.Size(71, 22);
            this.txtRemuneracaoConvenio.TabIndex = 6;
            this.txtRemuneracaoConvenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Remuneração Cônvenio (%):";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(313, 93);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.MaxLength = 255;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(369, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 97);
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
            this.pnBusca.Location = new System.Drawing.Point(260, 256);
            this.pnBusca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnBusca.Name = "pnBusca";
            this.pnBusca.Size = new System.Drawing.Size(449, 71);
            this.pnBusca.TabIndex = 57;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(69, 24);
            this.txtPesquisaNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisaNome.MaxLength = 255;
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaNome.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Nome:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(311, 10);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dgResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgResultado.Location = new System.Drawing.Point(122, 364);
            this.dgResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgResultado.MultiSelect = false;
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.RowHeadersVisible = false;
            this.dgResultado.RowTemplate.Height = 24;
            this.dgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResultado.Size = new System.Drawing.Size(749, 189);
            this.dgResultado.TabIndex = 58;
            this.dgResultado.DataSourceChanged += new System.EventHandler(this.dgResultado_DataSourceChanged);
            this.dgResultado.CurrentCellChanged += new System.EventHandler(this.dgResultado_CurrentCellChanged);
            // 
            // txtRemuneracaoParticular
            // 
            this.txtRemuneracaoParticular.Enabled = false;
            this.txtRemuneracaoParticular.Location = new System.Drawing.Point(461, 190);
            this.txtRemuneracaoParticular.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemuneracaoParticular.MaxLength = 6;
            this.txtRemuneracaoParticular.Name = "txtRemuneracaoParticular";
            this.txtRemuneracaoParticular.Size = new System.Drawing.Size(71, 22);
            this.txtRemuneracaoParticular.TabIndex = 59;
            this.txtRemuneracaoParticular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Remuneração Particular (%):";
            // 
            // FrmEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.txtRemuneracaoParticular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgResultado);
            this.Controls.Add(this.pnBusca);
            this.Controls.Add(this.txtRemuneracaoConvenio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEspecialidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEspecialidade";
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
        private System.Windows.Forms.TextBox txtRemuneracaoConvenio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnBusca;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.TextBox txtRemuneracaoParticular;
        private System.Windows.Forms.Label label1;
    }
}