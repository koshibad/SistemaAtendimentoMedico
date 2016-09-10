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
                int index = lstConvenios.IndexOf(Convenio);
                lstConvenios.RemoveAt(index);
                ConvenioDao.Delete(Convenio.ID.ToString());

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

        private void validationInsertUpdate(Convenio Convenio)
        {
            try
            {
                Convenio.CPF = txtCpf.Text.ValidarTextoVazio("CPF");
                Convenio.Nome = txtNome.Text.ValidarTextoVazio("Nome");
                Convenio.UF = txtUF.Text.ValidarTextoVazio("UF");
                Convenio.Municipio = txtMunicipio.Text.ValidarTextoVazio("Municipio");
                Convenio.CEP = txtCep.Text.ValidarNumeros(8, "CEP");
                Convenio.Logradouro = txtLogradouro.Text.ValidarTextoVazio("Logradouro");
                Convenio.Numero = txtNumero.Text.ValidarNumero();
                Convenio.Complemento = txtComplemento.Text;
                Convenio.Bairro = txtBairro.Text.ValidarTextoVazio("Bairro");
                Convenio.Telefone = txtTelefone.Text.ValidarNumeros(10, "telefone");
                Convenio.Celular = txtCelular.Text.ValidarNumeros(10, "celular", false);
                Convenio.Email = txtEmail.Text.ValidarEmail();
                Convenio.DataNascimento = txtDataNasc.Text.ValidarData();
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
                    { new Tuple<string, object, string>("CPF", Convenio.CPF, "=") }).Count > 0)
                    throw new Exception("Já existe Convenio com o CPF informado");

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
                    new Tuple<string, object, string>("CPF", Convenio.CPF, "="),
                    new Tuple<string, object, string>("ID",Convenio.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Convenio com o CPF informado");

                lstConvenios.RemoveAt(index);
                ConvenioDao.Update(Convenio);
                lstConvenios.Add(Convenio);
                lstConvenios = lstConvenios.OrderBy(x => x.ID).ToList();
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

                txtCpf.Text = Convenio.CPF;
                txtNome.Text = Convenio.Nome;
                txtLogradouro.Text = Convenio.Logradouro;
                txtUF.Text = Convenio.UF;
                txtMunicipio.Text = Convenio.Municipio;
                txtNumero.Text = Convenio.Numero.ToString();
                txtCep.Text = Convenio.CEP;
                txtComplemento.Text = Convenio.Complemento;
                txtBairro.Text = Convenio.Bairro;
                txtTelefone.Text = Convenio.Telefone;
                txtCelular.Text = Convenio.Celular;
                txtEmail.Text = Convenio.Email;
                txtDataNasc.Text = Convenio.DataNascimento.ToShortDateString();
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
