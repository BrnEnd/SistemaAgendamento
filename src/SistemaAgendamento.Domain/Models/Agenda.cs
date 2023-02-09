using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Domain.Models
{
    public class Agenda
    {
        private int _idAgenda;
        public int IdAgenda
        {
            get => this._idAgenda; private set
            {
                if (value <= 0)
                {
                    throw new Exception("Necessario IDAgenda para instancia do Objeto Agenda.");
                }
                else
                {
                    this._idAgenda = value;
                }
            }
        }
        
        public int IdEstabelecimento { get; set; }

        private char _agendaAberta;
        public char AgendaAberta { get; set; }

        public Agenda(int idAgenda, Estabelecimento estabelecimento, char agendaAberta )
        {
            IdAgenda = idAgenda;

            IdEstabelecimento = estabelecimento.IdEstabelecimento;

            AgendaAberta = agendaAberta;

        }


    }
}
