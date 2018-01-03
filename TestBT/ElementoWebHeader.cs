using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBT
{
    class ElementoWebHeader
    {
        public ElementoWebHeader()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]")]
        public IWebElement menuIngresaCuenta { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]")]
        public IWebElement menuInformacionAyuda { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]")]
        public IWebElement menuCarroCompras { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[1]/div/nav/ul/li[1]")]
        public IWebElement menuSeguimientoLinea { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[1]/div/nav/ul/li[5]/a/img")]
        public IWebElement menuTodoSuma { get; set; }

        [FindsBy(How = How.ClassName, Using = "button")]
        public IWebElement menuBotonBuscar { get; set; }

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement menuCajaBuscar { get; set; }


        public void BusquedaProducto(string producto)
        {
            System.Threading.Thread.Sleep(2000);

            menuCajaBuscar.SendKeys(producto);

            System.Threading.Thread.Sleep(2000);

            menuBotonBuscar.Click();
        }
    }
}


