using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculadora.Servicios
{
    internal class MenuImplementacion : MenuInterfaz //Conecto los servicios
    {
        //Mensaje de Bienvenida
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido a la calculadora";
            Console.WriteLine(mensaje);
        }

        //Menú de la calculadora donde elegirá el usuario una opción y con opciónElegida lo cogerá el menú para hacer la operación deseada.
        public int calculadora()
        {
            int opcionElegida;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("0. Cerrar APP");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Seleccione una opcion: ");

            opcionElegida = Console.ReadKey(true).KeyChar - ('0'); //Lee un caracter y lo muestra por pantalla
            return opcionElegida;

        }
    }
}

