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
    public partial class FrmMedico : Form
    {
        public List<Medico> lstMedicos = null;
        public MedicoDao MedicoDao = null;

        public FrmMedico()
        {
            InitializeComponent();
            Util.SetUFComboBox(cbUF);
            MedicoDao = new MedicoDao();
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
            Medico Medico = null;
            if (dgResultado.CurrentRow == null ||
                (Medico = dgResultado.CurrentRow.DataBoundItem as Medico) == null)
            {
                MessageBox.Show(this, "Selecione um Medico na lista para editá-lo.", "Medico",
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
            Medico Medico = null;
            if (dgResultado.CurrentRow == null ||
                (Medico = dgResultado.CurrentRow.DataBoundItem as Medico) == null)
            {
                MessageBox.Show(this, "Selecione um Medico na lista para excluí-lo.", "Medico",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                dgResultado.DataSource = null;
                int index = lstMedicos.IndexOf(Medico);
                lstMedicos.RemoveAt(index);
                MedicoDao.Delete(Medico.ID.ToString());

                MessageBox.Show(this, "Medico incluido com sucesso", "Medico");

                dgResultado.DataSource = lstMedicos;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validationInsertUpdate(Medico Medico)
        {
            try
            {
                Medico.CPF = txtCpf.Text.ValidarTextoVazio("CPF");
                Medico.CRM = txtCRM.Text;
                Medico.Nome = txtNome.Text.ValidarTextoVazio("Nome");
                Medico.UF = (cbUF.SelectedValue ?? "").ToString().ValidarTextoVazio("UF");
                Medico.Municipio = txtMunicipio.Text.ValidarTextoVazio("Municipio");
                Medico.CEP = txtCep.Text.ValidarNumeros(8, "CEP");
                Medico.Logradouro = txtLogradouro.Text.ValidarTextoVazio("Logradouro");
                Medico.Numero = txtNumero.Text.ValidarNumero();
                Medico.Complemento = txtComplemento.Text;
                Medico.Bairro = txtBairro.Text.ValidarTextoVazio("Bairro");
                Medico.Telefone = txtTelefone.Text.ValidarNumeros(10, "telefone");
                Medico.Celular = txtCelular.Text.ValidarNumeros(10, "celular", false);
                Medico.Email = txtEmail.Text.ValidarEmail();
                Medico.DataNascimento = txtDataNasc.Text.ValidarData();
                Medico.IDEspecialidade = cbEspecialidade.ValidarItemSelecionado("Especialidade");
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
                var Medico = new Medico();
                validationInsertUpdate(Medico);

                if (MedicoDao.Select(new List<Tuple<string, object, string>>()
                    { new Tuple<string, object, string>("CPF", Medico.CPF, "=") }).Count > 0)
                    throw new Exception("Já existe Medico com o CPF informado");

                if (!String.IsNullOrEmpty(Medico.CRM) &&
                    MedicoDao.Select(new List<Tuple<string, object, string>>()
                    { new Tuple<string, object, string>("CRM", Medico.CRM, "=") }).Count > 0)
                    throw new Exception("Já existe Medico com o CRM informado");

                MedicoDao.Insert(Medico);
                dgResultado.DataSource = null;
                lstMedicos = MedicoDao.Select(null);

                MessageBox.Show(this, "Medico incluido com sucesso", "Medico");

                dgResultado.DataSource = lstMedicos;
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
                var Medico = (Medico)dgResultado.CurrentRow.DataBoundItem;
                int index = lstMedicos.IndexOf(Medico);
                validationInsertUpdate(Medico);

                if (MedicoDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("CPF", Medico.CPF, "="),
                    new Tuple<string, object, string>("ID",Medico.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Medico com o CPF informado");

                if (!String.IsNullOrEmpty(Medico.CRM) &&
                    MedicoDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("CRM", Medico.CRM, "="),
                    new Tuple<string, object, string>("ID",Medico.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Medico com o CRM informado");

                lstMedicos.RemoveAt(index);
                MedicoDao.Update(Medico);
                lstMedicos.Add(Medico);
                lstMedicos = lstMedicos.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Medico alterado com sucesso", "Medico");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstMedicos;
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

                var Medico = dgResultado.CurrentRow.DataBoundItem as Medico;
                if (Medico == null) return;

                txtCpf.Text = Medico.CPF;
                txtCRM.Text = Medico.CRM;
                txtNome.Text = Medico.Nome;
                txtLogradouro.Text = Medico.Logradouro;
                cbUF.SelectedItem = Medico.UF;
                txtMunicipio.Text = Medico.Municipio;
                txtNumero.Text = Medico.Numero.ToString();
                txtCep.Text = Medico.CEP;
                txtComplemento.Text = Medico.Complemento;
                txtBairro.Text = Medico.Bairro;
                txtTelefone.Text = Medico.Telefone;
                txtCelular.Text = Medico.Celular;
                txtEmail.Text = Medico.Email;
                txtDataNasc.Text = Medico.DataNascimento.ToShortDateString();
                cbEspecialidade.SelectedValue = Medico.IDEspecialidade;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = lstMedicos.Where(x =>
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