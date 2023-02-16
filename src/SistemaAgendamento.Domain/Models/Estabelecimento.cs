﻿using System;
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
            get => this._idEstabelecimento; 
            
        }
        private string _nomeEstabelecimento;
        public string NomeEstabelecimento
        {
            get => this._nomeEstabelecimento; set
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
        public char Ativo { get => this._ativo; set => this._ativo = value; }

        public Agenda Agenda { get; set; }

        public Estabelecimento()
        {
            
        }



    }
}
