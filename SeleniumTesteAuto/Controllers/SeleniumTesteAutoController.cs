using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTesteAuto.Pages;

namespace SeleniumTesteAuto.Controllers 
{
    public class  SeleniumTesteAutoController
    {
        static ChromeDriver driver;
        UsuarioPage usuarios;
        private string caminhoDriver = Directory.GetCurrentDirectory()+@"\bin\Debug\netcoreapp2.1\"; 
        public SeleniumTesteAutoController(string[] args)
        {
            IWebDriver _driver = new ChromeDriver(caminhoDriver);
            usuarios = new UsuarioPage(_driver);
            DeveCadastrarUmUsuario();
            _driver.Close();
            _driver.Dispose();
        }

        public void DeveCadastrarUmUsuario()
        {
            usuarios.Visita();
            usuarios.Novo().Cadastra("Batman", "batman@batman.com");
            usuarios.ExisteNaListagem("Batman", "batman@batman.com");

        //     try
        //    {
        //         IWebDriver driver = new ChromeDriver(caminhoDriver);
        //         driver.Navigate().GoToUrl("http://localhost:8080/usuarios/new.html");

        //         IWebElement campoNome = driver.FindElement(By.Name("usuario.nome"));
        //         IWebElement campoEmail = driver.FindElement(By.Name("usuario.email"));
        //         IWebElement btnSalvar = driver.FindElement(By.Id("btnSalvar"));

        //         campoNome.SendKeys("Batman");
        //         campoEmail.SendKeys("batman@batman.com");

        //         btnSalvar.Click();
        //         //  alert
        //         driver.SwitchTo().Alert().Accept();

        //         bool achouNome = driver.PageSource.Contains("Batman");
        //         bool achouEmail = driver.PageSource.Contains("batman@batman.com");

        //         driver.Close();
        //         driver.Dispose();   
        //    }
        //    catch (System.Exception e)
        //    {
        //        driver.Close();
        //        driver.Dispose();
        //        Console.Write(e);
        //        //Console.ReadKey();
        //        Console.WriteLine("Fechado catch");      
        //    }
        }
    }
}