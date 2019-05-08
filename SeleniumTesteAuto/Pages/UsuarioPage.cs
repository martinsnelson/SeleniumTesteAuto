using OpenQA.Selenium;

namespace SeleniumTesteAuto.Pages
{
    public class UsuarioPage
    {
        IWebDriver _driver;
        public UsuarioPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Visita()
        {
            _driver.Navigate().GoToUrl("http://localhost:8080/usuarios/usuarios.html");
        }

        public NovoUsuarioPage Novo()
        {
            _driver.FindElement(By.LinkText("Novo Usuario")).Click();
            return new NovoUsuarioPage(_driver);
        }

        public bool ExisteNaListagem(string nome, string email)
        {
            bool achouNome = _driver.PageSource.Contains(nome);
            bool achouEmail = _driver.PageSource.Contains(email);
            
            return achouNome && achouEmail;
        }
    }
}