using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_TDD.Models
{
    public class Pessoa
    {
        public Pessoa(string cpf, string nome)
        {
            if (String.IsNullOrWhiteSpace(cpf))
                throw new Exception("CPF deve ser preenchido!");

            if (String.IsNullOrWhiteSpace(nome))
                throw new Exception("Nome deve ser preenchido!");

            this.CPF = cpf;
            this.Nome = nome;
        }

        public string CPF { get; set; }
        public string Nome { get; set; }
    }
}