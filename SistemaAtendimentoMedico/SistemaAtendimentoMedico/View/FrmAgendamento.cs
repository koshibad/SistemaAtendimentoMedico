using SistemaAtendimentoMedico.Data;
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
    public partial class FrmAgendamento : Form
    {
        public List<Agendamento> lstAgendamentos = null;
        public AgendamentoDao AgendamentoDao = null;
        private Paciente pacienteSelecionado = null;
        private Medico medicoSelecionado = null;

        public FrmAgendamento()
        {
            InitializeComponent();

            cbTipoConsulta.DataSource = null;
            cbTipoConsulta.DataSource = setComboBoxEnumString().ToList();
            cbTipoConsulta.SelectedIndex = -1;
            AgendamentoDao = new AgendamentoDao();
        }

        private IEnumerable<string> setComboBoxEnumString()
        {
            foreach (var item in Enum.GetNames(typeof(Agendamento.eTipoConsulta)))
                yield return item.ToString();
        }

        private void visibilityMainButtons(bool visible)
        {
            tbNovo.Visible = visible;
            tbAlterar.Visible = visible;
            tbExcluir.Visible = visible;
        }

        private void enableSearchComponents(bool enabled)
        {
            pnBusca.Enabled = enabled;
            dgResultado.Enabled = enabled;

            pnPesquisaPessoas.Enabled = !enabled;
            pnPesquisaPessoas.Visible = !enabled;
        }

        public void formOnEndTask()
        {
            visibilityMainButtons(true);
            enableSearchComponents(true);
            tbInserir.Visible = false;
            tbSalvar.Visible = false;
            tbCancelar.Visible = false;
            EnableComponentsEditables(false);
            dtpData.MinDate = DateTimePicker.MinimumDateTime;
        }

        private void EnableComponentsEditables(bool enabled)
        {
            dtpData.Enabled = enabled;
            cbHorario.Enabled = enabled;
            cbTipoConsulta.Enabled = enabled;
            cbConvenio.Enabled = enabled;
        }

        private void tbNovo_Click(object sender, System.EventArgs e)
        {
            visibilityMainButtons(false);
            enableSearchComponents(false);
            tbInserir.Visible = true;
            tbCancelar.Visible = true;
            Util.ClearAllControls(this);
            EnableComponentsEditables(true);
            pacienteSelecionado = null;
            medicoSelecionado = null;
            dtpData.MinDate = DateTime.Now;
        }

        private void tbAlterar_Click(object sender, System.EventArgs e)
        {
            Agendamento Agendamento = null;
            if (dgResultado.CurrentRow == null ||
                (Agendamento = dgResultado.CurrentRow.DataBoundItem as Agendamento) == null)
            {
                MessageBox.Show(this, "Selecione um Agendamento na lista para editá-lo.", "Agendamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            visibilityMainButtons(false);
            enableSearchComponents(false);
            tbSalvar.Visible = true;
            tbCancelar.Visible = true;
            EnableComponentsEditables(true);
        }

        private void tbCancelar_Click(object sender, System.EventArgs e)
        {
            formOnEndTask();
            dgResultado_CurrentCellChanged(null, null);
        }

        private void tbExcluir_Click(object sender, System.EventArgs e)
        {
            //TODO: verficar se existe consulta associado
            Agendamento Agendamento = null;
            if (dgResultado.CurrentRow == null ||
                (Agendamento = dgResultado.CurrentRow.DataBoundItem as Agendamento) == null)
            {
                MessageBox.Show(this, "Selecione um Agendamento na lista para excluí-lo.", "Agendamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                dgResultado.DataSource = null;
                int index = lstAgendamentos.IndexOf(Agendamento);
                lstAgendamentos.RemoveAt(index);
                AgendamentoDao.Delete(Agendamento.ID.ToString());

                MessageBox.Show(this, "Agendamento excluido com sucesso", "Agendamento");

                dgResultado.DataSource = lstAgendamentos;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validationInsertUpdate(Agendamento Agendamento)
        {
            try
            {
                if (pacienteSelecionado == null)
                    throw new Exception("Selecione um paciente");
                if (medicoSelecionado == null)
                    throw new Exception("Selecione um medico");

                Agendamento.IDPaciente = pacienteSelecionado.ID;
                Agendamento.IDMedico = medicoSelecionado.ID;

                Agendamento.DataConsulta = dtpData.Value.Date;
                var dt = Convert.ToDateTime(cbHorario.SelectedValue);
                var time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
                Agendamento.DataConsulta += time;

                if (cbTipoConsulta.SelectedIndex < 0) throw new Exception("Selecione um Tipo de Consulta");
                Agendamento.IDTipoConsulta = cbTipoConsulta.SelectedIndex;
                Agendamento.IDConvenio = 0;
                if (cbConvenio.Visible)
                    Agendamento.IDConvenio = cbConvenio.ValidarItemSelecionado("Convenio");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void tbInserir_Click(object sender, System.EventArgs e)
        {
            try
            {
                var Agendamento = new Agendamento();
                validationInsertUpdate(Agendamento);

                if (AgendamentoDao.Select(new List<Tuple<string, object, string>>() {
                    new Tuple<string, object, string>("IDMedico", Agendamento.IDMedico, "="),
                    new Tuple<string, object, string>("DataConsulta", Agendamento.DataConsulta, "=")
                    }).Count > 0)
                    throw new Exception("Já existe Agendamento no horario informado com o Medico selecionado");

                AgendamentoDao.Insert(Agendamento);

                MessageBox.Show(this, "Agendamento incluido com sucesso", "Agendamento");

                lstAgendamentos = AgendamentoDao.Select(null);
                dgResultado.DataSource = null;
                dgResultado.DataSource = lstAgendamentos;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSalvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                var Agendamento = (Agendamento)dgResultado.CurrentRow.DataBoundItem;
                int index = lstAgendamentos.IndexOf(Agendamento);
                validationInsertUpdate(Agendamento);

                if (AgendamentoDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("IDMedico", Agendamento.IDMedico, "="),
                    new Tuple<string, object, string>("DataConsulta", Agendamento.DataConsulta, "="),
                    new Tuple<string, object, string>("ID",Agendamento.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Agendamento no horario informado com o Medico selecionado");

                dgResultado.DataSource = null;
                lstAgendamentos.RemoveAt(index);
                AgendamentoDao.Update(Agendamento);
                lstAgendamentos.Add(Agendamento);
                lstAgendamentos = lstAgendamentos.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Agendamento alterado com sucesso", "Agendamento");

                dgResultado.DataSource = lstAgendamentos;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
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

                var Agendamento = dgResultado.CurrentRow.DataBoundItem as Agendamento;
                if (Agendamento == null) return;

                pacienteSelecionado = Agendamento.Paciente;
                txtCpfPaciente.Text = Agendamento.Paciente.CPF;
                txtNomePaciente.Text = Agendamento.NomePaciente;
                medicoSelecionado = Agendamento.Medico;
                txtCrmMedico.Text = Agendamento.Medico.CRM;
                txtEspecialidadeMedico.Text = Agendamento.Medico.Especialidade.Nome;
                txtNomeMedico.Text = Agendamento.NomeMedico;
                mostrarHorarioConsulta(Agendamento.DataConsulta);
                cbTipoConsulta.SelectedIndex = Agendamento.IDTipoConsulta;
                cbConvenio.SelectedValue = Agendamento.IDConvenio;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarHorarioConsulta(DateTime dataConsulta)
        {
            dtpData.Value = dataConsulta;
            cbHorario.DataSource = null;
            cbHorario.DataSource = Util.TimeSpanFromMinutes(medicoSelecionado
                .Especialidade.TempoConsulta).ToList();
            cbHorario.SelectedItem = dataConsulta.ToString("HH:mm");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = lstAgendamentos.Where(x =>
                x.NomePaciente.Contains(txtPesquisaNome.Text.Trim()) &&
                x.Paciente.CPF.Contains(txtPesquisaCpf.Text.Trim())).ToList();
        }

        private void dgResultado_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgResultado.DataSource != null && dgResultado.Columns.Count > 0)
                dgResultado.Columns[0].Visible = false;
        }

        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            FrmPesquisaPaciente FrmPesquisaPaciente = new FrmPesquisaPaciente();
            FrmPesquisaPaciente.ShowDialog();
            pacienteSelecionado = FrmPesquisaPaciente.paciente;
            if (pacienteSelecionado != null)
            {
                txtCpfPaciente.Text = pacienteSelecionado.CPF;
                txtNomePaciente.Text = pacienteSelecionado.Nome;
            }
        }

        private void btnPesquisarMedico_Click(object sender, EventArgs e)
        {
            FrmPesquisaMedico FrmPesquisaMedico = new FrmPesquisaMedico();
            FrmPesquisaMedico.ShowDialog();
            medicoSelecionado = FrmPesquisaMedico.Medico;
            if (medicoSelecionado != null)
            {
                txtCrmMedico.Text = medicoSelecionado.CRM;
                txtEspecialidadeMedico.Text = medicoSelecionado.NomeEspecialidade;
                txtNomeMedico.Text = medicoSelecionado.Nome;
                cbHorario.DataSource = null;
                cbHorario.DataSource = Util.TimeSpanFromMinutes(medicoSelecionado
                    .Especialidade.TempoConsulta).ToList();
            }
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
