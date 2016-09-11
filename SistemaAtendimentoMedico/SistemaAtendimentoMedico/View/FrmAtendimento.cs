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
        private List<AtendimentoMaterial> lstMateriaisUtilizados = null;
        public AtendimentoDao AtendimentoDao = null;
        public AtendimentoMaterialDao AtendimentoMaterialDao = null;
        private int IDAtend = 0;

        public FrmAtendimento()
        {
            InitializeComponent();
            AtendimentoDao = new AtendimentoDao();
            AtendimentoMaterialDao = new AtendimentoMaterialDao();
        }

        private void visibilityMainButtons(bool visible)
        {
            tbAlterar.Visible = visible;
            btnAdicionar.Visible = !visible;
            btnRemover.Visible = !visible;
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
            lbMateriaisUtilizados.Items.Clear();
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

            IDAtend = Atendimento.ID;
            visibilityMainButtons(false);
            enableSearchComponents(false);
            tbSalvar.Visible = true;
            tbCancelar.Visible = true;
            Util.EnableAllControls(this, true);
            txtCpfPaciente.Enabled = false;
            txtNomePaciente.Enabled = false;
            lstMateriaisUtilizados = new List<AtendimentoMaterial>(Atendimento.lstAtendimentoMaterial);
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
                int index = Util.lstAtendimentos.IndexOf(Atendimento);
                validationInsertUpdate(Atendimento);

                dgResultado.DataSource = null;
                Util.lstAtendimentos.RemoveAt(index);
                AtendimentoDao.Update(Atendimento);

                insertUpdateDeleteAtendimentoMaterial();

                Atendimento.ID = Atendimento.ID;
                Util.lstAtendimentos.Add(Atendimento);
                Util.lstAtendimentos = Util.lstAtendimentos.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Atendimento alterado com sucesso", "Atendimento");

                dgResultado.DataSource = Util.lstAtendimentos;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertUpdateDeleteAtendimentoMaterial()
        {
            foreach (var item in lstMateriaisUtilizados)
            {
                if (item.Quantidade <= 0)
                {
                    if (item.Novo == AtendimentoMaterial.eNovo.nao)
                        AtendimentoMaterialDao.Delete(item.ID.ToString());
                }
                else if (item.Novo == AtendimentoMaterial.eNovo.sim)
                    AtendimentoMaterialDao.Insert(item);
                else
                    AtendimentoMaterialDao.Update(item);
            }
        }

        private void onlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                if (e.KeyChar == ',')
                {
                    if (((TextBox)sender).Text.Contains(","))
                        e.Handled = true;
                }
                else
                    e.Handled = true;
        }

        private void dgResultado_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgResultado.CurrentRow == null)
                {
                    Util.ClearAllControls(this);
                    lbMateriaisUtilizados.Items.Clear();
                    return;
                }

                var Atendimento = dgResultado.CurrentRow.DataBoundItem as Atendimento;
                if (Atendimento == null) return;

                txtCpfPaciente.Text = Atendimento.CpfPaciente;
                txtNomePaciente.Text = Atendimento.NomePaciente;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = Util.lstAtendimentos.Where(x =>
                x.NomePaciente.Contains(txtPesquisaNome.Text.Trim()) &&
                x.CpfPaciente.Contains(txtPesquisaCpf.Text.Trim())).ToList();
        }

        private void dgResultado_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgResultado.DataSource != null && dgResultado.Columns.Count > 0)
                dgResultado.Columns[0].Visible = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            addRemoveMaterial('+');
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            addRemoveMaterial('-');
        }

        private void addRemoveMaterial(char operation)
        {
            try
            {
                double qtd = txtQtdeMaterial.Text.ValidarDecimal();
                if (qtd <= 0) throw new Exception("Digite um número maior que 0 (zero)");

                switch (operation)
                {
                    case '+':
                        if (lbTodosMateriais.SelectedItem == null)
                            throw new Exception("Selecione um item da lista esquerda");

                         Material material = lbTodosMateriais.SelectedItem as Material;
                        if (material == null) return;
                        var materialUtilizado = lstMateriaisUtilizados.FirstOrDefault(
                            x => x.IDMaterial == material.ID);
                        if (materialUtilizado != null)
                            materialUtilizado.Quantidade += qtd;
                        else
                            lstMateriaisUtilizados.Add(new AtendimentoMaterial(IDAtend, material.ID, qtd));
                        break;
                    case '-':
                        if (lbMateriaisUtilizados.SelectedItem == null)
                            throw new Exception("Selecione um item da lista direita");
                        AtendimentoMaterial atendMaterial = lbMateriaisUtilizados.SelectedItem as AtendimentoMaterial;
                        if (atendMaterial == null) return;
                        var materialRemover = lstMateriaisUtilizados.FirstOrDefault(
                            x => x.IDMaterial == atendMaterial.IDMaterial);
                        if (materialRemover != null)
                        {
                            materialRemover.Quantidade -= qtd;
                            if (materialRemover.Quantidade < 0)
                                materialRemover.Quantidade = 0;
                        }
                        break;
                }

                lbMateriaisUtilizados.Items.Clear();
                foreach (var item in lstMateriaisUtilizados)
                    if (item.Quantidade != 0)
                        lbMateriaisUtilizados.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProntuarios_Click(object sender, EventArgs e)
        {
            try
            {
                Atendimento Atendimento = null;
                if (dgResultado.CurrentRow == null ||
                    (Atendimento = dgResultado.CurrentRow.DataBoundItem as Atendimento) == null)
                {
                    MessageBox.Show(this, "Selecione um Atendimento na lista para visualizar " +
                        "os prontuários dos paciente.", "Atendimento",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                FrmProntuarios FrmProntuarios = 
                    new FrmProntuarios(Atendimento.Agendamento.IDPaciente);
                FrmProntuarios.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}