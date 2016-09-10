using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimentoMedico.View;
using System.Windows.Forms;

namespace SistemaAtendimentoMedico.Utils
{
    public class Util
    {
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
    }
}
