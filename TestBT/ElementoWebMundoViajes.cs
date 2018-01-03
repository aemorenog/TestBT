using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBT
{
    class ElementoWebMundoViajes
    {
        public ElementoWebMundoViajes()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[5]/nav/ul/li[1]")]
        public IWebElement opciónMenuViajes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[1]/div/h2/a")]
        public IWebElement opcionMenuIrViajes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[1]/div/div/div[1]/li[1]/ul/a")]
        public IWebElement opcionChileViajes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[1]/div/div/div[1]/li[2]/ul/a")]
        public IWebElement opcionSudamericaViajes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[1]/div/div/div[1]/li[3]/ul/a")]
        public IWebElement opcionMexicoCaribeViajes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[1]/div/div/div[1]/li[2]/ul/a")]
        public IWebElement opcionNorteAmericaViajes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[1]/div/div/div[1]/li[5]/ul/a")]
        public IWebElement opcionEuropaLejanosViajes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/section/div/div[1]/div/div/div[2]/li/ul/a")]
        public IWebElement opcionEscapadasViajes { get; set; }

        
        /// <summary>
        /// Ingreso a la opción Mundo Viajes opción Chile
        /// </summary>
        public void IngresoViajesChile()
        {
            System.Threading.Thread.Sleep(3000);

            opciónMenuViajes.Click();

            System.Threading.Thread.Sleep(3000);

            opcionChileViajes.Click();
        }

        /// <summary>
        /// Ingreso a la opción Mundo Viajes opción Sudamerica
        /// </summary>
        public void IngresoViajesSudamerica()
        {
            System.Threading.Thread.Sleep(3000);

            opciónMenuViajes.Click();

            System.Threading.Thread.Sleep(3000);

            opcionSudamericaViajes.Click();
        }

        /// <summary>
        /// Ingreso a la opción Mundo Viajes opción Mexico y Cariber
        /// </summary>

        public void IngresoViajesMexicoCaribe()
        {
            System.Threading.Thread.Sleep(3000);

            opciónMenuViajes.Click();

            System.Threading.Thread.Sleep(3000);

            opcionMexicoCaribeViajes.Click();

        }

        /// <summary>
        /// Ingreso a la opción Mundo Viajes opción Norteamerica
        /// </summary>
        
        public void IngresoViajesNorteAmerica()
        {
            System.Threading.Thread.Sleep(3000);

            opciónMenuViajes.Click();

            System.Threading.Thread.Sleep(3000);

            opcionNorteAmericaViajes.Click();
            
        }

        /// <summary>
        /// Ingreso a la opción Mundo Viajes opción Europa y Lejanos
        /// </summary>
        
        public void IngresoViajesEuropaLejanos()
        {
            System.Threading.Thread.Sleep(3000);

            opciónMenuViajes.Click();

            System.Threading.Thread.Sleep(3000);

            opcionEuropaLejanosViajes.Click();
        }

    }
}
