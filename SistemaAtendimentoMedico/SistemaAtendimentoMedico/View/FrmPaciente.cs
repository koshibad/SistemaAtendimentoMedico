using SistemaAtendimentoMedico.Data;
using SistemaAtendimentoMedico.Model;
using SistemaAtendimentoMedico.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAtendimentoMedico.View
{
    public partial class FrmPaciente : Form
    {
        public List<Paciente> lstPacientes = null;
        public PacienteDao PacienteDao = null;

        public FrmPaciente()
        {
            InitializeComponent();
            Util.SetUFComboBox(cbUF);
            PacienteDao = new PacienteDao();
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
            Paciente paciente = null;
            if (dgResultado.CurrentRow == null ||
                (paciente = dgResultado.CurrentRow.DataBoundItem as Paciente) == null)
            {
                MessageBox.Show(this, "Selecione um paciente na lista para editá-lo.", "Paciente",
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
            Paciente paciente = null;
            if (dgResultado.CurrentRow == null ||
                (paciente = dgResultado.CurrentRow.DataBoundItem as Paciente) == null)
            {
                MessageBox.Show(this, "Selecione um paciente na lista para excluí-lo.", "Paciente",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                dgResultado.DataSource = null;
                int index = lstPacientes.IndexOf(paciente);
                lstPacientes.RemoveAt(index);
                PacienteDao.Delete(paciente.ID.ToString());

                MessageBox.Show(this, "Paciente incluido com sucesso", "Paciente");

                dgResultado.DataSource = lstPacientes;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validationInsertUpdate(Paciente paciente)
        {
            try
            {
                paciente.CPF = txtCpf.Text.ValidarTextoVazio("CPF");
                paciente.Nome = txtNome.Text.ValidarTextoVazio("Nome");
                paciente.UF = (cbUF.SelectedValue ?? "").ToString().ValidarTextoVazio("UF");
                paciente.Municipio = txtMunicipio.Text.ValidarTextoVazio("Municipio");
                paciente.CEP = txtCep.Text.ValidarNumeros(8, "CEP");
                paciente.Logradouro = txtLogradouro.Text.ValidarTextoVazio("Logradouro");
                paciente.Numero = txtNumero.Text.ValidarNumero();
                paciente.Complemento = txtComplemento.Text;
                paciente.Bairro = txtBairro.Text.ValidarTextoVazio("Bairro");
                paciente.Telefone = txtTelefone.Text.ValidarNumeros(10, "telefone");
                paciente.Celular = txtCelular.Text.ValidarNumeros(10, "celular", false);
                paciente.Email = txtEmail.Text.ValidarEmail();
                paciente.DataNascimento = txtDataNasc.Text.ValidarData();
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
                var paciente = new Paciente();
                validationInsertUpdate(paciente);

                if (PacienteDao.Select(new List<Tuple<string, object, string>>()
                    { new Tuple<string, object, string>("CPF", paciente.CPF, "=") }).Count > 0)
                    throw new Exception("Já existe paciente com o CPF informado");

                PacienteDao.Insert(paciente);
                dgResultado.DataSource = null;
                lstPacientes = PacienteDao.Select(null);

                MessageBox.Show(this, "Paciente alterado com sucesso", "Paciente");

                dgResultado.DataSource = lstPacientes;
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
                var paciente = (Paciente)dgResultado.CurrentRow.DataBoundItem;
                int index = lstPacientes.IndexOf(paciente);
                validationInsertUpdate(paciente);

                if (PacienteDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("CPF", paciente.CPF, "="),
                    new Tuple<string, object, string>("ID",paciente.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe paciente com o CPF informado");

                dgResultado.DataSource = null;
                lstPacientes.RemoveAt(index);
                PacienteDao.Update(paciente);
                lstPacientes.Add(paciente);
                lstPacientes = lstPacientes.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Paciente alterado com sucesso", "Paciente");

                dgResultado.DataSource = lstPacientes;
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
                    Util.ClearAllControls(this);
                    return;
                }

                var paciente = dgResultado.CurrentRow.DataBoundItem as Paciente;
                if (paciente == null) return;

                txtCpf.Text = paciente.CPF;
                txtNome.Text = paciente.Nome;
                txtLogradouro.Text = paciente.Logradouro;
                cbUF.SelectedItem = paciente.UF;
                txtMunicipio.Text = paciente.Municipio;
                txtNumero.Text = paciente.Numero.ToString();
                txtCep.Text = paciente.CEP;
                txtComplemento.Text = paciente.Complemento;
                txtBairro.Text = paciente.Bairro;
                txtTelefone.Text = paciente.Telefone;
                txtCelular.Text = paciente.Celular;
                txtEmail.Text = paciente.Email;
                txtDataNasc.Text = paciente.DataNascimento.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = lstPacientes.Where(x =>
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