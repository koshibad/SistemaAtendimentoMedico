namespace SistemaAtendimentoMedico.View
{
    partial class FrmFaturamento
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
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.txtPesquisaEspecialidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaCrm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGerarRelatorioMedico = new System.Windows.Forms.Button();
            this.txtPesquisaCpf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbMedico = new System.Windows.Forms.GroupBox();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.txtCpfPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.btnGerarRelatorioPaciente = new System.Windows.Forms.Button();
            this.gbMedico.SuspendLayout();
            this.gbPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelatorio.Location = new System.Drawing.Point(76, 254);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.ReadOnly = true;
            this.txtRelatorio.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRelatorio.Size = new System.Drawing.Size(837, 305);
            this.txtRelatorio.TabIndex = 0;
            this.txtRelatorio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesquisaEspecialidade
            // 
            this.txtPesquisaEspecialidade.Location = new System.Drawing.Point(412, 64);
            this.txtPesquisaEspecialidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaEspecialidade.MaxLength = 11;
            this.txtPesquisaEspecialidade.Name = "txtPesquisaEspecialidade";
            this.txtPesquisaEspecialidade.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaEspecialidade.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Especialidade:";
            // 
            // txtPesquisaCrm
            // 
            this.txtPesquisaCrm.Location = new System.Drawing.Point(412, 34);
            this.txtPesquisaCrm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaCrm.MaxLength = 11;
            this.txtPesquisaCrm.Name = "txtPesquisaCrm";
            this.txtPesquisaCrm.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaCrm.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "CRM:";
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(75, 63);
            this.txtPesquisaNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaNome.MaxLength = 255;
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaNome.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 66);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Nome:";
            // 
            // btnGerarRelatorioMedico
            // 
            this.btnGerarRelatorioMedico.Location = new System.Drawing.Point(652, 34);
            this.btnGerarRelatorioMedico.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerarRelatorioMedico.Name = "btnGerarRelatorioMedico";
            this.btnGerarRelatorioMedico.Size = new System.Drawing.Size(111, 50);
            this.btnGerarRelatorioMedico.TabIndex = 8;
            this.btnGerarRelatorioMedico.Text = "Pesquisar e Gerar";
            this.btnGerarRelatorioMedico.UseVisualStyleBackColor = true;
            this.btnGerarRelatorioMedico.Click += new System.EventHandler(this.btnGerarRelatorioMedico_Click);
            // 
            // txtPesquisaCpf
            // 
            this.txtPesquisaCpf.Location = new System.Drawing.Point(75, 34);
            this.txtPesquisaCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaCpf.MaxLength = 11;
            this.txtPesquisaCpf.Name = "txtPesquisaCpf";
            this.txtPesquisaCpf.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaCpf.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 38);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "CPF:";
            // 
            // gbMedico
            // 
            this.gbMedico.BackColor = System.Drawing.Color.Honeydew;
            this.gbMedico.Controls.Add(this.txtPesquisaCpf);
            this.gbMedico.Controls.Add(this.txtPesquisaEspecialidade);
            this.gbMedico.Controls.Add(this.btnGerarRelatorioMedico);
            this.gbMedico.Controls.Add(this.label1);
            this.gbMedico.Controls.Add(this.label14);
            this.gbMedico.Controls.Add(this.label13);
            this.gbMedico.Controls.Add(this.txtPesquisaCrm);
            this.gbMedico.Controls.Add(this.label2);
            this.gbMedico.Controls.Add(this.txtPesquisaNome);
            this.gbMedico.Location = new System.Drawing.Point(99, 19);
            this.gbMedico.Name = "gbMedico";
            this.gbMedico.Size = new System.Drawing.Size(791, 100);
            this.gbMedico.TabIndex = 27;
            this.gbMedico.TabStop = false;
            this.gbMedico.Text = "Medico";
            // 
            // gbPaciente
            // 
            this.gbPaciente.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbPaciente.Controls.Add(this.btnGerarRelatorioPaciente);
            this.gbPaciente.Controls.Add(this.txtCpfPaciente);
            this.gbPaciente.Controls.Add(this.label3);
            this.gbPaciente.Controls.Add(this.label4);
            this.gbPaciente.Controls.Add(this.txtNomePaciente);
            this.gbPaciente.Location = new System.Drawing.Point(99, 134);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Size = new System.Drawing.Size(791, 81);
            this.gbPaciente.TabIndex = 28;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Paciente";
            // 
            // txtCpfPaciente
            // 
            this.txtCpfPaciente.Location = new System.Drawing.Point(75, 32);
            this.txtCpfPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfPaciente.MaxLength = 11;
            this.txtCpfPaciente.Name = "txtCpfPaciente";
            this.txtCpfPaciente.Size = new System.Drawing.Size(217, 22);
            this.txtCpfPaciente.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "CPF:";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(373, 32);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePaciente.MaxLength = 255;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(256, 22);
            this.txtNomePaciente.TabIndex = 25;
            // 
            // btnGerarRelatorioPaciente
            // 
            this.btnGerarRelatorioPaciente.Location = new System.Drawing.Point(652, 18);
            this.btnGerarRelatorioPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerarRelatorioPaciente.Name = "btnGerarRelatorioPaciente";
            this.btnGerarRelatorioPaciente.Size = new System.Drawing.Size(111, 50);
            this.btnGerarRelatorioPaciente.TabIndex = 27;
            this.btnGerarRelatorioPaciente.Text = "Pesquisar e Gerar";
            this.btnGerarRelatorioPaciente.UseVisualStyleBackColor = true;
            this.btnGerarRelatorioPaciente.Click += new System.EventHandler(this.btnGerarRelatorioPaciente_Click);
            // 
            // FrmFaturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.gbPaciente);
            this.Controls.Add(this.gbMedico);
            this.Controls.Add(this.txtRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFaturamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFaturamento";
            this.gbMedico.ResumeLayout(false);
            this.gbMedico.PerformLayout();
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRelatorio;
        private System.Windows.Forms.TextBox txtPesquisaEspecialidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaCrm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGerarRelatorioMedico;
        private System.Windows.Forms.TextBox txtPesquisaCpf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbMedico;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.Button btnGerarRelatorioPaciente;
        private System.Windows.Forms.TextBox txtCpfPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomePaciente;
    }
}