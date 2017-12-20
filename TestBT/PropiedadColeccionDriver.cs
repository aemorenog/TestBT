using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBT
{
    //<summary> Utilizar los valores para identificar los elementos mas comunes
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    //<summary> Creamos un Auto-Implementada Propiedad para llamar a driver de un solo lugar y ahorramos un campo mas
    class PropiedadColeccionDriver
    {
        public static IWebDriver driver { get; set; }
    }
}
