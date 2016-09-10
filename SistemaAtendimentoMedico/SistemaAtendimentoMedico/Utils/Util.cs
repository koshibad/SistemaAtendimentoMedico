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
        public static void ClearAllTextBox(Form form)
        {
            foreach (var control in form.Controls)
                if (control is TextBox)
                    (control as TextBox).Clear();
                else if (control is MaskedTextBox)
                    (control as MaskedTextBox).Clear();
        }

        public static void EnableAllTextBox(Form form, bool enabled)
        {
            foreach (var control in form.Controls)
                if (control is TextBox)
                    (control as TextBox).Enabled = enabled;
                else if (control is MaskedTextBox)
                    (control as MaskedTextBox).Enabled = enabled;
        }
    }
}
