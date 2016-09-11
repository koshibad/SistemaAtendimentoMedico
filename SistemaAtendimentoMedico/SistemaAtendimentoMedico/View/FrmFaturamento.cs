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
    public partial class FrmFaturamento : Form
    {
        public FrmFaturamento()
        {
            InitializeComponent();
        }

        public void clearAllComponents()
        {
            txtPesquisaCpf.Clear();
            txtPesquisaCrm.Clear();
            txtPesquisaEspecialidade.Clear();
            txtPesquisaNome.Clear();

            txtNomePaciente.Clear();
            txtCpfPaciente.Clear();

            txtRelatorio.Clear();
        }

        private void btnGerarRelatorioMedico_Click(object sender, EventArgs e)
        {
            txtRelatorio.Clear();

            var lstResultado = Util.lstAtendimentos.Where(x =>
                x.DataFinalizacaoAtendimento != null &&
                x.Agendamento.Medico != null &&
                x.Agendamento.NomeMedico.Contains(txtPesquisaNome.Text.Trim()) &&
                x.Agendamento.Medico.CPF.Contains(txtPesquisaCpf.Text.Trim()) &&
                x.Agendamento.Medico.CRM.Contains(txtPesquisaCrm.Text.Trim()) &&
                x.Agendamento.Medico.NomeEspecialidade.Contains(txtPesquisaEspecialidade.Text.Trim())).ToList();

            if (lstResultado.Count == 0)
            {
                MessageBox.Show(this, "Nenhum atendimento foi realizado com o medico informado",
                    "Relatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            gerarRelatorio(lstResultado);
        }

        private void btnGerarRelatorioPaciente_Click(object sender, EventArgs e)
        {
            txtRelatorio.Clear();

            var lstResultado = Util.lstAtendimentos.Where(x =>
               x.DataFinalizacaoAtendimento != null &&
               x.Agendamento.Paciente != null &&
               x.Agendamento.NomePaciente.Contains(txtNomePaciente.Text.Trim()) &&
               x.Agendamento.Paciente.CPF.Contains(txtCpfPaciente.Text.Trim())).ToList();

            if (lstResultado.Count == 0)
            {
                MessageBox.Show(this, "Nenhum atendimento foi realizado com o paciente informado",
                    "Relatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            gerarRelatorio(lstResultado);
        }

        private void gerarRelatorio(List<Atendimento> lstResultado)
        {
            try
            {
                string texto = "";
                int count = 1, countMaterial = 1;
                double valorTotal = 0, valorTotalMaterial = 0;

                foreach (var item in lstResultado)
                {
                    texto += Environment.NewLine;
                    texto += new string('*', 50) + "  INICIO CONSULTA " + count + "  " + new string('*', 50);

                    texto += Environment.NewLine + Environment.NewLine;
                    texto += "CPF Paciente: " + item.CpfPaciente + Environment.NewLine;
                    texto += "Nome Paciente: " + item.NomePaciente + Environment.NewLine;
                    texto += "CRM Medico: " + item.Agendamento.Medico.CRM + Environment.NewLine;
                    texto += "Nome Medico: " + item.NomeMedico;

                    texto += Environment.NewLine + Environment.NewLine;
                    texto += "Tipo da Consulta: " + item.Agendamento.TipoConsulta + Environment.NewLine;
                    if (item.Agendamento.Convenio == null)
                    {
                        texto += "Convenio: -" + Environment.NewLine;
                        texto += "Percentual Particular: " + item.Agendamento.Medico.Especialidade.RemuneracaoParticular;
                        texto += "%" + Environment.NewLine;
                    }
                    else
                    {
                        texto += "Convenio: " + item.Agendamento.Convenio.NomeFantasia + Environment.NewLine;
                        texto += "Percentual Convenio: " + item.Agendamento.Medico.Especialidade.RemuneracaoConvenio;
                        texto += "%" + Environment.NewLine;
                    }
                    valorTotal = item.Agendamento.Medico.Especialidade.ValorConsulta * (1 +
                        item.Agendamento.Medico.Especialidade.RemuneracaoConvenio / 100);
                    texto += "Valor da Consulta: " + valorTotal.ToString("c");
                    texto += Environment.NewLine + Environment.NewLine;

                    foreach (var material in item.lstAtendimentoMaterial)
                    {
                        texto += "[Materia utilizado " + countMaterial + "]" + Environment.NewLine;
                        texto += "Nome: " + material.Material.Nome + Environment.NewLine;
                        texto += "Fabricante: " + material.Material.NomeFabricante;
                        texto += "Quantidade: " + material.Quantidade + Environment.NewLine;
                        texto += "Valor Unit.: " + material.Material.ValorUnitario.ToString("c") + Environment.NewLine;
                        valorTotalMaterial = material.Material.ValorUnitario * material.Quantidade;
                        texto += "Valor Total Material: " + valorTotalMaterial.ToString("c");
                        texto += Environment.NewLine + Environment.NewLine;
                        valorTotal += valorTotalMaterial;
                        countMaterial++;
                    }

                    texto += "Valor Total da Consulta: " + valorTotal.ToString("c");
                    texto += Environment.NewLine + Environment.NewLine;
                    texto += new string('*', 50) + "  FIM CONSULTA " + count + "  " + new string('*', 50);

                    texto += Environment.NewLine + Environment.NewLine;
                    count++;
                    countMaterial = 1;
                }

                txtRelatorio.Text = texto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
