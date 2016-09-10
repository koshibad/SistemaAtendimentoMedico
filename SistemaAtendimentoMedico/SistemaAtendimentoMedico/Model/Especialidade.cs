using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Model
{
    public class Especialidade
    {
        public int ID { get; set; }
        public string Nome { get; internal set; }
        public double ValorConsulta { get; set; }
        public double RemuneracaoConvenio { get; set; }
        public double RemuneracaoParticular { get; set; }
    }
}
