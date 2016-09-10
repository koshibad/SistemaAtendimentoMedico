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
    public partial class FrmConvenio : Form
    {
        public List<Convenio> lstConvenios = null;
        public ConvenioDao ConvenioDao = null;

        public FrmConvenio()
        {
            InitializeComponent();
            ConvenioDao = new ConvenioDao();
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
            Convenio Convenio = null;
            if (dgResultado.CurrentRow == null ||
                (Convenio = dgResultado.CurrentRow.DataBoundItem as Convenio) == null)
            {
                MessageBox.Show(this, "Selecione um Convenio na lista para editá-lo.", "Convenio",
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
            Convenio Convenio = null;
            if (dgResultado.CurrentRow == null ||
                (Convenio = dgResultado.CurrentRow.DataBoundItem as Convenio) == null)
            {
                MessageBox.Show(this, "Selecione um Convenio na lista para excluí-lo.", "Convenio",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                dgResultado.DataSource = null;
                int index = lstConvenios.IndexOf(Convenio);
                lstConvenios.RemoveAt(index);
                ConvenioDao.Delete(Convenio.ID.ToString());

                MessageBox.Show(this, "Convenio incluido com sucesso", "Convenio");

                dgResultado.DataSource = lstConvenios;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validationInsertUpdate(Convenio Convenio)
        {
            try
            {
                Convenio.CNPJ = txtCnpj.Text.ValidarTextoVazio("CNPJ");
                Convenio.RegistroANS = Convert.ToInt32(txtRegistroAns.Text.ValidarTextoVazio("Registro ANS"));
                Convenio.UF = txtUF.Text.ValidarTextoVazio("UF");
                Convenio.RazaoSocial = txtRazaoSocial.Text.ValidarTextoVazio("Razão Social");
                Convenio.NomeFantasia = txtNomeFantasia.Text.ValidarTextoVazio("Nome Fantasia");
                Convenio.Telefone = txtTelefone.Text.ValidarNumeros(10, "telefone");
                Convenio.Email = txtEmail.Text.ValidarEmail();
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
                var Convenio = new Convenio();
                validationInsertUpdate(Convenio);

                if (ConvenioDao.Select(new List<Tuple<string, object, string>>()
                    { new Tuple<string, object, string>("CNPJ", Convenio.CNPJ, "=") }).Count > 0)
                    throw new Exception("Já existe Convenio com o CNPJ informado");

                ConvenioDao.Insert(Convenio);
                lstConvenios.Add(Convenio);

                MessageBox.Show(this, "Convenio incluido com sucesso", "Convenio");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstConvenios;
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
                var Convenio = (Convenio)dgResultado.CurrentRow.DataBoundItem;
                int index = lstConvenios.IndexOf(Convenio);
                validationInsertUpdate(Convenio);

                if (ConvenioDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("CNPJ", Convenio.CNPJ, "="),
                    new Tuple<string, object, string>("ID",Convenio.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Convenio com o CNPJ informado");

                lstConvenios.RemoveAt(index);
                ConvenioDao.Update(Convenio);
                lstConvenios.Add(Convenio);
                lstConvenios = lstConvenios.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Convenio alterado com sucesso", "Convenio");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstConvenios;
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

                var Convenio = dgResultado.CurrentRow.DataBoundItem as Convenio;
                if (Convenio == null) return;

                txtCnpj.Text = Convenio.CNPJ;
                txtRegistroAns.Text = Convenio.RegistroANS.ToString();
                txtUF.Text = Convenio.UF;
                txtRazaoSocial.Text = Convenio.RazaoSocial;
                txtNomeFantasia.Text = Convenio.NomeFantasia;
                txtTelefone.Text = Convenio.Telefone;
                txtEmail.Text = Convenio.Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = lstConvenios.Where(x =>
                x.CNPJ.Contains(txtPesquisaRazaoSocial.Text.Trim()) &&
                x.NomeFantasia.Contains(txtPesquisaRazaoSocial.Text.Trim()) &&
                x.RazaoSocial.Contains(txtPesquisaCnpj.Text.Trim())).ToList();
        }

        private void dgResultado_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgResultado.DataSource != null && dgResultado.Columns.Count > 0)
                dgResultado.Columns[0].Visible = false;
        }
    }
}
