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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();

            lbData.Text = DateTime.Now.ToLongDateString();
            lbHorario.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            lbHorario.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
