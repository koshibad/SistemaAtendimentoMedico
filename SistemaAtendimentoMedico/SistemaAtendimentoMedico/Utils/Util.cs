using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimentoMedico.View;
using System.Windows.Forms;
using SistemaAtendimentoMedico.Model;

namespace SistemaAtendimentoMedico.Utils
{
    public class Util
    {
        public static List<Paciente> lstPacientes = null;
        public static List<Especialidade> lstEspecialidades = null;
        public static List<Medico> lstMedicos = null;
        public static List<Convenio> lstConvenios = null;
        public static List<Agendamento> lstAgendamentos = null;

        public static void ClearAllControls(Form form)
        {
            foreach (var control in form.Controls)
                if (control is TextBox)
                    (control as TextBox).Clear();
                else if (control is MaskedTextBox)
                    (control as MaskedTextBox).Clear();
                else if (control is ComboBox)
                    (control as ComboBox).SelectedIndex = -1;
        }

        public static void EnableAllControls(Form form, bool enabled)
        {
            foreach (var control in form.Controls)
                if (control is TextBox)
                    (control as TextBox).Enabled = enabled;
                else if (control is MaskedTextBox)
                    (control as MaskedTextBox).Enabled = enabled;
                else if (control is ComboBox)
                    (control as ComboBox).Enabled = enabled;
        }

        public static void SetComboBox(ComboBox comboBox, object dataSource,
            string displayMember = "Nome", string valueMember = "ID")
        {
            comboBox.DataSource = null;
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedIndex = -1;
        }

        public static void SetUFComboBox(ComboBox comboBox)
        {
            var lstUF = new List<string>(){
                "AC","AL","AP","AM","BA","CE","DF","ES","GO","MA",
                "MT","MS","MG","PR","PB","PA","PE","PI","RJ","RN",
                "RS","RO","RR","SC","SE","SP","TO"};

            comboBox.DataSource = null;
            comboBox.DataSource = lstUF;
        }

        public static IEnumerable<string> TimeSpanFromMinutes(int minutes)
        {
            var start = DateTime.Today;
            var clockQuery = from offset in Enumerable.Range(0, (24 * 60) / minutes)
                             select TimeSpan.FromMinutes(minutes * offset);

            foreach (var time in clockQuery)
                yield return (start + time).ToString("HH:mm");
        }
    }
}
