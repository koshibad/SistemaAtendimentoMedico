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
    public partial class FrmPesquisaPaciente : Form
    {
        public Paciente paciente = null;

        public FrmPesquisaPaciente()
        {
            InitializeComponent();

            dgResultado.DataSource = null;
            dgResultado.DataSource = Util.lstPacientes;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = Util.lstPacientes.Where(x =>
                x.Nome.Contains(txtPesquisaNome.Text.Trim()) &&
                x.CPF.Contains(txtPesquisaCpf.Text.Trim())).ToList();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgResultado.CurrentRow == null ||
                (paciente = dgResultado.CurrentRow.DataBoundItem as Paciente) == null)
            {
                MessageBox.Show(this, "Selecione um paciente na lista.", "Paciente",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            Close();
        }
    }
}
