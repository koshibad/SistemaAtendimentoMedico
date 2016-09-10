using SistemaAtendimentoMedico.Model;
using SistemaAtendimentoMedico.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAtendimentoMedico.View
{
    public partial class FrmPesquisaMedico : Form
    {
        public Medico Medico = null;

        public FrmPesquisaMedico()
        {
            InitializeComponent();

            dgResultado.DataSource = null;
            dgResultado.DataSource = Util.lstMedicos;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = Util.lstMedicos.Where(x =>
                x.Nome.Contains(txtPesquisaNome.Text.Trim()) &&
                x.CPF.Contains(txtPesquisaCpf.Text.Trim()) &&
                x.CRM.Contains(txtPesquisaCrm.Text.Trim()) &&
                x.Especialidade.Contains(txtPesquisaEspecialidade.Text.Trim())
                ).ToList();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgResultado.CurrentRow == null ||
                (Medico = dgResultado.CurrentRow.DataBoundItem as Medico) == null)
            {
                MessageBox.Show(this, "Selecione um Medico na lista.", "Medico",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            Close();
        }
    }
}
