using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CarService
{
    /// <summary>
    /// Summary description for CarService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CarService : System.Web.Services.WebService
    {
        public Car c = new Car("Honda", "Red");

        [WebMethod]
        public Car GetCar()
        {
            return c;
        }

    }

   
    public class Car
    {
        public string Name { set; get; }
        public string Color { set; get; }

        public Car()
        {

        }

        public Car(string name,string color)
        {
            this.Name = name;
            this.Color = color;
        }

    }

}
