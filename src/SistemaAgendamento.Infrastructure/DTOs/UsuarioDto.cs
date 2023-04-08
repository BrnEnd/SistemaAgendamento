using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Repository.DTOs
{
    public class UsuarioDto
    {
        public string Email {   get; set;  }
        public string Senha { get; set;}
        public string ConfirmaSenha {  get; set; }
    }
}
