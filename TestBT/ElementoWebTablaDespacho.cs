using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
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

        [FindsBy(How = How.Id, Using = "mostrar_tabla")]
        public IWebElement btnMostrarTabla { get; set; }

        [FindsBy(How = How.Id, Using = "cerrar_tabla")]
        public IWebElement btnCerrarVentana { get; set; }

        [FindsBy(How = How.Id, Using = "ocultar_tabla")]
        public IWebElement btnOcultarTabla { get; set; }


        public void validarBtnMostrarTabla()
        {
            System.Threading.Thread.Sleep(2000);

            btnMostrarTabla.Click();

            System.Threading.Thread.Sleep(2000);

        }

        public void validarBtnOcultarTabla()
        {
            System.Threading.Thread.Sleep(2000);

            btnMostrarTabla.Click();

            System.Threading.Thread.Sleep(2000);

            btnOcultarTabla.Click();

        }

        public void validarValoresComboPeso()
        {
            SelectElement selectValuePeso = new SelectElement(comboboxPeso);

            IList<IWebElement> listaCombo = selectValuePeso.Options;

            int iSize = listaCombo.Count;

            for(int i = 0; i > iSize; i++)
            {
                String sValue = listaCombo.ElementAt(i).Text;
                Console.WriteLine(sValue);
            }
        }


        public void validarValoresComboRegion(string peso)
        {

            SelectElement selectValuePeso = new SelectElement(comboboxPeso);

            SelectElement selectValueRegion = new SelectElement(comboboxRegion);

            System.Threading.Thread.Sleep(1500);

            selectValuePeso.SelectByText(peso);

            IList<IWebElement> listaCombo = selectValueRegion.Options;

            int iSize = listaCombo.Count;

            for (int i = 0; i > iSize; i++)
            {
                String sValue = listaCombo.ElementAt(i).Text;
                Console.WriteLine(sValue);
            }
        }

        public void validarCalculo(string peso, string region)
        {
            SelectElement selectValuePeso = new SelectElement(comboboxPeso);

            SelectElement selectValueRegion = new SelectElement(comboboxRegion);

            selectValuePeso.SelectByText(peso);

            System.Threading.Thread.Sleep(3000);

            selectValueRegion.SelectByText(region);

            System.Threading.Thread.Sleep(3000);

            //selectValuePeso.SelectByText("");

            //System.Threading.Thread.Sleep(3000);

            //selectValuePeso.SelectByText("");
            
        }
    }
}
