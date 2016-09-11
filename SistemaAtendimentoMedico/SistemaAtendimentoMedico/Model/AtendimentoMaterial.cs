using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Model
{
    public class AtendimentoMaterial
    {
        public enum eNovo
        {
            nao = 0,
            sim = 1
        }

        public AtendimentoMaterial() { }

        public AtendimentoMaterial(int IDAtendimento, int IDMaterial, double Quantidade)
        {
            this.IDAtendimento = IDAtendimento;
            this.IDMaterial = IDMaterial;
            this.Quantidade = Quantidade;
            this.Novo = eNovo.sim;
        }

        public int ID { get; set; }
        public int IDAtendimento { get; set; }

        private int _IDMaterial;
        public int IDMaterial
        {
            get { return _IDMaterial; }
            set
            {
                _IDMaterial = value;
                if (Utils.Util.lstMateriais != null)
                    Material = Utils.Util.lstMateriais.FirstOrDefault(x => x.ID == value);
            }
        }
        public Material Material { get; set; }

        public double Quantidade { get; set; }
        public eNovo Novo { get; set; }

        public override string ToString()
        {
            if (Material == null) return "Material descontinuado";

            return "QTD: " + Quantidade + " - " + Material.Nome + " - " + Material.NomeFabricante;
        }
    }
}
