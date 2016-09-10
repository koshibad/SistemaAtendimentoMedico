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
        }

        private void tbCancelar_Click(object sender, System.EventArgs e)
        {
            formOnEndTask();
            dgResultado_CurrentCellChanged(null, null);
        }

        private void tbExcluir_Click(object sender, System.EventArgs e)
        {
            //TODO: verficar se existe consulta associado
            Atendimento Atendimento = null;
            if (dgResultado.CurrentRow == null ||
                (Atendimento = dgResultado.CurrentRow.DataBoundItem as Atendimento) == null)
            {
                MessageBox.Show(this, "Selecione um Atendimento na lista para excluí-lo.", "Atendimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                int index = lstAtendimentos.IndexOf(Atendimento);
                lstAtendimentos.RemoveAt(index);
                AtendimentoDao.Delete(Atendimento.ID.ToString());

                MessageBox.Show(this, "Atendimento incluido com sucesso", "Atendimento");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstAtendimentos;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validationInsertUpdate(Atendimento Atendimento)
        {
            try
            {
                Atendimento.CPF = txtCpf.Text.ValidarTextoVazio("CPF");
                Atendimento.Nome = txtNome.Text.ValidarTextoVazio("Nome");
                Atendimento.UF = txtUF.Text.ValidarTextoVazio("UF");
                Atendimento.Municipio = txtMunicipio.Text.ValidarTextoVazio("Municipio");
                Atendimento.CEP = txtCep.Text.ValidarNumeros(8, "CEP");
                Atendimento.Logradouro = txtLogradouro.Text.ValidarTextoVazio("Logradouro");
                Atendimento.Numero = txtNumero.Text.ValidarNumero();
                Atendimento.Complemento = txtComplemento.Text;
                Atendimento.Bairro = txtBairro.Text.ValidarTextoVazio("Bairro");
                Atendimento.Telefone = txtTelefone.Text.ValidarNumeros(10, "telefone");
                Atendimento.Celular = txtCelular.Text.ValidarNumeros(10, "celular", false);
                Atendimento.Email = txtEmail.Text.ValidarEmail();
                Atendimento.DataNascimento = txtDataNasc.Text.ValidarData();
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
                var Atendimento = new Atendimento();
                validationInsertUpdate(Atendimento);

                if (AtendimentoDao.Select(new List<Tuple<string, object, string>>()
                    { new Tuple<string, object, string>("CPF", Atendimento.CPF, "=") }).Count > 0)
                    throw new Exception("Já existe Atendimento com o CPF informado");

                AtendimentoDao.Insert(Atendimento);
                lstAtendimentos.Add(Atendimento);

                MessageBox.Show(this, "Atendimento incluido com sucesso", "Atendimento");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstAtendimentos;
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
                var Atendimento = (Atendimento)dgResultado.CurrentRow.DataBoundItem;
                int index = lstAtendimentos.IndexOf(Atendimento);
                validationInsertUpdate(Atendimento);

                if (AtendimentoDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("CPF", Atendimento.CPF, "="),
                    new Tuple<string, object, string>("ID",Atendimento.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Atendimento com o CPF informado");

                lstAtendimentos.RemoveAt(index);
                AtendimentoDao.Update(Atendimento);
                lstAtendimentos.Add(Atendimento);
                lstAtendimentos = lstAtendimentos.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Atendimento incluido com sucesso", "Atendimento");

                dgResultado.DataSource = null;
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

                var Atendimento = dgResultado.CurrentRow.DataBoundItem as Atendimento;
                if (Atendimento == null) return;

                txtCpf.Text = Atendimento.CPF;
                txtNome.Text = Atendimento.Nome;
                txtLogradouro.Text = Atendimento.Logradouro;
                txtUF.Text = Atendimento.UF;
                txtMunicipio.Text = Atendimento.Municipio;
                txtNumero.Text = Atendimento.Numero.ToString();
                txtCep.Text = Atendimento.CEP;
                txtComplemento.Text = Atendimento.Complemento;
                txtBairro.Text = Atendimento.Bairro;
                txtTelefone.Text = Atendimento.Telefone;
                txtCelular.Text = Atendimento.Celular;
                txtEmail.Text = Atendimento.Email;
                txtDataNasc.Text = Atendimento.DataNascimento.ToShortDateString();
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
