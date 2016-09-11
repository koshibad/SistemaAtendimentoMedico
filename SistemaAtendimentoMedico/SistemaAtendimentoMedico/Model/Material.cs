using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Model
{
    public class Material
    {
        [Browsable(false)]
        public int ID { get; set; }
        public string Nome { get; set; }
        public int IDCategoria { get; set; }
        public int IDFinalidade { get; set; }

        private int _IDFabricante;
        public int IDFabricante
        {
            get { return _IDFabricante; }
            set
            {
                _IDFabricante = value;
                if (Utils.Util.lstFabricante != null)
                {
                    var fab = Utils.Util.lstFabricante.FirstOrDefault(x => x.ID == value);
                    if (fab != null) NomeFabricante = fab.Nome;
                }
            }
        }
        public string NomeFabricante { get; set; }

        public double ValorUnitario { get; set; }

        public override string ToString()
        {
            return Nome + " - " + NomeFabricante;
        }
    }
}
