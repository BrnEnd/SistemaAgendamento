using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Domain.Models
{
    public class Agendamento
    {

        public Guid IdAgendamento { get; set; }
        public int IdAgenda { get; set; }
        private DateTime _diaHoraAgendamento;
        public DateTime DiaHoraAgendamento { get => this._diaHoraAgendamento; private set { 
                if(value < DateTime.UtcNow)
                {
                    throw new Exception("Data de agendamento inferior a data atual.");
                }
                else
                {
                    this._diaHoraAgendamento = value;
                }
            }
        }
        public Status StatusAgendamento { get; set; }

        public int IdCliente { get; set; }

        public Agendamento(Guid idAgendamento, Agenda agenda, DateTime diaHoraAgendamento, Status statusAgendamento, Cliente idCliente)
        {
            IdAgendamento = idAgendamento;
            IdAgenda = agenda.IdAgenda;
            DiaHoraAgendamento = diaHoraAgendamento;
            StatusAgendamento = statusAgendamento;
            IdCliente = idCliente.IdCliente;
        }

    }
}
