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
    public partial class FrmPrincipal : Form
    {
        private FrmInicio FrmInicio = null;
        private FrmConvenio FrmConvenio = null;
        private FrmMedico FrmMedico = null;
        private FrmPaciente FrmPaciente = null;
        private FrmMaterial FrmMaterial = null;
        private FrmAgendamento FrmAgendamento = null;
        private FrmFaturamento FrmFaturamento = null;
        private FrmEspecialidade FrmEspecialidade = null;
        private FrmAtendimento FrmAtendimento = null;

        public FrmPrincipal()
        {
            InitializeComponent();
            InitializeTabPages();
        }

        private void InitializeTabPages()
        {
            int index = 0;

            #region Tab Inicio

            FrmInicio = new FrmInicio();
            FrmInicio.TopLevel = false;
            FrmInicio.Visible = true;
            FrmInicio.Dock = DockStyle.None;
            index = tcFormularios.TabPages.IndexOf(tpInicio);
            tcFormularios.TabPages[index].Controls.Add(FrmInicio);

            #endregion

            #region Tab Convenio

            FrmConvenio = new FrmConvenio();
            FrmConvenio.TopLevel = false;
            FrmConvenio.Visible = true;
            FrmConvenio.Dock = DockStyle.None;
            index = tcFormularios.TabPages.IndexOf(tpConvenio);
            tcFormularios.TabPages[index].Controls.Add(FrmConvenio);

            #endregion

            #region Tab Medico

            FrmMedico = new FrmMedico();
            FrmMedico.TopLevel = false;
            FrmMedico.Visible = true;
            FrmMedico.Dock = DockStyle.None;
            index = tcFormularios.TabPages.IndexOf(tpMedico);
            tcFormularios.TabPages[index].Controls.Add(FrmMedico);

            #endregion

            #region Tab Paciente

            FrmPaciente = new FrmPaciente();
            FrmPaciente.TopLevel = false;
            FrmPaciente.Visible = true;
            FrmPaciente.Dock = DockStyle.None;
            index = tcFormularios.TabPages.IndexOf(tpPaciente);
            tcFormularios.TabPages[index].Controls.Add(FrmPaciente);

            #endregion

            #region Tab Material

            FrmMaterial = new FrmMaterial();
            FrmMaterial.TopLevel = false;
            FrmMaterial.Visible = true;
            FrmMaterial.Dock = DockStyle.None;
            index = tcFormularios.TabPages.IndexOf(tpMaterial);
            tcFormularios.TabPages[index].Controls.Add(FrmMaterial);

            #endregion

            #region Tab Agendamento

            FrmAgendamento = new FrmAgendamento();
            FrmAgendamento.TopLevel = false;
            FrmAgendamento.Visible = true;
            FrmAgendamento.Dock = DockStyle.None;
            index = tcFormularios.TabPages.IndexOf(tpAgendamento);
            tcFormularios.TabPages[index].Controls.Add(FrmAgendamento);

            #endregion

            #region Tab Atendimento

            FrmAtendimento = new FrmAtendimento();
            FrmAtendimento.TopLevel = false;
            FrmAtendimento.Visible = true;
            FrmAtendimento.Dock = DockStyle.None;
            index = tcFormularios.TabPages.IndexOf(tpAtendimento);
            tcFormularios.TabPages[index].Controls.Add(FrmAtendimento);

            #endregion

            #region Tab Especialidade

            FrmEspecialidade = new FrmEspecialidade();
            FrmEspecialidade.TopLevel = false;
            FrmEspecialidade.Visible = true;
            FrmEspecialidade.Dock = DockStyle.None;
            index = tcFormularios.TabPages.IndexOf(tpEspecialidade);
            tcFormularios.TabPages[index].Controls.Add(FrmEspecialidade);

            #endregion

            #region Tab Faturamento

            FrmFaturamento = new FrmFaturamento();
            FrmFaturamento.TopLevel = false;
            FrmFaturamento.Visible = true;
            FrmFaturamento.Dock = DockStyle.None;
            index = tcFormularios.TabPages.IndexOf(tpFaturamento);
            tcFormularios.TabPages[index].Controls.Add(FrmFaturamento);

            #endregion
        }

        private void tcFormularios_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabPage = tcFormularios.SelectedTab;

            if (tabPage == tpInicio)
            {
                FrmInicio.timerRelogio.Start();
                FrmInicio.lbHorario.Text = DateTime.Now.ToString("HH:mm:ss");
                FrmInicio.lbData.Text = DateTime.Now.ToLongDateString();
            }
            else
            {
                FrmInicio.timerRelogio.Stop();

                if (tabPage == tpPaciente)
                {
                    FrmPaciente.lstPacientes = FrmPaciente.PacienteDao.Select(null);
                    FrmPaciente.dgResultado.DataSource = null;
                    FrmPaciente.dgResultado.DataSource = FrmPaciente.lstPacientes;
                }
            }
        }
    }
}