using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Sikuli4Net.sikuli_REST;
using Sikuli4Net.sikuli_UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBT
{
    class ElementoWebCarroCompra
    {
        public ElementoWebCarroCompra()
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

        [FindsBy(How = How.ClassName, Using = "button")]
        public IWebElement menuBotonBuscar { get; set; }

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement menuCajaBuscar { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/div[2]/article/div[3]/div[1]/div[2]/div/p/button")]
        public IWebElement btnCarroTienda { get; set; }

        [FindsBy(How = How.ClassName, Using = "button_carro_tienda")]
        public IWebElement btnAgregarCarro { get; set; }

        [FindsBy(How = How.Id, Using = "pagar")]
        public IWebElement btnIrPagar { get; set; }

        [FindsBy(How = How.Id, Using = "cli-rut")]
        public IWebElement txtRutCliente { get; set; }

        [FindsBy(How = How.Id, Using = "cli-nombre")]
        public IWebElement txtNombreCliente { get; set; }

        [FindsBy(How = How.Id, Using = "cli-apellido")]
        public IWebElement txtApellidosCliente { get; set; }

        [FindsBy(How = How.Id, Using = "cli-email")]
        public IWebElement txtEmailCliente { get; set; }

        [FindsBy(How = How.Id, Using = "cli-celular")]
        public IWebElement txtCelularCliente { get; set; }

        [FindsBy(How = How.Id, Using = "dir-nombre")]
        public IWebElement txtAliasDireccionCliente { get; set; }

        [FindsBy(How = How.Id, Using = "direccion-despacho")]
        public IWebElement txtDireccion { get; set; }

        [FindsBy(How = How.Id, Using = "region-despacho")]
        public IWebElement comboRegionDespacho { get; set; }

        [FindsBy(How = How.Id, Using = "comuna-despacho")]
        public IWebElement comboComunaDespacho { get; set; }

        [FindsBy(How = How.XPath, Using = "btn-continuar-p3")]
        public IWebElement btnConfirmar { get; set; }

        public void LoginUsuario(string username, string password)
        {
            System.Threading.Thread.Sleep(2000);

            menuIngresaCuenta.Click();

            System.Threading.Thread.Sleep(2000);

            txtEmail.SendKeys(username);

            txtpassword.SendKeys(password);

            System.Threading.Thread.Sleep(2000);

            btnIngresa.Click();

            System.Threading.Thread.Sleep(2000);

        }

        public void IngresarCarroCompra(string producto)
        {
            System.Threading.Thread.Sleep(2000);

            menuCajaBuscar.SendKeys(producto);

            System.Threading.Thread.Sleep(2000);

            menuBotonBuscar.Click();

            System.Threading.Thread.Sleep(2000);

            btnAgregarCarro.Click();

            System.Threading.Thread.Sleep(2000);

            btnCarroTienda.Click();

            System.Threading.Thread.Sleep(2000);

            btnIrPagar.Click();

            System.Threading.Thread.Sleep(2000);
        }

        public void completarFormulario()
        {

            System.Threading.Thread.Sleep(2000);

            txtRutCliente.SendKeys("19887407-8");

            System.Threading.Thread.Sleep(2000);

            txtNombreCliente.SendKeys("Alex Eduardo");

            System.Threading.Thread.Sleep(2000);

            txtApellidosCliente.SendKeys("Moreno Gamboa");

            System.Threading.Thread.Sleep(2000);

            txtEmailCliente.SendKeys("amoreno@ingesmart.cl");

            System.Threading.Thread.Sleep(2000);

            txtCelularCliente.SendKeys("976526574");

            System.Threading.Thread.Sleep(2000);

        }


        public void completarDirección(string lugar, string direccion)
        {
            txtAliasDireccionCliente.SendKeys(lugar);

            System.Threading.Thread.Sleep(2000);

            txtDireccion.SendKeys(direccion);

            System.Threading.Thread.Sleep(2000);

            comboRegionDespacho.Selected.Equals("(XV) Región de Arica y Parinacota");

            System.Threading.Thread.Sleep(2000);

            comboComunaDespacho.Selected.Equals("Arica");

            System.Threading.Thread.Sleep(2000);

            btnConfirmar.Click();
        }

        public void SetDropDownList()
        {
            //Este DropdownList tiene X items con los siguientes valores..
            //En el parentesis ingresamos el que deseamos seleccionar, en este caso X
            comboRegionDespacho.Selected.Equals("(XV) Región de Arica y Parinacota");
        }
    }
     
}
