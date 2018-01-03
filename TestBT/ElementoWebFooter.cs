using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBT
{
    class ElementoWebFooter
    {
        public ElementoWebFooter()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Todo sobre BeneficiosTarjetas")]
        public IWebElement linkTodoSobreBT { get; set; }

        [FindsBy(How = How.LinkText, Using = "Centro de ayuda")]
        public IWebElement linkCentrodeAyuda { get; set; }

        [FindsBy(How = How.LinkText, Using = "Política y Privacidad")]
        public IWebElement linkPoliticayPrivacidad { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/div/div[3]/div[1]/div[2]/ul/li[4]/a")]
        public IWebElement linkTerminosyCondiciones { get; set; }
        
                [FindsBy(How = How.LinkText, Using = "Información sobre Campañas y Concursos")]
        public IWebElement linkInformacionCampanasyConcursos { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/div[2]/div/div[2]/a")]
        public IWebElement LinkFacebookBancoEstado { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div/div/div[3]/div[2]/a/img")]
        public IWebElement LinkHazteCliente { get; set; }

        [FindsBy(How = How.LinkText, Using = "Solicita tu CuentaRUT")]
        public IWebElement linkSolicitaTuCuentaRut { get; set; }

        [FindsBy(How = How.LinkText, Using = "Solicita tu Tarjeta de Crédito")]
        public IWebElement linkSolicitaTarjetaCredito { get; set; }

        /// <summary>
        /// Método de ingreso para link Todo Sobre Beneficios Tarjetas
        /// </summary>

        public void IngresoLinkTodoSobreBT()
        {
            linkTodoSobreBT.Click();
            System.Threading.Thread.Sleep(3000);
        }

        /// <summary>
        /// Método de ingreso para link Centro de Ayuda
        /// </summary>

        public void IngresoLinkCentrodeAyuda()
        {
            linkCentrodeAyuda.Click();
            System.Threading.Thread.Sleep(3000);
        }

        /// <summary>
        /// Método de ingreso para link Politica y Privacidad
        /// </summary>

        public void IngresoLinkPoliticayPrivacidad()
        {
            linkPoliticayPrivacidad.Click();
            System.Threading.Thread.Sleep(3000);
        }

        /// <summary>
        /// Método de ingreso para link Termino y Condiciones
        /// </summary>

        public void IngresoLinkTerminoyCondiciones()
        {
            linkTerminosyCondiciones.Click();
            System.Threading.Thread.Sleep(3000);
        }

        /// <summary>
        /// Método de ingreso para link Informacion Camapañas y Concursos
        /// </summary>

        public void IngresoLinkInformacionCampanasyConcursos()
        {
            linkInformacionCampanasyConcursos.Click();
            System.Threading.Thread.Sleep(3000); 
        }

        /// <summary>
        /// Método de ingreso para link Facebook de BancoEstado
        /// </summary>

        public void IngresoLinkFacebookBancoEstado()
        {
            LinkFacebookBancoEstado.Click();
            System.Threading.Thread.Sleep(3000);
        }

        /// <summary>
        /// Método para el ingreso de link Solicita Cuenta RUT
        /// </summary>
        
        public void IngresoLinkSolicitaCuentaRUT()
        {
            linkSolicitaTuCuentaRut.Click();
            System.Threading.Thread.Sleep(3000);
        }

        /// <summary>
        /// Método para el ingreso de link Solicita Tarjeta de Crédito
        /// </summary>

        public void IngresoLinkSolicitudTarjetaCredito()
        {
            linkSolicitaTarjetaCredito.Click();
            System.Threading.Thread.Sleep(3000);
        }
    }
}
