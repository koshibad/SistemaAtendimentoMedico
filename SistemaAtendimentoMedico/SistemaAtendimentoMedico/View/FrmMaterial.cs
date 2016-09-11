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
    public partial class FrmMaterial : Form
    {
        public List<Finalidade> lstFinalidades = null;
        public MaterialDao MaterialDao = null;

        public FrmMaterial()
        {
            InitializeComponent();
            MaterialDao = new MaterialDao();
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

        private void formOnEndTask()
        {
            visibilityMainButtons(true);
            enableSearchComponents(true);
            tbInserir.Visible = false;
            tbSalvar.Visible = false;
            tbCancelar.Visible = false;
            Util.EnableAllControls(this, false);
            Util.SetComboBox(cbFinalidade, lstFinalidades);
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
            Material Material = null;
            if (dgResultado.CurrentRow == null ||
                (Material = dgResultado.CurrentRow.DataBoundItem as Material) == null)
            {
                MessageBox.Show(this, "Selecione um Material na lista para editá-lo.", "Material",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            visibilityMainButtons(false);
            enableSearchComponents(false);
            tbSalvar.Visible = true;
            tbCancelar.Visible = true;
            Util.EnableAllControls(this, true);
        }

        public void tbCancelar_Click(object sender, System.EventArgs e)
        {
            formOnEndTask();
            dgResultado_CurrentCellChanged(null, null);
        }

        private void tbExcluir_Click(object sender, System.EventArgs e)
        {
            //TODO: verficar se existe consulta associado
            Material Material = null;
            if (dgResultado.CurrentRow == null ||
                (Material = dgResultado.CurrentRow.DataBoundItem as Material) == null)
            {
                MessageBox.Show(this, "Selecione um Material na lista para excluí-lo.", "Material",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                int index = Util.lstMateriais.IndexOf(Material);
                MaterialDao.Delete(Material.ID.ToString());

                MessageBox.Show(this, "Material excluido com sucesso", "Material");

                dgResultado.DataSource = null;
                Util.lstMateriais.RemoveAt(index);
                dgResultado.DataSource = Util.lstMateriais;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validationInsertUpdate(Material Material)
        {
            try
            {
                Material.Nome = txtNome.Text.ValidarTextoVazio("Nome");
                Material.IDCategoria = cbCategoria.ValidarItemSelecionado("Categoria");
                Material.IDFinalidade = cbFinalidade.ValidarItemSelecionado("Finalidade");
                Material.IDFabricante = cbFabricante.ValidarItemSelecionado("Fabricante");
                Material.ValorUnitario = txtValorUnit.Text.ValidarDecimal();
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
                var Material = new Material();
                validationInsertUpdate(Material);

                if (MaterialDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("Nome", Material.Nome, "="),
                    new Tuple<string, object, string>("IDFabricante", Material.IDFabricante, "=")
                    }).Count > 0)
                    throw new Exception("Já existe Material com o Nome e Fabricante informado");

                MaterialDao.Insert(Material);
                Util.lstMateriais = MaterialDao.Select(null);

                MessageBox.Show(this, "Material incluido com sucesso", "Material");

                dgResultado.DataSource = null;
                dgResultado.DataSource = Util.lstMateriais;
                tbCancelar_Click(null, null);
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
                var Material = (Material)dgResultado.CurrentRow.DataBoundItem;
                int index = Util.lstMateriais.IndexOf(Material);
                validationInsertUpdate(Material);

                if (MaterialDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("Nome", Material.Nome, "="),
                    new Tuple<string, object, string>("IDFabricante", Material.IDFabricante, "="),
                    new Tuple<string, object, string>("ID",Material.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Material com o Nome e Fabricante informado");

                Util.lstMateriais.RemoveAt(index);
                MaterialDao.Update(Material);
                Util.lstMateriais.Add(Material);
                Util.lstMateriais = Util.lstMateriais.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Material alterado com sucesso", "Material");

                dgResultado.DataSource = null;
                dgResultado.DataSource = Util.lstMateriais;
                tbCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    return;
                }

                var Material = dgResultado.CurrentRow.DataBoundItem as Material;
                if (Material == null) return;

                txtNome.Text = Material.Nome;
                cbCategoria.SelectedValue = Material.IDCategoria;
                cbFinalidade.SelectedValue = Material.IDFinalidade;
                cbFabricante.SelectedValue = Material.IDFabricante;
                txtValorUnit.Text = Material.ValorUnitario.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = Util.lstMateriais.Where(x =>
                x.Nome.Contains(txtPesquisaNome.Text.Trim())).ToList();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria Categoria = null;
            if (cbCategoria.SelectedItem == null ||
                (Categoria = cbCategoria.SelectedItem as Categoria) == null)
                return;

            Util.SetComboBox(cbFinalidade, lstFinalidades
                .Where(x => x.IDCategoria == Categoria.ID).ToList());
        }
    }
}