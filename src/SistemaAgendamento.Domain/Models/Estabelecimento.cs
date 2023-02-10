using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgendamento.Domain.Models
{
    public class Estabelecimento
    {
        private int _idEstabelecimento;
        public int IdEstabelecimento
        {
            get => this._idEstabelecimento; private set
            {
                if (value < 0)
                {
                    throw new Exception("Necessario IDCliente para instancia do Objeto Cliente.");
                }
                else
                {
                    this._idEstabelecimento = value;
                }
            }
        }
        private string _nomeEstabelecimento;
        public string NomeEstabelecimento
        {
            get => this._nomeEstabelecimento; private set
            {
                if (value.Length <= 0)
                {
                    throw new Exception("Necessario Nome para instancia do Objeto Cliente.");
                }
                else
                {
                    this._nomeEstabelecimento = value;
                }
            }
        }
        public string NomeProfissional { get; set; }

        private char _ativo;
        public char Ativo { get => this._ativo; private set => this._ativo = value; }

        public Estabelecimento(int idEstabelecimento, string nomeEstabelecimento, string nomeProfissional, char ativo = 'S')
        {
            IdEstabelecimento = idEstabelecimento;
            NomeEstabelecimento = nomeEstabelecimento;
            NomeProfissional = nomeProfissional;
            Ativo = ativo;
        }



    }
}
