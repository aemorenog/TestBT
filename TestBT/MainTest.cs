using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sikuli4Net.sikuli_UTIL;
using Sikuli4Net.sikuli_REST;

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


            string urlPrueba = "https://desarrollobeneficiosbe.ingesmart.cl/";

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

        [Test]
        public void validarIngresodeMundosBT()
        {
            TestWebElements paginaBT = new TestWebElements();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            paginaBT.IngresoMundoViajes();

            js.ExecuteScript("window.scrollBy(0,450);");

            js.ExecuteScript("window.scrollBy(0,850);");

            PropiedadColeccionDriver.driver.Navigate().Back();

            paginaBT.IngresoMundoTienda();

            js.ExecuteScript("window.scrollBy(0,850);");

            PropiedadColeccionDriver.driver.Navigate().Back();

            paginaBT.IngresoMundoDescuento();

            js.ExecuteScript("window.scrollBy(0,400);");

            System.Threading.Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,450);");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,550);");
        }

        [Test]
        public void validarIngresoViajesChile()
        {
            ElementoWebMundoViajes paginaBT = new ElementoWebMundoViajes();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            paginaBT.IngresoViajesChile();

            js.ExecuteScript("window.scrollBy(0,900);");

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void validarIngresoViajesSudamerica()
        {
            ElementoWebMundoViajes paginaBT = new ElementoWebMundoViajes();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            paginaBT.IngresoViajesSudamerica();

            js.ExecuteScript("window.scrollBy(0,400);", "");

            System.Threading.Thread.Sleep(4000);

            js.ExecuteScript("window.scrollBy(0,550);", "");

            System.Threading.Thread.Sleep(6000);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void validarIngresoLinkMundoViajes()
        {
            TestWebElements paginaBT = new TestWebElements();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,400);", "");

            System.Threading.Thread.Sleep(4000);

            paginaBT.IngresoLinkMundoViajes();

            System.Threading.Thread.Sleep(3500);

            js.ExecuteScript("window.scrollBy(0,400);", "");

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(4000);

            paginaBT.IngresoLinkTienda();

            System.Threading.Thread.Sleep(3500);

            js.ExecuteScript("window.scrollBy(0,400);", "");

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(4000);

            paginaBT.IngresoLinkDescuento();

            System.Threading.Thread.Sleep(3500);

            js.ExecuteScript("window.scrollBy(0,400);", "");

            System.Threading.Thread.Sleep(6000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void validarLinkTerminosyCondiciones()
        {
            ElementoWebFooter paginaBT = new ElementoWebFooter();
            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,1300);", "");
            System.Threading.Thread.Sleep(4500);

            paginaBT.IngresoLinkTerminoyCondiciones();

        }

        [Test]
        public void ValidarLinksFooter()
        {
            ElementoWebFooter paginaBT = new ElementoWebFooter();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;


            js.ExecuteScript("window.scrollBy(0,1300);", "");

            System.Threading.Thread.Sleep(7000);

            ///
            /// Ingreso de link Todo Sobre Beneficios Tarjtas
            ///

            paginaBT.IngresoLinkTodoSobreBT();

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,1300);", "");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,1300);", "");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,-1300);", "");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(3000);

            ///
            /// Ingreso de link Centro de Ayuda
            ///
            paginaBT.IngresoLinkCentrodeAyuda();

            System.Threading.Thread.Sleep(4000);

            js.ExecuteScript("window.scrollBy(0,1300);", "");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,-1300);", "");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(3000);

            ///
            /// Ingreso de link Politica y Privacidad
            ///

            paginaBT.IngresoLinkPoliticayPrivacidad();

            System.Threading.Thread.Sleep(4000);

            js.ExecuteScript("window.scrollBy(0,1300);", "");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,-1300);", "");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(3000);


            ///
            /// Ingreso de link Término y Condiciones
            ///

            paginaBT.IngresoLinkTerminoyCondiciones();

            System.Threading.Thread.Sleep(4000);

            js.ExecuteScript("window.scrollBy(0,1300);", "");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,-1300);", "");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(3000);

            ///
            /// Ingreso de link Información sobre campañas y concursos
            ///

            paginaBT.IngresoLinkInformacionCampanasyConcursos();

            System.Threading.Thread.Sleep(4000);

            js.ExecuteScript("window.scrollBy(0,1300);", "");

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,-1300);", "");

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Navigate().Back();

            System.Threading.Thread.Sleep(4000);
        }
        ///
        /// Ingreso de links Solicitar Cuenta Rut y Tarjeta de Crédito
        ///

        [Test]
        public void ValidarLinkTarjetas()
        {
            ElementoWebFooter paginaBT = new ElementoWebFooter();
            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            System.Threading.Thread.Sleep(4000);

            js.ExecuteScript("window.scrollBy(0,1300);", "");

            System.Threading.Thread.Sleep(4000);

            paginaBT.IngresoLinkSolicitaCuentaRUT();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(2000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles[1]).Close();

            System.Threading.Thread.Sleep(2000);

            PropiedadColeccionDriver.driver.SwitchTo().Window(PropiedadColeccionDriver.driver.WindowHandles.Last());

            System.Threading.Thread.Sleep(4000);

            paginaBT.IngresoLinkSolicitudTarjetaCredito();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void validarBusquedaHome()
        {
            ElementoWebHeader paginaBT = new ElementoWebHeader();

            string producto = "abrazo";

            paginaBT.BusquedaProducto(producto);
        }

        //js.ExecuteScript("window.scrollBy(0,-1300);", "");


        [Test]

        public void validarCompra()
        {
            ElementoWebCarroCompra paginaBT = new ElementoWebCarroCompra();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            APILauncher launcher = new APILauncher(true);

            Screen screen = new Screen();

            Pattern patter_buttoncath = new Pattern("C:/screen/button.PNG");

            string userName = "pruebaingesmart@gmail.com";

            string password = "c123456";

            string producto = "abrazo";

            string lugar = "Casa";

            string direccion = "Casa #213213 asdasd";

            string region = "";

            string comuna = "";


            launcher.Start();

            paginaBT.LoginUsuario(userName, password);

            System.Threading.Thread.Sleep(3000);

            paginaBT.IngresarCarroCompra(producto);

            System.Threading.Thread.Sleep(3000);

            //js.ExecuteScript("window.scrollBy(0,-1000);", "");

            paginaBT.completarFormulario();

            System.Threading.Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0,600);", "");

            System.Threading.Thread.Sleep(3000);

            paginaBT.completarDirección(lugar, direccion);

            //screen.Click(patter_buttoncath);

            System.Threading.Thread.Sleep(3000);

            PropiedadColeccionDriver.driver.Quit();
        }
    }
}

    