using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_TDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_TDD.Tests
{
    [TestClass]
    public class PessoaTeste
    {
        [TestMethod]
        public void PessoaDeveTerCpfENome()
        {
            string cpf = "12345678901";
            string nome = "Nome do Teste";
            Pessoa p = new Pessoa(cpf, nome);
            Assert.IsTrue(!String.IsNullOrEmpty(p.CPF), "CPF nulo ou em branco.");
            Assert.IsTrue(!String.IsNullOrEmpty(p.Nome), "Nome nulo ou em branco.");
        }
    }
}
