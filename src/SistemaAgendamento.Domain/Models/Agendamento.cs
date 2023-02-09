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

                }    
            }
        }
    }
}
