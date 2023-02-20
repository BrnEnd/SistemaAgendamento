using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Domain.Interfaces;
using SistemaAgendamento.Domain.Models;
using SistemaAgendamento.Repository.DTOs;
using System;
using System.Threading.Tasks;

namespace SistemaAgendamento.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgendamentoController : ControllerBase
    {
        private IUnitOfWork _context;
        private IMapper _mapper;

        public AgendamentoController(IUnitOfWork context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpPost("addNewAgendamento")]
        public async Task<ActionResult> AddNewAgendamentoAsync([FromBody]AgendamentoDto request) {

            var agendamento = _mapper.Map<Agendamento>(request);
            try
            {

                Agenda agenda = await _context.AgendaRepository.GetById(request.AgendaIdAgenda);
                Cliente cliente = await _context.ClienteRepository.GetById(request.ClienteIdCliente);

                if(agenda == null || cliente == null)
                {
                    return NotFound("Cliente e/ou Agenda não encontrado(s).");
                }

                if (_context.AgendamentoRepository.AddNewAgendamento(agendamento,cliente,agenda).Contains("sucesso"))
                {
                    return Ok("Sucesso.");
                }
                else
                {
                    return BadRequest("Não foi possivel concluir agendamento.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao persistir dado no banco.", ex);
            }
        }
    }
}
