using Calculadora.Servicios;

///<summary>
/// Clase principal del programa
/// 091023 - chi
/// </summary>

class Program
{
    ///<summary>
    ///Método de entrada a la app
    ///091023 - chi
    /// </summary>
    
    static void Main(string[] args)
    {
        MenuInterfaz calculator = new MenuImplementacion();
        calculator.mensajeBienvenida();

        //Variable de entrada al bucle
        bool cerrarMenu = false;

        //Opción elegida por el user
        int opcionElegida;

        //Bucle de la calculadora
        while (!cerrarMenu)
        {
            opcionElegida = calculator.calculadora(); //poner el nombre de la copia.
            Console.WriteLine(opcionElegida);


            int opcion1, opcion2, resultado; //creo las opciones para la calculadora

            switch (opcionElegida)
            {
                case 0:
                    Console.WriteLine("[INFO] - Se cerrará el programa");
                    cerrarMenu = true;
                    break;

                case 1:
                    Console.WriteLine("[INFO] - Se hará una suma");
                    Console.WriteLine("Escoge un número");
                    opcion1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion1);
                    Console.WriteLine("Escoge otro número");
                    opcion2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion2);
                    resultado = opcion1 + opcion2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;  

                case 2:
                    Console.WriteLine("[INFO] - Se hará una resta");
                    Console.WriteLine("Escoge un número");
                    opcion1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion1);
                    Console.WriteLine("Escoge otro número");
                    opcion2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion2);
                    resultado = opcion1 - opcion2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;

                case 3:
                    Console.WriteLine("[INFO] - Se hará una multiplicación");
                    Console.WriteLine("Escoge un número");
                    opcion1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion1);
                    Console.WriteLine("Escoge otro número");
                    opcion2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion2);
                    resultado = opcion1 * opcion2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;

                case 4:
                    Console.WriteLine("[INFO] - Se hará una división");
                    Console.WriteLine("Escoge un número");
                    opcion1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion1);
                    Console.WriteLine("Escoge otro número");
                    opcion2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Has elegido: " + opcion2);
                    resultado = opcion1 / opcion2;
                    Console.WriteLine("El resultado es: " + resultado);
                    break;

                default:
                    Console.WriteLine("[INFO] - No coincide con ninguna opción");
                    break;
            }
        }
    }

} 

