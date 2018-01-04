using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBT
{
    class ElementoWebTablaDespacho
    {
        public ElementoWebTablaDespacho()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "peso")]
        public IWebElement comboboxPeso { get; set; }

        [FindsBy(How = How.Id, Using = "region")]
        public IWebElement comboboxRegion { get; set; }


    }
}
