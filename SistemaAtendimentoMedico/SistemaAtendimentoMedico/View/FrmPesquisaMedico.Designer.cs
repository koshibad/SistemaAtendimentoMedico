namespace SistemaAtendimentoMedico.View
{
    partial class FrmPesquisaMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaMedico));
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.pnBusca = new System.Windows.Forms.Panel();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisaCpf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaCrm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisaEspecialidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.pnBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgResultado
            // 
            this.dgResultado.AllowUserToAddRows = false;
            this.dgResultado.AllowUserToDeleteRows = false;
            this.dgResultado.AllowUserToOrderColumns = true;
            this.dgResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgResultado.Location = new System.Drawing.Point(12, 88);
            this.dgResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgResultado.MultiSelect = false;
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.RowHeadersVisible = false;
            this.dgResultado.RowTemplate.Height = 24;
            this.dgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResultado.Size = new System.Drawing.Size(1049, 232);
            this.dgResultado.TabIndex = 60;
            // 
            // pnBusca
            // 
            this.pnBusca.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnBusca.Controls.Add(this.txtPesquisaEspecialidade);
            this.pnBusca.Controls.Add(this.label1);
            this.pnBusca.Controls.Add(this.txtPesquisaCrm);
            this.pnBusca.Controls.Add(this.label2);
            this.pnBusca.Controls.Add(this.btnSelecionar);
            this.pnBusca.Controls.Add(this.txtPesquisaNome);
            this.pnBusca.Controls.Add(this.label14);
            this.pnBusca.Controls.Add(this.btnPesquisar);
            this.pnBusca.Controls.Add(this.txtPesquisaCpf);
            this.pnBusca.Controls.Add(this.label13);
            this.pnBusca.Location = new System.Drawing.Point(60, 11);
            this.pnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.pnBusca.Name = "pnBusca";
            this.pnBusca.Size = new System.Drawing.Size(909, 71);
            this.pnBusca.TabIndex = 59;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(775, 10);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(111, 50);
            this.btnSelecionar.TabIndex = 22;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
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
            this.btnPesquisar.Location = new System.Drawing.Point(646, 10);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Especialidade:";
            // 
            // txtPesquisaCrm
            // 
            this.txtPesquisaCrm.Location = new System.Drawing.Point(406, 10);
            this.txtPesquisaCrm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaCrm.MaxLength = 11;
            this.txtPesquisaCrm.Name = "txtPesquisaCrm";
            this.txtPesquisaCrm.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaCrm.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "CRM:";
            // 
            // txtPesquisaEspecialidade
            // 
            this.txtPesquisaEspecialidade.Location = new System.Drawing.Point(406, 40);
            this.txtPesquisaEspecialidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaEspecialidade.MaxLength = 11;
            this.txtPesquisaEspecialidade.Name = "txtPesquisaEspecialidade";
            this.txtPesquisaEspecialidade.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaEspecialidade.TabIndex = 26;
            // 
            // FrmPesquisaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1073, 331);
            this.Controls.Add(this.dgResultado);
            this.Controls.Add(this.pnBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisaMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Medico";
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            this.pnBusca.ResumeLayout(false);
            this.pnBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.Panel pnBusca;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisaCpf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaCrm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisaEspecialidade;
    }
}