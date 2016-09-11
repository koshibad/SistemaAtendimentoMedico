namespace SistemaAtendimentoMedico.View
{
    partial class FrmAgendamento
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
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpfPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBusca = new System.Windows.Forms.Panel();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisaCpf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCrmMedico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEspecialidadeMedico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbConvenio = new System.Windows.Forms.ComboBox();
            this.lbConvenio = new System.Windows.Forms.Label();
            this.pnPesquisaPessoas = new System.Windows.Forms.Panel();
            this.btnPesquisarMedico = new System.Windows.Forms.Button();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.tsMenus.SuspendLayout();
            this.pnBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.pnPesquisaPessoas.SuspendLayout();
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
            // txtNomePaciente
            // 
            this.txtNomePaciente.Enabled = false;
            this.txtNomePaciente.Location = new System.Drawing.Point(517, 139);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePaciente.MaxLength = 255;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(369, 22);
            this.txtNomePaciente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nome Paciente:";
            // 
            // txtCpfPaciente
            // 
            this.txtCpfPaciente.Enabled = false;
            this.txtCpfPaciente.Location = new System.Drawing.Point(285, 139);
            this.txtCpfPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfPaciente.MaxLength = 11;
            this.txtCpfPaciente.Name = "txtCpfPaciente";
            this.txtCpfPaciente.Size = new System.Drawing.Size(110, 22);
            this.txtCpfPaciente.TabIndex = 0;
            this.txtCpfPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "CPF Paciente:";
            // 
            // pnBusca
            // 
            this.pnBusca.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnBusca.Controls.Add(this.txtPesquisaNome);
            this.pnBusca.Controls.Add(this.label14);
            this.pnBusca.Controls.Add(this.btnPesquisar);
            this.pnBusca.Controls.Add(this.txtPesquisaCpf);
            this.pnBusca.Controls.Add(this.label13);
            this.pnBusca.Location = new System.Drawing.Point(270, 313);
            this.pnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.pnBusca.Name = "pnBusca";
            this.pnBusca.Size = new System.Drawing.Size(493, 71);
            this.pnBusca.TabIndex = 57;
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(122, 39);
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
            this.btnPesquisar.Location = new System.Drawing.Point(364, 10);
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
            this.txtPesquisaCpf.Location = new System.Drawing.Point(122, 10);
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
            this.dgResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
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
            // txtNomeMedico
            // 
            this.txtNomeMedico.Enabled = false;
            this.txtNomeMedico.Location = new System.Drawing.Point(654, 174);
            this.txtNomeMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeMedico.MaxLength = 255;
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(302, 22);
            this.txtNomeMedico.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Nome Medico:";
            // 
            // txtCrmMedico
            // 
            this.txtCrmMedico.Enabled = false;
            this.txtCrmMedico.Location = new System.Drawing.Point(124, 174);
            this.txtCrmMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrmMedico.MaxLength = 11;
            this.txtCrmMedico.Name = "txtCrmMedico";
            this.txtCrmMedico.Size = new System.Drawing.Size(110, 22);
            this.txtCrmMedico.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "CRM Medico:";
            // 
            // txtEspecialidadeMedico
            // 
            this.txtEspecialidadeMedico.Enabled = false;
            this.txtEspecialidadeMedico.Location = new System.Drawing.Point(349, 174);
            this.txtEspecialidadeMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtEspecialidadeMedico.MaxLength = 11;
            this.txtEspecialidadeMedico.Name = "txtEspecialidadeMedico";
            this.txtEspecialidadeMedico.Size = new System.Drawing.Size(195, 22);
            this.txtEspecialidadeMedico.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Especialidade:";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Location = new System.Drawing.Point(266, 210);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(295, 22);
            this.dtpData.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Data da Consulta:";
            // 
            // cbHorario
            // 
            this.cbHorario.BackColor = System.Drawing.Color.White;
            this.cbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorario.Enabled = false;
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(672, 209);
            this.cbHorario.Margin = new System.Windows.Forms.Padding(4);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(149, 24);
            this.cbHorario.TabIndex = 68;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(605, 213);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 67;
            this.label16.Text = "Horario:";
            // 
            // cbTipoConsulta
            // 
            this.cbTipoConsulta.BackColor = System.Drawing.Color.White;
            this.cbTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoConsulta.Enabled = false;
            this.cbTipoConsulta.FormattingEnabled = true;
            this.cbTipoConsulta.Location = new System.Drawing.Point(316, 248);
            this.cbTipoConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoConsulta.Name = "cbTipoConsulta";
            this.cbTipoConsulta.Size = new System.Drawing.Size(149, 24);
            this.cbTipoConsulta.TabIndex = 70;
            this.cbTipoConsulta.SelectedIndexChanged += new System.EventHandler(this.cbTipoConsulta_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Tipo de Consulta:";
            // 
            // cbConvenio
            // 
            this.cbConvenio.BackColor = System.Drawing.Color.White;
            this.cbConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConvenio.Enabled = false;
            this.cbConvenio.FormattingEnabled = true;
            this.cbConvenio.Location = new System.Drawing.Point(598, 248);
            this.cbConvenio.Margin = new System.Windows.Forms.Padding(4);
            this.cbConvenio.Name = "cbConvenio";
            this.cbConvenio.Size = new System.Drawing.Size(245, 24);
            this.cbConvenio.TabIndex = 72;
            // 
            // lbConvenio
            // 
            this.lbConvenio.AutoSize = true;
            this.lbConvenio.Location = new System.Drawing.Point(519, 252);
            this.lbConvenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConvenio.Name = "lbConvenio";
            this.lbConvenio.Size = new System.Drawing.Size(71, 17);
            this.lbConvenio.TabIndex = 71;
            this.lbConvenio.Text = "Convenio:";
            // 
            // pnPesquisaPessoas
            // 
            this.pnPesquisaPessoas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnPesquisaPessoas.Controls.Add(this.btnPesquisarMedico);
            this.pnPesquisaPessoas.Controls.Add(this.btnPesquisarPaciente);
            this.pnPesquisaPessoas.Location = new System.Drawing.Point(290, 58);
            this.pnPesquisaPessoas.Margin = new System.Windows.Forms.Padding(4);
            this.pnPesquisaPessoas.Name = "pnPesquisaPessoas";
            this.pnPesquisaPessoas.Size = new System.Drawing.Size(449, 59);
            this.pnPesquisaPessoas.TabIndex = 58;
            this.pnPesquisaPessoas.Visible = false;
            // 
            // btnPesquisarMedico
            // 
            this.btnPesquisarMedico.Location = new System.Drawing.Point(250, 12);
            this.btnPesquisarMedico.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarMedico.Name = "btnPesquisarMedico";
            this.btnPesquisarMedico.Size = new System.Drawing.Size(162, 35);
            this.btnPesquisarMedico.TabIndex = 9;
            this.btnPesquisarMedico.Text = "Pesquisar Medico";
            this.btnPesquisarMedico.UseVisualStyleBackColor = true;
            this.btnPesquisarMedico.Click += new System.EventHandler(this.btnPesquisarMedico_Click);
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(40, 12);
            this.btnPesquisarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(162, 35);
            this.btnPesquisarPaciente.TabIndex = 8;
            this.btnPesquisarPaciente.Text = "Pesquisar Paciente";
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisarPaciente.Click += new System.EventHandler(this.btnPesquisarPaciente_Click);
            // 
            // FrmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.pnPesquisaPessoas);
            this.Controls.Add(this.cbConvenio);
            this.Controls.Add(this.lbConvenio);
            this.Controls.Add(this.cbTipoConsulta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtEspecialidadeMedico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCrmMedico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgResultado);
            this.Controls.Add(this.pnBusca);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpfPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgendamento";
            this.tsMenus.ResumeLayout(false);
            this.tsMenus.PerformLayout();
            this.pnBusca.ResumeLayout(false);
            this.pnBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            this.pnPesquisaPessoas.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpfPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnBusca;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisaCpf;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCrmMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEspecialidadeMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox cbTipoConsulta;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbConvenio;
        private System.Windows.Forms.Label lbConvenio;
        private System.Windows.Forms.Panel pnPesquisaPessoas;
        private System.Windows.Forms.Button btnPesquisarMedico;
        private System.Windows.Forms.Button btnPesquisarPaciente;
    }
}