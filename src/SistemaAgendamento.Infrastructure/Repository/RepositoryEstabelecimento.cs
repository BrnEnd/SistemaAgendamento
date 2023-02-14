using SistemaAgendamento.Application.Interfaces;
using SistemaAgendamento.Domain.Models;
using SistemaAgendamento.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Repository.Repository
{
    public class RepositoryEstabelecimento : Repository<Estabelecimento>, IEstabelecimentoRepository
    {
        protected AppDbContext _context;
        public RepositoryEstabelecimento(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Estabelecimento> GetEstabelecimentosAtivos()
        {
            return _context.Estabelecimentos.Where(p => p.Ativo.Equals("S"));
        }
    }
    
}
