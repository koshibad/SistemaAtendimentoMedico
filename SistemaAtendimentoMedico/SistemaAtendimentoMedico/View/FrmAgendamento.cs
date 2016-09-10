﻿using SistemaAtendimentoMedico.Data;
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
    public partial class FrmAgendamento : Form
    {
        public List<Agendamento> lstAgendamentos = null;
        public AgendamentoDao AgendamentoDao = null;

        public FrmAgendamento()
        {
            InitializeComponent();
            AgendamentoDao = new AgendamentoDao();
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
            Agendamento Agendamento = null;
            if (dgResultado.CurrentRow == null ||
                (Agendamento = dgResultado.CurrentRow.DataBoundItem as Agendamento) == null)
            {
                MessageBox.Show(this, "Selecione um Agendamento na lista para editá-lo.", "Agendamento",
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
            Agendamento Agendamento = null;
            if (dgResultado.CurrentRow == null ||
                (Agendamento = dgResultado.CurrentRow.DataBoundItem as Agendamento) == null)
            {
                MessageBox.Show(this, "Selecione um Agendamento na lista para excluí-lo.", "Agendamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            try
            {
                int index = lstAgendamentos.IndexOf(Agendamento);
                lstAgendamentos.RemoveAt(index);
                AgendamentoDao.Delete(Agendamento.ID.ToString());

                MessageBox.Show(this, "Agendamento incluido com sucesso", "Agendamento");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstAgendamentos;
                formOnEndTask();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validationInsertUpdate(Agendamento Agendamento)
        {
            try
            {
                Agendamento.CPF = txtCpf.Text.ValidarTextoVazio("CPF");
                Agendamento.Nome = txtNome.Text.ValidarTextoVazio("Nome");
                Agendamento.UF = txtUF.Text.ValidarTextoVazio("UF");
                Agendamento.Municipio = txtMunicipio.Text.ValidarTextoVazio("Municipio");
                Agendamento.CEP = txtCep.Text.ValidarNumeros(8, "CEP");
                Agendamento.Logradouro = txtLogradouro.Text.ValidarTextoVazio("Logradouro");
                Agendamento.Numero = txtNumero.Text.ValidarNumero();
                Agendamento.Complemento = txtComplemento.Text;
                Agendamento.Bairro = txtBairro.Text.ValidarTextoVazio("Bairro");
                Agendamento.Telefone = txtTelefone.Text.ValidarNumeros(10, "telefone");
                Agendamento.Celular = txtCelular.Text.ValidarNumeros(10, "celular", false);
                Agendamento.Email = txtEmail.Text.ValidarEmail();
                Agendamento.DataNascimento = txtDataNasc.Text.ValidarData();
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
                var Agendamento = new Agendamento();
                validationInsertUpdate(Agendamento);

                if (AgendamentoDao.Select(new List<Tuple<string, object, string>>()
                    { new Tuple<string, object, string>("CPF", Agendamento.CPF, "=") }).Count > 0)
                    throw new Exception("Já existe Agendamento com o CPF informado");

                AgendamentoDao.Insert(Agendamento);
                lstAgendamentos.Add(Agendamento);

                MessageBox.Show(this, "Agendamento incluido com sucesso", "Agendamento");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstAgendamentos;
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
                var Agendamento = (Agendamento)dgResultado.CurrentRow.DataBoundItem;
                int index = lstAgendamentos.IndexOf(Agendamento);
                validationInsertUpdate(Agendamento);

                if (AgendamentoDao.Select(new List<Tuple<string, object, string>>(){
                    new Tuple<string, object, string>("CPF", Agendamento.CPF, "="),
                    new Tuple<string, object, string>("ID",Agendamento.ID,"<>")
                    }).Count > 0)
                    throw new Exception("Já existe Agendamento com o CPF informado");

                lstAgendamentos.RemoveAt(index);
                AgendamentoDao.Update(Agendamento);
                lstAgendamentos.Add(Agendamento);
                lstAgendamentos = lstAgendamentos.OrderBy(x => x.ID).ToList();
                MessageBox.Show(this, "Agendamento incluido com sucesso", "Agendamento");

                dgResultado.DataSource = null;
                dgResultado.DataSource = lstAgendamentos;
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

                var Agendamento = dgResultado.CurrentRow.DataBoundItem as Agendamento;
                if (Agendamento == null) return;

                txtCpf.Text = Agendamento.CPF;
                txtNome.Text = Agendamento.Nome;
                txtLogradouro.Text = Agendamento.Logradouro;
                txtUF.Text = Agendamento.UF;
                txtMunicipio.Text = Agendamento.Municipio;
                txtNumero.Text = Agendamento.Numero.ToString();
                txtCep.Text = Agendamento.CEP;
                txtComplemento.Text = Agendamento.Complemento;
                txtBairro.Text = Agendamento.Bairro;
                txtTelefone.Text = Agendamento.Telefone;
                txtCelular.Text = Agendamento.Celular;
                txtEmail.Text = Agendamento.Email;
                txtDataNasc.Text = Agendamento.DataNascimento.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgResultado.DataSource = null;
            dgResultado.DataSource = lstAgendamentos.Where(x =>
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
