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
    public partial class FrmEspecialidade : Form
    {
        public EspecialidadeDao EspecialidadeDao = null;

        public FrmEspecialidade()
        {
            InitializeComponent();
            cbTempoConsulta.DataSource = new List<int>() { 15, 30, 60 };
            EspecialidadeDao = new EspecialidadeDao();
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
        }

        public void formOnEndTask()
        {
            visibilityMainButtons(true);
            enableSearchComponents(true);
            tbInserir.Visible = false;
            tbSalvar.Visible = false;
            tbCancelar.Visible = false;
            Util.EnableAllControls(this, false);
        }

        private void tbNovo_Click(object sender, System.EventArgs e)
        {
            visibilityMainButtons(false);
            enableSearchComponents(false);
            tbInserir.Visible = true;
            tbCancelar.Visible = true;
            Util.ClearAllControls(this);
            Util.EnableAllControls(this, true);
        }

        private void tbAlterar_Click(object sender, System.EventArgs e)
        {
            Especialidade Especialidade = null;
            if (dgResultado.CurrentRow == null ||
                (Especialidade = dgResultado.CurrentRow.DataBoundItem as Especialidade) == null)
            {
                MessageBox.Show(this, "Selecione um Especialidade na lista para editá-lo.", "Especialidade",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            visibilityMainButtons(false);
            enableSearchComponents(false);
            tbSalvar.Visible = true;
            tbCancelar.Visible = true;
            Util.EnableAllControls(this, true);
        }

        private void tbCancelar_Click(object sender, System.EventArgs e)
        {
            formOnEndTask();
            dgResultado_CurrentCellChanged(null, null);
        }

        private void tbExcluir_Click(object sender, System.EventArgs e)
        {
            //TODO: verficar se existe consulta associado
            Especialidade Especialidade = null;
            if (dgResultado.CurrentRow == null ||
                (Especialidade = dgResultado.CurrentRow.DataBoundItem as Especialidade) == null)
            {
                MessageBox.Show(this, "Selecione um Especialidade na lista para excluí-lo.", "Especialidade",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                dgResultado.DataSource = null;
                int index = Util.lstEspecialidades.IndexOf(Especialidade);
                Util.lstEspecialidades.RemoveAt(index);
                EspecialidadeDao.Delete(Especialidade.ID.ToString());

                MessageBox.Show(this, "Especialidade incluido com sucesso", "Especialidade");

                dgResultado.DataSource = Util.lstEspecialidades;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validationInsertUpdate(Especialidade Especialidade)
        {
            try
            {
                Especialidade.Nome = txtNome.Text.ValidarTextoVazio("Nome");
                Especialidade.ValorConsulta = txtValorConsulta.Text.ValidarDecimal();
                Especialidade.RemuneracaoConvenio = txtRemuneracaoConvenio.Text.ValidarPorcentagemDecimal();
                Especialidade.RemuneracaoParticular = txtRemuneracaoParticular.Text.ValidarPorcentagemDecimal();
                Especialidade.TempoConsulta = cbTempoConsulta.ValidarItemSelecionado("Tempo de Consulta");
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
                var Especialidade = new Especialidade();
                validationInsertUpdate(Especialidade);

                if (EspecialidadeDao.Select(new List<Tuple<string, object, string>>()
                    { new Tuple<string, object, string>("Nome", Especialidade.Nome, "=") }).Count > 0)
                    throw new Exception("Já existe Especialidade com o Nome informado");

                EspecialidadeDao.Insert(Especialidade);
                Util.lstEspecialidades = EspecialidadeDao.Select(null);

                MessageBox.Show(this, "Especialidade incluida com sucesso", "Especialidade");

                dgResultado.DataSource = null;
                dgResultado.DataSource = Util.lstEspecialidades;
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
                var Especialidade = (Especialidade)dgResultado.CurrentRow.DataBoundItem;
                int index = Util.lstEspecialidades.IndexOf(Especialidade);
                validationInsertUpdate(Especialidade);

                if (EspecialidadeDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("Nome", Especialidade.Nome, "="),
                    new Tuple<string, object, string>("ID",Especialidade.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Especialidade com o Nome informado");

                Util.lstEspecialidades.RemoveAt(index);
                EspecialidadeDao.Update(Especialidade);
                Util.lstEspecialidades.Add(Especialidade);
                Util.lstEspecialidades = Util.lstEspecialidades.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Especialidade alterada com sucesso", "Especialidade");

                dgResultado.DataSource = null;
                dgResultado.DataSource = Util.lstEspecialidades;
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

                var Especialidade = dgResultado.CurrentRow.DataBoundItem as Especialidade;
                if (Especialidade == null) return;

                txtNome.Text = Especialidade.Nome;
                txtValorConsulta.Text = Especialidade.ValorConsulta.ToString();
                txtRemuneracaoConvenio.Text = Especialidade.RemuneracaoConvenio.ToString();
                txtRemuneracaoParticular.Text = Especialidade.RemuneracaoParticular.ToString();
                cbTempoConsulta.SelectedItem = Especialidade.TempoConsulta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = Util.lstEspecialidades.Where(x =>
                x.Nome.Contains(txtPesquisaNome.Text.Trim())).ToList();
        }

        private void dgResultado_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgResultado.DataSource != null && dgResultado.Columns.Count > 0)
                dgResultado.Columns[0].Visible = false;
        }
    }
}