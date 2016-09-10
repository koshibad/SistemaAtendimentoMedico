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
            InitializeList();
        }

        private void InitializeList()
        {
            Util.lstPacientes = FrmPaciente.PacienteDao.Select(null);
            Util.lstEspecialidades = FrmEspecialidade.EspecialidadeDao.Select(null);
            Util.lstMedicos = FrmMedico.MedicoDao.Select(null);
        }

        private void InitializeTabPages()
        {
            try
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tcFormularios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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

                    if (tabPage == tpConvenio)
                    {
                        FrmConvenio.lstConvenios = FrmConvenio.ConvenioDao.Select(null);
                        FrmConvenio.dgResultado.DataSource = null;
                        FrmConvenio.dgResultado.DataSource = FrmConvenio.lstConvenios;
                        FrmConvenio.formOnEndTask();
                    }
                    else if (tabPage == tpEspecialidade)
                    {
                        Util.lstEspecialidades = FrmEspecialidade.EspecialidadeDao.Select(null);
                        FrmEspecialidade.dgResultado.DataSource = null;
                        FrmEspecialidade.dgResultado.DataSource = Util.lstEspecialidades;
                        FrmEspecialidade.formOnEndTask();
                    }
                    else if (tabPage == tpMedico)
                    {
                        //TODO: mascara IDEspecialidade
                        Util.lstMedicos = FrmMedico.MedicoDao.Select(null);
                        FrmMedico.dgResultado.DataSource = null;
                        FrmMedico.dgResultado.DataSource = Util.lstMedicos;
                        Util.SetComboBox(FrmMedico.cbEspecialidade, FrmEspecialidade
                            .EspecialidadeDao.Select(null));
                        FrmMedico.formOnEndTask();
                    }
                    else if (tabPage == tpPaciente)
                    {
                        Util.lstPacientes = FrmPaciente.PacienteDao.Select(null);
                        FrmPaciente.dgResultado.DataSource = null;
                        FrmPaciente.dgResultado.DataSource = Util.lstPacientes;
                        FrmPaciente.formOnEndTask();
                    }
                    else if (tabPage == tpMaterial)
                    {
                        //TODO: mascara IDCategoria, IDFinalidade, IDFabricante
                        FrmMaterial.lstMateriais = FrmMaterial.MaterialDao.Select(null);
                        FrmMaterial.dgResultado.DataSource = null;
                        FrmMaterial.dgResultado.DataSource = FrmMaterial.lstMateriais;

                        FrmMaterial.lstFinalidades = FrmMaterial.MaterialDao.SelectFinalidade(null);
                        Util.SetComboBox(FrmMaterial.cbCategoria, FrmMaterial.MaterialDao.SelectCategoria(null));
                        Util.SetComboBox(FrmMaterial.cbFabricante, FrmMaterial.MaterialDao.SelectFabricante(null));
                        FrmMaterial.formOnEndTask();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}