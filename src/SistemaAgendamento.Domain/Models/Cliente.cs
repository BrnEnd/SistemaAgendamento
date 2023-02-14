using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Domain.Models
{
    public class Cliente
    {
        private int _idCliente;
        public int IdCliente { get => this._idCliente; private set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Necessario IDCliente para instancia do Objeto Cliente.");
                }
                else
                {
                    this._idCliente = value;
                }
            } 
        }

        private string _nome;
        public string Nome { get => this._nome; private set
            {
                if(value.Length <= 0)
                {
                    throw new Exception("Necessario Nome para instancia do Objeto Cliente.");
                }
                else
                {
                    this._nome = value;
                }
            }
        }
        private char _ativo;
        public char Ativo { get => this._ativo; private set
            {
                this._ativo = value;
            }
        }

        public List<Agendamento> Agendamentos { get; set; }

        public Cliente(int idCliente, string nome, char ativo = 's')
        {
            IdCliente = idCliente;
            Nome = nome;
            Ativo = ativo;
        }



    }
}
