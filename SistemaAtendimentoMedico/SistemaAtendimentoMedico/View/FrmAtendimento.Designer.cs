namespace SistemaAtendimentoMedico.View
{
    partial class FrmAtendimento
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
            this.tbAlterar = new System.Windows.Forms.ToolStripButton();
            this.tbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tbCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtTratamento = new System.Windows.Forms.TextBox();
            this.pnBusca = new System.Windows.Forms.Panel();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisaCpf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpfPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTodosMateriais = new System.Windows.Forms.ListBox();
            this.lbMateriaisUtilizados = new System.Windows.Forms.ListBox();
            this.lblMateriais = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblQtde = new System.Windows.Forms.Label();
            this.txtQtdeMaterial = new System.Windows.Forms.TextBox();
            this.btnProntuarios = new System.Windows.Forms.Button();
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
            this.tbAlterar,
            this.tbSalvar,
            this.tbCancelar});
            this.tsMenus.Location = new System.Drawing.Point(0, 0);
            this.tsMenus.Name = "tsMenus";
            this.tsMenus.Padding = new System.Windows.Forms.Padding(0);
            this.tsMenus.Size = new System.Drawing.Size(999, 45);
            this.tsMenus.TabIndex = 0;
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
            // txtTratamento
            // 
            this.txtTratamento.Enabled = false;
            this.txtTratamento.Location = new System.Drawing.Point(606, 135);
            this.txtTratamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTratamento.MaxLength = 500;
            this.txtTratamento.Multiline = true;
            this.txtTratamento.Name = "txtTratamento";
            this.txtTratamento.Size = new System.Drawing.Size(369, 148);
            this.txtTratamento.TabIndex = 5;
            // 
            // pnBusca
            // 
            this.pnBusca.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnBusca.Controls.Add(this.txtPesquisaNome);
            this.pnBusca.Controls.Add(this.label14);
            this.pnBusca.Controls.Add(this.btnPesquisar);
            this.pnBusca.Controls.Add(this.txtPesquisaCpf);
            this.pnBusca.Controls.Add(this.label13);
            this.pnBusca.Location = new System.Drawing.Point(249, 313);
            this.pnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.pnBusca.Name = "pnBusca";
            this.pnBusca.Size = new System.Drawing.Size(504, 71);
            this.pnBusca.TabIndex = 57;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(125, 39);
            this.txtPesquisaNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaNome.MaxLength = 255;
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaNome.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 42);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Nome Paciente:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(373, 10);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 50);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisaCpf
            // 
            this.txtPesquisaCpf.Location = new System.Drawing.Point(125, 10);
            this.txtPesquisaCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaCpf.MaxLength = 11;
            this.txtPesquisaCpf.Name = "txtPesquisaCpf";
            this.txtPesquisaCpf.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaCpf.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "CPF Paciente:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tratamento:";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Enabled = false;
            this.txtNomePaciente.Location = new System.Drawing.Point(606, 102);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePaciente.MaxLength = 255;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(369, 22);
            this.txtNomePaciente.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nome Paciente:";
            // 
            // txtCpfPaciente
            // 
            this.txtCpfPaciente.Enabled = false;
            this.txtCpfPaciente.Location = new System.Drawing.Point(606, 68);
            this.txtCpfPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfPaciente.MaxLength = 11;
            this.txtCpfPaciente.Name = "txtCpfPaciente";
            this.txtCpfPaciente.Size = new System.Drawing.Size(110, 22);
            this.txtCpfPaciente.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "CPF Paciente:";
            // 
            // lbTodosMateriais
            // 
            this.lbTodosMateriais.FormattingEnabled = true;
            this.lbTodosMateriais.ItemHeight = 16;
            this.lbTodosMateriais.Location = new System.Drawing.Point(12, 103);
            this.lbTodosMateriais.Name = "lbTodosMateriais";
            this.lbTodosMateriais.Size = new System.Drawing.Size(151, 180);
            this.lbTodosMateriais.TabIndex = 63;
            // 
            // lbMateriaisUtilizados
            // 
            this.lbMateriaisUtilizados.FormattingEnabled = true;
            this.lbMateriaisUtilizados.ItemHeight = 16;
            this.lbMateriaisUtilizados.Location = new System.Drawing.Point(272, 103);
            this.lbMateriaisUtilizados.Name = "lbMateriaisUtilizados";
            this.lbMateriaisUtilizados.Size = new System.Drawing.Size(151, 180);
            this.lbMateriaisUtilizados.TabIndex = 64;
            // 
            // lblMateriais
            // 
            this.lblMateriais.AutoSize = true;
            this.lblMateriais.Location = new System.Drawing.Point(53, 72);
            this.lblMateriais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateriais.Name = "lblMateriais";
            this.lblMateriais.Size = new System.Drawing.Size(62, 17);
            this.lblMateriais.TabIndex = 65;
            this.lblMateriais.Text = "Materias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Materias Utilizados";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(198, 106);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(35, 35);
            this.btnAdicionar.TabIndex = 67;
            this.btnAdicionar.Text = ">>";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(198, 243);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(35, 35);
            this.btnRemover.TabIndex = 68;
            this.btnRemover.Text = "<<";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(194, 165);
            this.lblQtde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(47, 17);
            this.lblQtde.TabIndex = 69;
            this.lblQtde.Text = "Qtde.:";
            // 
            // txtQtdeMaterial
            // 
            this.txtQtdeMaterial.Enabled = false;
            this.txtQtdeMaterial.Location = new System.Drawing.Point(190, 186);
            this.txtQtdeMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdeMaterial.MaxLength = 6;
            this.txtQtdeMaterial.Name = "txtQtdeMaterial";
            this.txtQtdeMaterial.Size = new System.Drawing.Size(55, 22);
            this.txtQtdeMaterial.TabIndex = 70;
            this.txtQtdeMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // btnProntuarios
            // 
            this.btnProntuarios.Location = new System.Drawing.Point(496, 223);
            this.btnProntuarios.Name = "btnProntuarios";
            this.btnProntuarios.Size = new System.Drawing.Size(101, 60);
            this.btnProntuarios.TabIndex = 71;
            this.btnProntuarios.Text = "Prontuários Antigos";
            this.btnProntuarios.UseVisualStyleBackColor = true;
            // 
            // FrmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.btnProntuarios);
            this.Controls.Add(this.txtQtdeMaterial);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMateriais);
            this.Controls.Add(this.lbMateriaisUtilizados);
            this.Controls.Add(this.lbTodosMateriais);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpfPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgResultado);
            this.Controls.Add(this.pnBusca);
            this.Controls.Add(this.txtTratamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tsMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAtendimento";
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
        private System.Windows.Forms.ToolStripButton tbAlterar;
        private System.Windows.Forms.ToolStripButton tbSalvar;
        private System.Windows.Forms.ToolStripButton tbCancelar;
        private System.Windows.Forms.TextBox txtTratamento;
        private System.Windows.Forms.Panel pnBusca;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisaCpf;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpfPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTodosMateriais;
        private System.Windows.Forms.ListBox lbMateriaisUtilizados;
        private System.Windows.Forms.Label lblMateriais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.TextBox txtQtdeMaterial;
        private System.Windows.Forms.Button btnProntuarios;
    }
}