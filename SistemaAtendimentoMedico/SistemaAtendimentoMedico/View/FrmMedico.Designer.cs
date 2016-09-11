namespace SistemaAtendimentoMedico.View
{
    partial class FrmMedico
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
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.pnBusca = new System.Windows.Forms.Panel();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisaCpf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
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
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(547, 185);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(297, 22);
            this.txtBairro.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 188);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(215, 185);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.MaxLength = 11;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(260, 22);
            this.txtComplemento.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Complemento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(659, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 51;
            this.label9.Text = "CEP:";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Enabled = false;
            this.txtMunicipio.Location = new System.Drawing.Point(365, 108);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.MaxLength = 100;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(280, 22);
            this.txtMunicipio.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Município:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "UF:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(773, 145);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(71, 22);
            this.txtNumero.TabIndex = 6;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Nº:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(215, 145);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(497, 22);
            this.txtLogradouro.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Logradouro:";
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(448, 220);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Mask = "(99) 0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(125, 22);
            this.txtCelular.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Celular:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(215, 220);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 22);
            this.txtTelefone.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 224);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(215, 258);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(547, 66);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 255;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nome:";
            // 
            // txtCpf
            // 
            this.txtCpf.Enabled = false;
            this.txtCpf.Location = new System.Drawing.Point(215, 66);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(110, 22);
            this.txtCpf.TabIndex = 0;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "CPF:";
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(696, 107);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(148, 22);
            this.txtCep.TabIndex = 4;
            // 
            // pnBusca
            // 
            this.pnBusca.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnBusca.Controls.Add(this.txtPesquisaNome);
            this.pnBusca.Controls.Add(this.label14);
            this.pnBusca.Controls.Add(this.btnPesquisar);
            this.pnBusca.Controls.Add(this.txtPesquisaCpf);
            this.pnBusca.Controls.Add(this.label13);
            this.pnBusca.Location = new System.Drawing.Point(265, 313);
            this.pnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.pnBusca.Name = "pnBusca";
            this.pnBusca.Size = new System.Drawing.Size(449, 71);
            this.pnBusca.TabIndex = 57;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(69, 39);
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
            // txtPesquisaCpf
            // 
            this.txtPesquisaCpf.Location = new System.Drawing.Point(69, 10);
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
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "CPF:";
            // 
            // dgResultado
            // 
            this.dgResultado.AllowUserToAddRows = false;
            this.dgResultado.AllowUserToDeleteRows = false;
            this.dgResultado.AllowUserToOrderColumns = true;
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
            this.dgResultado.CurrentCellChanged += new System.EventHandler(this.dgResultado_CurrentCellChanged);
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Enabled = false;
            this.txtDataNasc.Location = new System.Drawing.Point(696, 220);
            this.txtDataNasc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(148, 22);
            this.txtDataNasc.TabIndex = 59;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(611, 224);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 60;
            this.label15.Text = "Data Nasc.:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(489, 262);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 17);
            this.label16.TabIndex = 61;
            this.label16.Text = "Especialidade:";
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.BackColor = System.Drawing.Color.White;
            this.cbEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidade.Enabled = false;
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Location = new System.Drawing.Point(599, 258);
            this.cbEspecialidade.Margin = new System.Windows.Forms.Padding(4);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(245, 24);
            this.cbEspecialidade.TabIndex = 62;
            // 
            // cbUF
            // 
            this.cbUF.BackColor = System.Drawing.Color.White;
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.Enabled = false;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(215, 107);
            this.cbUF.Margin = new System.Windows.Forms.Padding(4);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(58, 24);
            this.cbUF.TabIndex = 63;
            // 
            // txtCRM
            // 
            this.txtCRM.Enabled = false;
            this.txtCRM.Location = new System.Drawing.Point(377, 66);
            this.txtCRM.Margin = new System.Windows.Forms.Padding(4);
            this.txtCRM.MaxLength = 10;
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(110, 22);
            this.txtCRM.TabIndex = 64;
            this.txtCRM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(335, 69);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 17);
            this.label17.TabIndex = 65;
            this.label17.Text = "CRM:";
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.cbEspecialidade);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgResultado);
            this.Controls.Add(this.pnBusca);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMedico";
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
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Panel pnBusca;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisaCpf;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox cbEspecialidade;
        public System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.Label label17;
    }
}