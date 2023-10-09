using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculadora.Servicios
{
    internal class MenuImplementacion : MenuInterfaz //Conecto los servicios
    {
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido a la calculadora";
            Console.WriteLine(mensaje);
        }

    }
}
