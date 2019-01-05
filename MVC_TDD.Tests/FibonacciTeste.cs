using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_TDD.Tests
{
    [TestClass]
    public class FibonacciTeste
    {
        //POSICAO:  0   1   2   3   4   5   6   7   8   9   10
        //NUMEROS:  0   1   1   2   3   5   8   13  21  34  55

        [TestMethod]
        public void OPrimeiroElementoDeveSer0()
        {
            var result = Fibonacci.Elemento(0);
            Assert.AreEqual(0, result, "Diferente de zero.");
        }

        [TestMethod]
        public void OSegundoElementoDeveSer1()
        {
            var result = Fibonacci.Elemento(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OSetimoElementoDeveSer13()
        {
            var result = Fibonacci.Elemento(7);
            Assert.AreEqual(13, result);
        }
    }

    public static class Fibonacci
    {
        public static int Elemento(int posicao)
        {
            if (posicao < 0) throw new Exception("Posicao deve ser maior ou igual a 0!");
            if (posicao < 2) return posicao;
            return Elemento(posicao - 1) + Elemento(posicao - 2);
        }
    }
}
