namespace SistemaAtendimentoMedico.View
{
    partial class FrmConvenio
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
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistroAns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBusca = new System.Windows.Forms.Panel();
            this.txtPesquisaNomeFantasia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesquisaRazaoSocial = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisaCnpj = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgResultado = new System.Windows.Forms.DataGridView();
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
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Enabled = false;
            this.txtNomeFantasia.Location = new System.Drawing.Point(215, 150);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFantasia.MaxLength = 255;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(629, 22);
            this.txtNomeFantasia.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 150);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Nome Fantasia:\t";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Location = new System.Drawing.Point(215, 110);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazaoSocial.MaxLength = 255;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(629, 22);
            this.txtRazaoSocial.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Razão Social:";
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(803, 67);
            this.txtUF.Margin = new System.Windows.Forms.Padding(4);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(41, 22);
            this.txtUF.TabIndex = 2;
            this.txtUF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(765, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "UF:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(215, 193);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 22);
            this.txtTelefone.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(428, 194);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(416, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Email:";
            // 
            // txtRegistroAns
            // 
            this.txtRegistroAns.Enabled = false;
            this.txtRegistroAns.Location = new System.Drawing.Point(537, 66);
            this.txtRegistroAns.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistroAns.MaxLength = 10;
            this.txtRegistroAns.Name = "txtRegistroAns";
            this.txtRegistroAns.Size = new System.Drawing.Size(200, 22);
            this.txtRegistroAns.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Registro ANS:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Location = new System.Drawing.Point(215, 66);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnpj.MaxLength = 14;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(200, 22);
            this.txtCnpj.TabIndex = 0;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "CNPJ:";
            // 
            // pnBusca
            // 
            this.pnBusca.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnBusca.Controls.Add(this.txtPesquisaNomeFantasia);
            this.pnBusca.Controls.Add(this.label4);
            this.pnBusca.Controls.Add(this.txtPesquisaRazaoSocial);
            this.pnBusca.Controls.Add(this.label14);
            this.pnBusca.Controls.Add(this.btnPesquisar);
            this.pnBusca.Controls.Add(this.txtPesquisaCnpj);
            this.pnBusca.Controls.Add(this.label13);
            this.pnBusca.Location = new System.Drawing.Point(215, 278);
            this.pnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.pnBusca.Name = "pnBusca";
            this.pnBusca.Size = new System.Drawing.Size(517, 106);
            this.pnBusca.TabIndex = 57;
            // 
            // txtPesquisaNomeFantasia
            // 
            this.txtPesquisaNomeFantasia.Location = new System.Drawing.Point(133, 75);
            this.txtPesquisaNomeFantasia.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaNomeFantasia.MaxLength = 255;
            this.txtPesquisaNomeFantasia.Name = "txtPesquisaNomeFantasia";
            this.txtPesquisaNomeFantasia.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaNomeFantasia.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nome Fantasia:\t";
            // 
            // txtPesquisaRazaoSocial
            // 
            this.txtPesquisaRazaoSocial.Location = new System.Drawing.Point(133, 42);
            this.txtPesquisaRazaoSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaRazaoSocial.MaxLength = 255;
            this.txtPesquisaRazaoSocial.Name = "txtPesquisaRazaoSocial";
            this.txtPesquisaRazaoSocial.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaRazaoSocial.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 45);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Razão Social:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(381, 30);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 50);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisaCnpj
            // 
            this.txtPesquisaCnpj.Location = new System.Drawing.Point(133, 10);
            this.txtPesquisaCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaCnpj.MaxLength = 11;
            this.txtPesquisaCnpj.Name = "txtPesquisaCnpj";
            this.txtPesquisaCnpj.Size = new System.Drawing.Size(217, 22);
            this.txtPesquisaCnpj.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(79, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "CPNJ:";
            // 
            // dgResultado
            // 
            this.dgResultado.AllowUserToAddRows = false;
            this.dgResultado.AllowUserToDeleteRows = false;
            this.dgResultado.AllowUserToOrderColumns = true;
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
            // FrmConvenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.dgResultado);
            this.Controls.Add(this.pnBusca);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegistroAns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmConvenio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConvenio";
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
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegistroAns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnBusca;
        private System.Windows.Forms.TextBox txtPesquisaRazaoSocial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisaCnpj;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.TextBox txtPesquisaNomeFantasia;
        private System.Windows.Forms.Label label4;
    }
}