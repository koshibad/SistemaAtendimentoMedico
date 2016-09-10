using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Model
{
    public class Convenio
    {
        public int ID { get; set; }
        public string CNPJ { get; set; }
        public int RegistroANS { get; set; }
        public string UF { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
