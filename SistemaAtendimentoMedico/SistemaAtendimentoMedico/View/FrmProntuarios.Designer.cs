namespace SistemaAtendimentoMedico.View
{
    partial class FrmProntuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProntuarios));
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.cbConvenio = new System.Windows.Forms.ComboBox();
            this.lbConvenio = new System.Windows.Forms.Label();
            this.cbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtEspecialidadeMedico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCrmMedico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpfPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTratamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMateriaisUtilizados = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResultado
            // 
            this.dgResultado.AllowUserToAddRows = false;
            this.dgResultado.AllowUserToDeleteRows = false;
            this.dgResultado.AllowUserToOrderColumns = true;
            this.dgResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgResultado.Location = new System.Drawing.Point(12, 298);
            this.dgResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgResultado.MultiSelect = false;
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.RowHeadersVisible = false;
            this.dgResultado.RowTemplate.Height = 24;
            this.dgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResultado.Size = new System.Drawing.Size(1049, 232);
            this.dgResultado.TabIndex = 61;
            this.dgResultado.DataSourceChanged += new System.EventHandler(this.dgResultado_DataSourceChanged);
            this.dgResultado.CurrentCellChanged += new System.EventHandler(this.dgResultado_CurrentCellChanged);
            // 
            // cbConvenio
            // 
            this.cbConvenio.BackColor = System.Drawing.Color.White;
            this.cbConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConvenio.Enabled = false;
            this.cbConvenio.FormattingEnabled = true;
            this.cbConvenio.Location = new System.Drawing.Point(642, 122);
            this.cbConvenio.Margin = new System.Windows.Forms.Padding(4);
            this.cbConvenio.Name = "cbConvenio";
            this.cbConvenio.Size = new System.Drawing.Size(245, 24);
            this.cbConvenio.TabIndex = 90;
            // 
            // lbConvenio
            // 
            this.lbConvenio.AutoSize = true;
            this.lbConvenio.Location = new System.Drawing.Point(563, 126);
            this.lbConvenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConvenio.Name = "lbConvenio";
            this.lbConvenio.Size = new System.Drawing.Size(71, 17);
            this.lbConvenio.TabIndex = 89;
            this.lbConvenio.Text = "Convenio:";
            // 
            // cbTipoConsulta
            // 
            this.cbTipoConsulta.BackColor = System.Drawing.Color.White;
            this.cbTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoConsulta.Enabled = false;
            this.cbTipoConsulta.FormattingEnabled = true;
            this.cbTipoConsulta.Location = new System.Drawing.Point(360, 122);
            this.cbTipoConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoConsulta.Name = "cbTipoConsulta";
            this.cbTipoConsulta.Size = new System.Drawing.Size(149, 24);
            this.cbTipoConsulta.TabIndex = 88;
            this.cbTipoConsulta.SelectedIndexChanged += new System.EventHandler(this.cbTipoConsulta_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 87;
            this.label7.Text = "Tipo de Consulta:";
            // 
            // cbHorario
            // 
            this.cbHorario.BackColor = System.Drawing.Color.White;
            this.cbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorario.Enabled = false;
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(716, 83);
            this.cbHorario.Margin = new System.Windows.Forms.Padding(4);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(149, 24);
            this.cbHorario.TabIndex = 86;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(649, 87);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 85;
            this.label16.Text = "Horario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "Data da Consulta:";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Location = new System.Drawing.Point(310, 84);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(295, 22);
            this.dtpData.TabIndex = 83;
            // 
            // txtEspecialidadeMedico
            // 
            this.txtEspecialidadeMedico.Enabled = false;
            this.txtEspecialidadeMedico.Location = new System.Drawing.Point(393, 48);
            this.txtEspecialidadeMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtEspecialidadeMedico.MaxLength = 11;
            this.txtEspecialidadeMedico.Name = "txtEspecialidadeMedico";
            this.txtEspecialidadeMedico.Size = new System.Drawing.Size(195, 22);
            this.txtEspecialidadeMedico.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "Especialidade:";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Enabled = false;
            this.txtNomeMedico.Location = new System.Drawing.Point(698, 48);
            this.txtNomeMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeMedico.MaxLength = 255;
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(302, 22);
            this.txtNomeMedico.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Nome Medico:";
            // 
            // txtCrmMedico
            // 
            this.txtCrmMedico.Enabled = false;
            this.txtCrmMedico.Location = new System.Drawing.Point(168, 48);
            this.txtCrmMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrmMedico.MaxLength = 11;
            this.txtCrmMedico.Name = "txtCrmMedico";
            this.txtCrmMedico.Size = new System.Drawing.Size(110, 22);
            this.txtCrmMedico.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "CRM Medico:";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Enabled = false;
            this.txtNomePaciente.Location = new System.Drawing.Point(561, 13);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePaciente.MaxLength = 255;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(369, 22);
            this.txtNomePaciente.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nome Paciente:";
            // 
            // txtCpfPaciente
            // 
            this.txtCpfPaciente.Enabled = false;
            this.txtCpfPaciente.Location = new System.Drawing.Point(329, 13);
            this.txtCpfPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfPaciente.MaxLength = 11;
            this.txtCpfPaciente.Name = "txtCpfPaciente";
            this.txtCpfPaciente.Size = new System.Drawing.Size(110, 22);
            this.txtCpfPaciente.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "CPF Paciente:";
            // 
            // txtTratamento
            // 
            this.txtTratamento.Enabled = false;
            this.txtTratamento.Location = new System.Drawing.Point(168, 165);
            this.txtTratamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTratamento.MaxLength = 500;
            this.txtTratamento.Multiline = true;
            this.txtTratamento.Name = "txtTratamento";
            this.txtTratamento.Size = new System.Drawing.Size(369, 108);
            this.txtTratamento.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 92;
            this.label8.Text = "Tratamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 165);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 94;
            this.label9.Text = "Materias Utilizados";
            // 
            // lbMateriaisUtilizados
            // 
            this.lbMateriaisUtilizados.FormattingEnabled = true;
            this.lbMateriaisUtilizados.ItemHeight = 16;
            this.lbMateriaisUtilizados.Location = new System.Drawing.Point(716, 167);
            this.lbMateriaisUtilizados.Name = "lbMateriaisUtilizados";
            this.lbMateriaisUtilizados.Size = new System.Drawing.Size(284, 100);
            this.lbMateriaisUtilizados.TabIndex = 93;
            // 
            // FrmProntuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1076, 541);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbMateriaisUtilizados);
            this.Controls.Add(this.txtTratamento);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpfPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProntuarios";
            this.Text = "Prontuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgResultado;
        public System.Windows.Forms.ComboBox cbConvenio;
        private System.Windows.Forms.Label lbConvenio;
        public System.Windows.Forms.ComboBox cbTipoConsulta;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtEspecialidadeMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCrmMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpfPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTratamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbMateriaisUtilizados;
        private System.Windows.Forms.Label label9;
    }
}