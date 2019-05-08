using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTesteAuto.Tests
{
    [TestClass]
    public class UsuarioSystemTest
    {
        static ChromeDriver driver;
        private string caminhoDriver = Directory.GetCurrentDirectory()+@"\bin\Debug\netcoreapp2.1\"; 

        [TestMethod]
        public void deveCadastrarUmUsuario()
        {
            IWebDriver driver = new ChromeDriver(caminhoDriver);
            driver.Navigate().GoToUrl("http://localhost:8080/usuarios/new.html");

            IWebElement campoNome = driver.FindElement(By.Name("usuario.nome"));
            IWebElement campoEmail = driver.FindElement(By.Name("usuario.email"));
            IWebElement btnSalvar = driver.FindElement(By.Id("btnSalvar"));

            campoNome.SendKeys("Batman");
            campoEmail.SendKeys("batman@batman.com");
            
            Console.ReadKey();

            btnSalvar.Click();

            bool achouNome = driver.PageSource.Contains("Batman");
            bool achouEmail = driver.PageSource.Contains("batman@batman.com");

            Assert.IsTrue(achouNome);
            Assert.IsTrue(achouEmail);

            driver.Close();
            driver.Dispose();
        }
    }
}
