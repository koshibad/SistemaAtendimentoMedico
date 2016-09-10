namespace SistemaAtendimentoMedico.View
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tcFormularios = new System.Windows.Forms.TabControl();
            this.tpInicio = new System.Windows.Forms.TabPage();
            this.tpConvenio = new System.Windows.Forms.TabPage();
            this.tpEspecialidade = new System.Windows.Forms.TabPage();
            this.tpMedico = new System.Windows.Forms.TabPage();
            this.tpPaciente = new System.Windows.Forms.TabPage();
            this.tpMaterial = new System.Windows.Forms.TabPage();
            this.tpAgendamento = new System.Windows.Forms.TabPage();
            this.tpAtendimento = new System.Windows.Forms.TabPage();
            this.tpFaturamento = new System.Windows.Forms.TabPage();
            this.tcFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcFormularios
            // 
            this.tcFormularios.Controls.Add(this.tpInicio);
            this.tcFormularios.Controls.Add(this.tpConvenio);
            this.tcFormularios.Controls.Add(this.tpEspecialidade);
            this.tcFormularios.Controls.Add(this.tpMedico);
            this.tcFormularios.Controls.Add(this.tpPaciente);
            this.tcFormularios.Controls.Add(this.tpMaterial);
            this.tcFormularios.Controls.Add(this.tpAgendamento);
            this.tcFormularios.Controls.Add(this.tpAtendimento);
            this.tcFormularios.Controls.Add(this.tpFaturamento);
            this.tcFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFormularios.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcFormularios.Location = new System.Drawing.Point(0, 0);
            this.tcFormularios.Margin = new System.Windows.Forms.Padding(2);
            this.tcFormularios.Name = "tcFormularios";
            this.tcFormularios.SelectedIndex = 0;
            this.tcFormularios.Size = new System.Drawing.Size(882, 571);
            this.tcFormularios.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcFormularios.TabIndex = 0;
            this.tcFormularios.SelectedIndexChanged += new System.EventHandler(this.tcFormularios_SelectedIndexChanged);
            // 
            // tpInicio
            // 
            this.tpInicio.BackColor = System.Drawing.Color.FloralWhite;
            this.tpInicio.Location = new System.Drawing.Point(4, 24);
            this.tpInicio.Margin = new System.Windows.Forms.Padding(2);
            this.tpInicio.Name = "tpInicio";
            this.tpInicio.Size = new System.Drawing.Size(874, 543);
            this.tpInicio.TabIndex = 2;
            this.tpInicio.Text = "Inicio";
            // 
            // tpConvenio
            // 
            this.tpConvenio.BackColor = System.Drawing.Color.FloralWhite;
            this.tpConvenio.Location = new System.Drawing.Point(4, 24);
            this.tpConvenio.Margin = new System.Windows.Forms.Padding(2);
            this.tpConvenio.Name = "tpConvenio";
            this.tpConvenio.Padding = new System.Windows.Forms.Padding(2);
            this.tpConvenio.Size = new System.Drawing.Size(874, 543);
            this.tpConvenio.TabIndex = 0;
            this.tpConvenio.Text = "Convênio";
            // 
            // tpEspecialidade
            // 
            this.tpEspecialidade.BackColor = System.Drawing.Color.FloralWhite;
            this.tpEspecialidade.Location = new System.Drawing.Point(4, 24);
            this.tpEspecialidade.Name = "tpEspecialidade";
            this.tpEspecialidade.Size = new System.Drawing.Size(874, 543);
            this.tpEspecialidade.TabIndex = 5;
            this.tpEspecialidade.Text = "Especialidade";
            // 
            // tpMedico
            // 
            this.tpMedico.BackColor = System.Drawing.Color.FloralWhite;
            this.tpMedico.Location = new System.Drawing.Point(4, 24);
            this.tpMedico.Margin = new System.Windows.Forms.Padding(2);
            this.tpMedico.Name = "tpMedico";
            this.tpMedico.Padding = new System.Windows.Forms.Padding(2);
            this.tpMedico.Size = new System.Drawing.Size(874, 543);
            this.tpMedico.TabIndex = 1;
            this.tpMedico.Text = "Médico";
            // 
            // tpPaciente
            // 
            this.tpPaciente.BackColor = System.Drawing.Color.FloralWhite;
            this.tpPaciente.Location = new System.Drawing.Point(4, 24);
            this.tpPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.tpPaciente.Name = "tpPaciente";
            this.tpPaciente.Size = new System.Drawing.Size(874, 543);
            this.tpPaciente.TabIndex = 3;
            this.tpPaciente.Text = "Paciente";
            // 
            // tpMaterial
            // 
            this.tpMaterial.BackColor = System.Drawing.Color.FloralWhite;
            this.tpMaterial.Location = new System.Drawing.Point(4, 24);
            this.tpMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.tpMaterial.Name = "tpMaterial";
            this.tpMaterial.Size = new System.Drawing.Size(874, 543);
            this.tpMaterial.TabIndex = 4;
            this.tpMaterial.Text = "Material";
            // 
            // tpAgendamento
            // 
            this.tpAgendamento.BackColor = System.Drawing.Color.FloralWhite;
            this.tpAgendamento.Location = new System.Drawing.Point(4, 24);
            this.tpAgendamento.Name = "tpAgendamento";
            this.tpAgendamento.Size = new System.Drawing.Size(874, 543);
            this.tpAgendamento.TabIndex = 6;
            this.tpAgendamento.Text = "Agendamento";
            // 
            // tpAtendimento
            // 
            this.tpAtendimento.BackColor = System.Drawing.Color.FloralWhite;
            this.tpAtendimento.Location = new System.Drawing.Point(4, 24);
            this.tpAtendimento.Name = "tpAtendimento";
            this.tpAtendimento.Size = new System.Drawing.Size(874, 543);
            this.tpAtendimento.TabIndex = 7;
            this.tpAtendimento.Text = "Atendimento";
            // 
            // tpFaturamento
            // 
            this.tpFaturamento.Location = new System.Drawing.Point(4, 24);
            this.tpFaturamento.Name = "tpFaturamento";
            this.tpFaturamento.Size = new System.Drawing.Size(874, 543);
            this.tpFaturamento.TabIndex = 8;
            this.tpFaturamento.Text = "Faturamento";
            this.tpFaturamento.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(882, 571);
            this.Controls.Add(this.tcFormularios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Atendimento Médico";
            this.tcFormularios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcFormularios;
        private System.Windows.Forms.TabPage tpConvenio;
        private System.Windows.Forms.TabPage tpMedico;
        private System.Windows.Forms.TabPage tpInicio;
        private System.Windows.Forms.TabPage tpPaciente;
        private System.Windows.Forms.TabPage tpMaterial;
        private System.Windows.Forms.TabPage tpEspecialidade;
        private System.Windows.Forms.TabPage tpAgendamento;
        private System.Windows.Forms.TabPage tpAtendimento;
        private System.Windows.Forms.TabPage tpFaturamento;
    }
}

