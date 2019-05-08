using OpenQA.Selenium;

namespace SeleniumTesteAuto.Pages
{
    public class NovoUsuarioPage 
    {
        IWebDriver _driver;
        public NovoUsuarioPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Cadastra(string nome, string email)
        {
            IWebElement campoNome = _driver.FindElement(By.Name("usuario.nome"));
            IWebElement campoEmail = _driver.FindElement(By.Name("usuario.email"));
            IWebElement btnSalvar = _driver.FindElement(By.Id("btnSalvar"));

            campoNome.SendKeys(nome);
            campoEmail.SendKeys(email);

            btnSalvar.Click();
            //  alert
            _driver.SwitchTo().Alert().Accept();
        }
    }
}