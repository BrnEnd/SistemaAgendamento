using SistemaAgendamento.Domain.Interfaces;
using SistemaAgendamento.Domain.Models;
using SistemaAgendamento.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Repository.Repository
{
    public class RepositoryAgendamento : Repository<Agendamento>, IAgendamentoRepository
    {
        public RepositoryAgendamento(AppDbContext context) : base(context)
        {
        }

        public string AddNewAgendamento(Agendamento agendamento, Cliente cliente, Agenda agenda)
        {      
                var _agendamento = new Agendamento(Guid.NewGuid(), agendamento.DiaHoraAgendamento, (int)Status.Espera);
                _agendamento.Agenda = agenda;
                _agendamento.Cliente = cliente;
                _agendamento.AgendaIdAgenda = _agendamento.Agenda.IdAgenda;
                _agendamento.AgendaIdAgenda = _agendamento.Cliente.IdCliente;
                _context.Agendamentos.Add(_agendamento);
                _context.SaveChanges();
                return "Agendamento realizado com sucesso!";
          
        }
    }
    
}
