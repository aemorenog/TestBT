using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBT
{
    class MainTest
    {
        static void Main(string[] args)
        {
        }

        [OneTimeSetUp]

        public void initialize()
        {
            //Usameos nuestra variable global webdriver y le asignamos que sea de tipo Chrome ()
            PropiedadColeccionDriver.driver = new FirefoxDriver();

            //Maximizamos la pantalla que se abrira del navegador
            PropiedadColeccionDriver.driver.Manage().Window.Maximize();


            string urlPrueba = "https://certificacionbeneficios.ingesmart.cl/";

            //Indicamos a nuestro driver a que página ir (página inicial o primera carga)
            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);
        }

        [Test]
        public void LoginBT()
        {
            TestWebElements paginaBT = new TestWebElements();

            string userName = "pruebaingesmart@gmail.com";

            string password = "q123456";

            paginaBT.logearse(userName, password);
        }

        [Test]
        public void CerrarSesionBT()
        {
            TestWebElements paginaBT = new TestWebElements();

            string userName = "pruebaingesmart@gmail.com";

            string password = "q123456";

            paginaBT.logearse(userName, password);

            paginaBT.CerrarSesion();
        }

        [Test]
        public void validarIngresoLinkOlvidasteClave()
        {
            TestWebElements paginaBT = new TestWebElements();

            paginaBT.IngresarOlvidasteClave();

            PropiedadColeccionDriver.driver.Navigate().Back();

            paginaBT.IngresarValidarClave();

        }

        [Test]
        public void validarBotonRegistrate()
        {
            TestWebElements paginaBT = new TestWebElements();

            paginaBT.botonRegistrar();
        }

        [Test]
        public void validarBotonHazteCliente()
        {
            TestWebElements paginaBT = new TestWebElements();

            paginaBT.botonHazteCliente();
        }
    }
}
    