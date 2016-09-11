using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Model
{
    public class Agendamento
    {
        public enum eTipoConsulta
        {
            Convenio = 0,
            Particular = 1
        }

        public int ID { get; set; }

        private int _IDPaciente;
        public int IDPaciente
        {
            get { return _IDPaciente; }
            set
            {
                _IDPaciente = value;
                if (Utils.Util.lstPacientes != null)
                {
                    Paciente = Utils.Util.lstPacientes.FirstOrDefault(x => x.ID == value);
                    if (Paciente != null) NomePaciente = Paciente.Nome;
                }
            }
        }
        public string NomePaciente { get; set; }
        [Browsable(false)]
        public Paciente Paciente { get; set; }

        private int _IDMedico;
        public int IDMedico
        {
            get { return _IDMedico; }
            set
            {
                _IDMedico = value;
                if (Utils.Util.lstMedicos != null)
                {
                    Medico = Utils.Util.lstMedicos.FirstOrDefault(x => x.ID == value);
                    if (Medico != null) NomeMedico = Medico.Nome;
                }
            }
        }
        public string NomeMedico { get; set; }
        [Browsable(false)]
        public Medico Medico { get; set; }

        public DateTime DataConsulta { get; set; }

        private int _IDTipoConsulta;
        public int IDTipoConsulta
        {
            get { return _IDTipoConsulta; }
            set
            {
                _IDTipoConsulta = value;
                TipoConsulta = ((eTipoConsulta)value).ToString();
            }
        }
        public string TipoConsulta { get; set; }

        private int _IDConvenio;
        public int IDConvenio
        {
            get { return _IDConvenio; }
            set
            {
                _IDConvenio = value;
                if (Utils.Util.lstConvenios != null)
                    Convenio = Utils.Util.lstConvenios.FirstOrDefault(x => x.ID == value);
            }
        }

        [Browsable(false)]
        public Convenio Convenio { get; set; }
    }
}
