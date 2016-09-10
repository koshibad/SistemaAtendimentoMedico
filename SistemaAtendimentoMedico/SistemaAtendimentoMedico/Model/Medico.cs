using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Model
{
    public class Medico
    {
        public int ID { get; set; }
        public string CPF { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public string Municipio { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        private int _IDEspecialidade;
        public int IDEspecialidade
        {
            get { return _IDEspecialidade; }
            set
            {
                _IDEspecialidade = value;
                if (Utils.Util.lstEspecialidades != null)
                {
                    var esp = Utils.Util.lstEspecialidades.FirstOrDefault(x => x.ID == value);
                    if (esp != null) Especialidade = esp.Nome;
                }
            }
        }
        public string Especialidade { get; set; }
    }
}
