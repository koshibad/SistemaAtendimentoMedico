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
        public List<Material> lstMaterials = null;
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
            Util.EnableAllTextBox(this, false);
        }

        private void tbNovo_Click(object sender, System.EventArgs e)
        {
            visibilityMainButtons(false);
            enableSearchComponents(false);
            tbInserir.Visible = true;
            tbCancelar.Visible = true;
            Util.ClearAllTextBox(this);
            Util.EnableAllTextBox(this, true);
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
            Util.EnableAllTextBox(this, true);
        }

        private void tbCancelar_Click(object sender, System.EventArgs e)
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
                int index = lstMaterials.IndexOf(Material);
                lstMaterials.RemoveAt(index);
                MaterialDao.Delete(Material.ID.ToString());

                MessageBox.Show(this, "Material incluido com sucesso", "Material");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstMaterials;
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
                Material.CPF = txtCpf.Text.ValidarTextoVazio("CPF");
                Material.Nome = txtNome.Text.ValidarTextoVazio("Nome");
                Material.UF = txtUF.Text.ValidarTextoVazio("UF");
                Material.Municipio = txtMunicipio.Text.ValidarTextoVazio("Municipio");
                Material.CEP = txtCep.Text.ValidarNumeros(8, "CEP");
                Material.Logradouro = txtLogradouro.Text.ValidarTextoVazio("Logradouro");
                Material.Numero = txtNumero.Text.ValidarNumero();
                Material.Complemento = txtComplemento.Text;
                Material.Bairro = txtBairro.Text.ValidarTextoVazio("Bairro");
                Material.Telefone = txtTelefone.Text.ValidarNumeros(10, "telefone");
                Material.Celular = txtCelular.Text.ValidarNumeros(10, "celular", false);
                Material.Email = txtEmail.Text.ValidarEmail();
                Material.DataNascimento = txtDataNasc.Text.ValidarData();
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

                if (MaterialDao.Select(new List<Tuple<string, object, string>>()
                    { new Tuple<string, object, string>("CPF", Material.CPF, "=") }).Count > 0)
                    throw new Exception("Já existe Material com o CPF informado");

                MaterialDao.Insert(Material);
                lstMaterials.Add(Material);

                MessageBox.Show(this, "Material incluido com sucesso", "Material");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstMaterials;
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
                var Material = (Material)dgResultado.CurrentRow.DataBoundItem;
                int index = lstMaterials.IndexOf(Material);
                validationInsertUpdate(Material);

                if (MaterialDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("CPF", Material.CPF, "="),
                    new Tuple<string, object, string>("ID",Material.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Material com o CPF informado");

                lstMaterials.RemoveAt(index);
                MaterialDao.Update(Material);
                lstMaterials.Add(Material);
                lstMaterials = lstMaterials.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Material incluido com sucesso", "Material");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstMaterials;
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgResultado_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgResultado.CurrentRow == null)
                {
                    Util.ClearAllTextBox(this);
                    return;
                }

                var Material = dgResultado.CurrentRow.DataBoundItem as Material;
                if (Material == null) return;

                txtCpf.Text = Material.CPF;
                txtNome.Text = Material.Nome;
                txtLogradouro.Text = Material.Logradouro;
                txtUF.Text = Material.UF;
                txtMunicipio.Text = Material.Municipio;
                txtNumero.Text = Material.Numero.ToString();
                txtCep.Text = Material.CEP;
                txtComplemento.Text = Material.Complemento;
                txtBairro.Text = Material.Bairro;
                txtTelefone.Text = Material.Telefone;
                txtCelular.Text = Material.Celular;
                txtEmail.Text = Material.Email;
                txtDataNasc.Text = Material.DataNascimento.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = lstMaterials.Where(x =>
                x.Nome.Contains(txtPesquisaNome.Text.Trim()) &&
                x.CPF.Contains(txtPesquisaCpf.Text.Trim())).ToList();
        }

        private void dgResultado_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgResultado.DataSource != null && dgResultado.Columns.Count > 0)
                dgResultado.Columns[0].Visible = false;
        }
    }
}