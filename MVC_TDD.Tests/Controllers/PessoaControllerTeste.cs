using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_TDD.Controllers;
using MVC_TDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC_TDD.Tests.Controllers
{
    [TestClass]
    public class PessoaControllerTeste
    {
        PessoaController controller = new PessoaController();

        [TestMethod]
        public void IndexPessoa()
        {
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }

        [TestMethod]
        public void CreatePessoa()
        {
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsTrue("Meu Create" == result.ViewBag.Titulo);
        }

        [TestMethod]
        public void ListPessoa()
        {
            ViewResult result = controller.List() as ViewResult;
            var count = (result.Model as IEnumerable<Pessoa>).Count();  
            Assert.IsTrue(count > 0);
        }
    }
}
