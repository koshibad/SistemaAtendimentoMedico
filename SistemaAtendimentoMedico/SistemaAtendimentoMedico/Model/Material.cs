﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Model
{
    public class Material
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int IDCategoria { get; set; }
        public int IDFinalidade { get; set; }
        public int IDFabricante { get; set; }
        public double ValorUnitario { get; set; }
    }
}
