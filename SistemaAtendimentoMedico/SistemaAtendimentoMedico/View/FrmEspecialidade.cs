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
        public List<Especialidade> lstEspecialidades = null;
        public EspecialidadeDao EspecialidadeDao = null;

        public FrmEspecialidade()
        {
            InitializeComponent();
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
                int index = lstEspecialidades.IndexOf(Especialidade);
                lstEspecialidades.RemoveAt(index);
                EspecialidadeDao.Delete(Especialidade.ID.ToString());

                MessageBox.Show(this, "Especialidade incluido com sucesso", "Especialidade");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstEspecialidades;
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
                Especialidade.CPF = txtCpf.Text.ValidarTextoVazio("CPF");
                Especialidade.Nome = txtNome.Text.ValidarTextoVazio("Nome");
                Especialidade.UF = txtUF.Text.ValidarTextoVazio("UF");
                Especialidade.Municipio = txtMunicipio.Text.ValidarTextoVazio("Municipio");
                Especialidade.CEP = txtCep.Text.ValidarNumeros(8, "CEP");
                Especialidade.Logradouro = txtLogradouro.Text.ValidarTextoVazio("Logradouro");
                Especialidade.Numero = txtNumero.Text.ValidarNumero();
                Especialidade.Complemento = txtComplemento.Text;
                Especialidade.Bairro = txtBairro.Text.ValidarTextoVazio("Bairro");
                Especialidade.Telefone = txtTelefone.Text.ValidarNumeros(10, "telefone");
                Especialidade.Celular = txtCelular.Text.ValidarNumeros(10, "celular", false);
                Especialidade.Email = txtEmail.Text.ValidarEmail();
                Especialidade.DataNascimento = txtDataNasc.Text.ValidarData();
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
                    { new Tuple<string, object, string>("CPF", Especialidade.CPF, "=") }).Count > 0)
                    throw new Exception("Já existe Especialidade com o CPF informado");

                EspecialidadeDao.Insert(Especialidade);
                lstEspecialidades.Add(Especialidade);

                MessageBox.Show(this, "Especialidade incluido com sucesso", "Especialidade");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstEspecialidades;
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
                int index = lstEspecialidades.IndexOf(Especialidade);
                validationInsertUpdate(Especialidade);

                if (EspecialidadeDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("CPF", Especialidade.CPF, "="),
                    new Tuple<string, object, string>("ID",Especialidade.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Especialidade com o CPF informado");

                lstEspecialidades.RemoveAt(index);
                EspecialidadeDao.Update(Especialidade);
                lstEspecialidades.Add(Especialidade);
                lstEspecialidades = lstEspecialidades.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Especialidade incluido com sucesso", "Especialidade");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstEspecialidades;
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

                var Especialidade = dgResultado.CurrentRow.DataBoundItem as Especialidade;
                if (Especialidade == null) return;

                txtCpf.Text = Especialidade.CPF;
                txtNome.Text = Especialidade.Nome;
                txtLogradouro.Text = Especialidade.Logradouro;
                txtUF.Text = Especialidade.UF;
                txtMunicipio.Text = Especialidade.Municipio;
                txtNumero.Text = Especialidade.Numero.ToString();
                txtCep.Text = Especialidade.CEP;
                txtComplemento.Text = Especialidade.Complemento;
                txtBairro.Text = Especialidade.Bairro;
                txtTelefone.Text = Especialidade.Telefone;
                txtCelular.Text = Especialidade.Celular;
                txtEmail.Text = Especialidade.Email;
                txtDataNasc.Text = Especialidade.DataNascimento.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = lstEspecialidades.Where(x =>
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