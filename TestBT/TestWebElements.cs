using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBT
{
    class TestWebElements
    {

        public TestWebElements()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]")]
        public IWebElement menuIngresaCuenta { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement txtpassword { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]/div/div/div/form/input[5]")]
        public IWebElement btnIngresa { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]/div/div/a[1]")]
        public IWebElement btnRegistrate { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]/div/div/a[2]")]
        public IWebElement btnHazteCliente { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[3]/div[2]/div[2]/div/div[2]/div/ul/li/a")]
        public IWebElement btnCerrarSesion { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[3]/div[2]/div[2]/div/div[2]/div/div[2]/ul[1]/li[1]/a")]
        public IWebElement menuDatosPersonales { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[3]/div[2]/div[2]/div/div[1]/div/div/div[3]/div[3]/div/div[1]/p/a")]
        public IWebElement btnCambiarDireccionFacturacion { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[3]/div[2]/div[2]/div/div[1]/div/div[3]/p/a")]
        public IWebElement btnVolverGestionarDirecciones { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]/div/div/div/div/a[1]")]
        public IWebElement linkOlvidasteClave { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[1]/div/nav/ul/li[1]/div/div/div/div/a[2]")]
        public IWebElement linkValidarClave { get; set; }


        
        #region  Metodos
        /// <summary>
        ///  Completa los campos de login
        /// </summary>
        public void logearse(string username, string password)
        {
            System.Threading.Thread.Sleep(2000); 

            menuIngresaCuenta.Click();

            System.Threading.Thread.Sleep(2000);

            txtEmail.SendKeys(username);

            txtpassword.SendKeys(password);

            System.Threading.Thread.Sleep(2000);

            btnIngresa.Click();

        }


        /// <summary>
        /// Metodo que ingresa a la opción Datos Personales
        /// 

        public void ingresarMenu()
        {
            System.Threading.Thread.Sleep(2000);

            menuDatosPersonales.Click();

            System.Threading.Thread.Sleep(2000);

        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public void cambioDatosFactura()
        {
            System.Threading.Thread.Sleep(2000);

            btnCambiarDireccionFacturacion.Click();

            System.Threading.Thread.Sleep(2000);
        }

        public void volverMenuInicio()
        {
            btnVolverGestionarDirecciones.Click();
        }

        public void CerrarSesion()
        {
            System.Threading.Thread.Sleep(2000);

            btnCerrarSesion.Click();
        }

        public void IngresarOlvidasteClave()
        {
            System.Threading.Thread.Sleep(2000);

            menuIngresaCuenta.Click();

            System.Threading.Thread.Sleep(2000);

            linkOlvidasteClave.Click();

        }

        public void IngresarValidarClave()
        {
            System.Threading.Thread.Sleep(2000);

            menuIngresaCuenta.Click();

            System.Threading.Thread.Sleep(2000);

            linkValidarClave.Click();
        }
        
        public void botonRegistrar()
        {
            System.Threading.Thread.Sleep(2000);

            menuIngresaCuenta.Click();

            System.Threading.Thread.Sleep(2000);

            btnRegistrate.Click();
        }

        public void botonHazteCliente()
        {
            
            menuIngresaCuenta.Click();

            System.Threading.Thread.Sleep(2000);

            btnHazteCliente.Click();

            System.Threading.Thread.Sleep(2000);
        }

        #endregion


    }


}
