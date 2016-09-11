﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimentoMedico.Model
{
    public class Atendimento
    {
        public int ID { get; set; }

        private int _IDAgendamento;
        public int IDAgendamento
        {
            get { return _IDAgendamento; }
            set
            {
                _IDAgendamento = value;
                if (Utils.Util.lstAgendamentos != null)
                {
                    Agendamento = Utils.Util.lstAgendamentos.FirstOrDefault(x => x.ID == value);
                    if (Agendamento != null)
                    {
                        CpfPaciente = Agendamento.Paciente.CPF;
                        NomePaciente = Agendamento.NomePaciente;
                        NomeMedico = Agendamento.NomeMedico;
                        DataConsulta = Agendamento.DataConsulta;
                    }
                }
            }
        }

        public string CpfPaciente { get; set; }
        public string NomePaciente { get; set; }
        public string NomeMedico { get; set; }
        public DateTime DataConsulta { get; set; }

        [Browsable(false)]
        public Agendamento Agendamento { get; set; }

        [Browsable(false)]
        public string Tratamento { get; set; }
        public DateTime? DataFinalizacaoAtendimento { get; set; }
    }
}
