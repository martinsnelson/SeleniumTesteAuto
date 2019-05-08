using System;
using SeleniumTesteAuto.Controllers;
namespace SeleniumTesteAuto
{
    class Program
    {
       static void Main(string[] args)
        {
            Startup.Engage(args);
        }

        static class Startup
        {
            static public void Engage(string[] args)
            {
                new SeleniumTesteAutoController(args);
            }
        }
    }
}
