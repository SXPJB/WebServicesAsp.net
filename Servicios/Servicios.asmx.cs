using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicios
{
    /// <summary>
    /// Summary description for Servicios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicios : System.Web.Services.WebService
    {
        //metodo inicial generado por automaticamente
        [WebMethod]
        public string HelloWorld()
        {

            return "Hello World esta madre jala";
        }

        //Este metodo responde con un saludo y recibe una cadena de texto
        [WebMethod(Description = "Este metodo devuelve un saludo")]
        public String Saludar(string nombre)
        {
            return "Hola " + nombre;
        }

        //Metodo Guardar log-Este metodo permite guardar informacion en un archivo tio log.
        [WebMethod]
        public string GuardarLog(string texto)
        {
            Utils.Logs("LogPrueba", texto);

            return "Datos guardados, servisar el log";
        }

        //Metodo que realiza la multiplicaion de dos numeros
        [WebMethod(Description = "Es metodo recibe dos pametros para realizar una multiplicacion ")]
        public int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        //Metodo con vectores:
        [WebMethod]
        public string[] ObtenerDeportes()
        {
            string[] deporte = new string[3];
            deporte[0] = "Futbool";
            deporte[1] = "BAsquetbool";
            deporte[2] = "Tenis";
            return deporte;
        }

        //Metodo que guarda vector recibe como parametro un vector y almacena el contenido en un archivo log
        [WebMethod]
        public string GuardarVector(string[] deportes)
        {
            foreach(string d in deportes)
            {
                Utils.Logs("Deportes",d);
            }

            return "Los deportes se han sido guarddos, verifque el log";
        }

        //Optener equipos de futbool.-Este metodo trabaja con clases propieas definias por el programador
        [WebMethod]
        public List<Equipos> ObptenrEquipos()
        {
            //se crea una lista de objetos de tipo objetos
            List<Equipos> lEquipos = new List<Equipos>();
            //agregar contenido a la lista
            lEquipos.Add(new Equipos { nombreEquipo="Milan",pais="Italia"});
            lEquipos.Add(new Equipos { nombreEquipo = "Ajax", pais = "Holanda" });
            lEquipos.Add(new Equipos { nombreEquipo = "Valencia", pais = "España" });

            return lEquipos;
        }
    }
}
