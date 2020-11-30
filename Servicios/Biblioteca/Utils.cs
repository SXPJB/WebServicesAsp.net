using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Servicios
{
    public class Utils
    {
        //  metodo para creacion de Logs.
        public static void Logs(string nombreArchivo, string mensaje)
        {
            //Crear un directorio
            string directorio = AppDomain.CurrentDomain.BaseDirectory + "logs/" +
                DateTime.Now.Year.ToString() + "/" +
                DateTime.Now.Month.ToString() + "/" +
                DateTime.Now.Day.ToString();

            //validar si existe el directorio, en caso de no ser asi se crea
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            //A continuacion creacion y manimpulacion del archivo log
            StreamWriter archivo = new StreamWriter(directorio + "/" + nombreArchivo + ".txt", true);

            String fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+" >>>> "+mensaje;
            archivo.WriteLine(fecha);
            archivo.Close();
        }

    }
}