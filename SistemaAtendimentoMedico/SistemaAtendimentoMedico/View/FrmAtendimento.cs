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
    public partial class FrmAtendimento : Form
    {
        public List<Atendimento> lstAtendimentos = null;
        public AtendimentoDao AtendimentoDao = null;

        public FrmAtendimento()
        {
            InitializeComponent();
            AtendimentoDao = new AtendimentoDao();
        }

        private void visibilityMainButtons(bool visible)
        {
            tbAlterar.Visible = visible;
            btnAdicionar.Visible = !visible;
            btnRemover.Visible = !visible;
            btnProntuarios.Visible = !visible;
            txtQtdeMaterial.Visible = !visible;
            lblQtde.Visible = !visible;
            lbTodosMateriais.Visible = !visible;
            lblMateriais.Visible = !visible;
        }

        private void enableSearchComponents(bool enabled)
        {
            pnBusca.Enabled = enabled;
            dgResultado.Enabled = enabled;
            lbMateriaisUtilizados.Enabled = !enabled;
        }

        public void formOnEndTask()
        {
            visibilityMainButtons(true);
            enableSearchComponents(true);
            tbSalvar.Visible = false;
            tbCancelar.Visible = false;
            Util.EnableAllControls(this, false);
        }

        private void tbAlterar_Click(object sender, System.EventArgs e)
        {
            Atendimento Atendimento = null;
            if (dgResultado.CurrentRow == null ||
                (Atendimento = dgResultado.CurrentRow.DataBoundItem as Atendimento) == null)
            {
                MessageBox.Show(this, "Selecione um Atendimento na lista para editá-lo.", "Atendimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            visibilityMainButtons(false);
            enableSearchComponents(false);
            tbSalvar.Visible = true;
            tbCancelar.Visible = true;
            Util.EnableAllControls(this, true);
            txtCpfPaciente.Enabled = false;
            txtNomePaciente.Enabled = false;
        }

        private void tbCancelar_Click(object sender, System.EventArgs e)
        {
            formOnEndTask();
            dgResultado_CurrentCellChanged(null, null);
        }

        private void validationInsertUpdate(Atendimento Atendimento)
        {
            try
            {
                Atendimento.Tratamento = txtTratamento.Text;
                Atendimento.DataFinalizacaoAtendimento = DateTime.Now;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void tbSalvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                var Atendimento = (Atendimento)dgResultado.CurrentRow.DataBoundItem;
                int index = lstAtendimentos.IndexOf(Atendimento);
                validationInsertUpdate(Atendimento);

                dgResultado.DataSource = null;
                lstAtendimentos.RemoveAt(index);
                AtendimentoDao.Update(Atendimento);
                lstAtendimentos.Add(Atendimento);
                lstAtendimentos = lstAtendimentos.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Atendimento alterado com sucesso", "Atendimento");

                dgResultado.DataSource = lstAtendimentos;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) &&
              (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(",")))
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

                var Atendimento = dgResultado.CurrentRow.DataBoundItem as Atendimento;
                if (Atendimento == null) return;

                txtCpfPaciente.Text = Atendimento.CpfPaciente;
                txtNomePaciente.Text = Atendimento.NomePaciente;
                txtTratamento.Text = Atendimento.Tratamento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = lstAtendimentos.Where(x =>
                x.NomePaciente.Contains(txtPesquisaNome.Text.Trim()) &&
                x.CpfPaciente.Contains(txtPesquisaCpf.Text.Trim())).ToList();
        }

        private void dgResultado_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgResultado.DataSource != null && dgResultado.Columns.Count > 0)
                dgResultado.Columns[0].Visible = false;
        }
    }
}
