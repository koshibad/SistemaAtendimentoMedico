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
    public partial class FrmProntuarios : Form
    {
        public FrmProntuarios()
        {
            InitializeComponent();
        }

        public FrmProntuarios(int IDPaciente) : this()
        {
            cbTipoConsulta.DataSource = null;
            cbTipoConsulta.DataSource = setComboBoxEnumString().ToList();

            dgResultado.DataSource = null;
            dgResultado.DataSource = Util.lstAtendimentos.Where(
                x => x.Agendamento.IDPaciente == IDPaciente).ToList();
        }

        private IEnumerable<string> setComboBoxEnumString()
        {
            foreach (var item in Enum.GetNames(typeof(Agendamento.eTipoConsulta)))
                yield return item.ToString();
        }

        private void dgResultado_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgResultado.CurrentRow == null)
                {
                    Util.ClearAllControls(this);
                    return;
                }

                var Atendimento = dgResultado.CurrentRow.DataBoundItem as Atendimento;
                if (Atendimento == null) return;

                txtCpfPaciente.Text = Atendimento.Agendamento.Paciente.CPF;
                txtNomePaciente.Text = Atendimento.NomePaciente;
                txtCrmMedico.Text = Atendimento.Agendamento.Medico.CRM;
                txtEspecialidadeMedico.Text = Atendimento.Agendamento.Medico.Especialidade.Nome;
                txtNomeMedico.Text = Atendimento.NomeMedico;
                mostrarHorarioConsulta(Atendimento.DataConsulta, Atendimento.Agendamento.Medico);
                cbTipoConsulta.SelectedIndex = Atendimento.Agendamento.IDTipoConsulta;
                cbConvenio.SelectedValue = Atendimento.Agendamento.IDConvenio;
                txtTratamento.Text = Atendimento.Tratamento;

                lbMateriaisUtilizados.Items.Clear();
                foreach (var item in Atendimento.lstAtendimentoMaterial)
                    lbMateriaisUtilizados.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarHorarioConsulta(DateTime dataConsulta, Medico medicoSelecionado)
        {
            dtpData.Value = dataConsulta;
            cbHorario.DataSource = null;
            cbHorario.DataSource = Util.TimeSpanFromMinutes(medicoSelecionado
                .Especialidade.TempoConsulta).ToList();
            cbHorario.SelectedItem = dataConsulta.ToString("HH:mm");
        }

        private void dgResultado_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgResultado.DataSource != null && dgResultado.Columns.Count > 0)
                dgResultado.Columns[0].Visible = false;
        }

        private void cbTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbTipoConsulta.SelectedIndex;
            if (index < 0) return;
            cbConvenio.DataSource = null;

            if (index == (int)Agendamento.eTipoConsulta.Particular)
                lbConvenio.Visible = cbConvenio.Visible = false;
            else
            {
                lbConvenio.Visible = cbConvenio.Visible = true;
                Util.SetComboBox(cbConvenio, Util.lstConvenios, "NomeFantasia");
            }
        }
    }
}
