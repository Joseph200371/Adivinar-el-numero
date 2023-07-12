using System;

namespace PracticaDeProgramacion
{
    internal class PracticaDeProgramacion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Queres jugar a un juegos? " +
                "\nEl juego es adivinar el numero entre 0 y 100");
            bool salir = false;

            int numIntento = 0;

            Random numero = new Random();
            int numAleatorio = numero.Next(0, 100);

            string menu;

            while (!salir)
            {
                Console.WriteLine(" == Menú ==" +
                    "\n << 1.Para empezar a jugar >>" +
                    "\n << 2.Para ver resultado>>" +
                    "\n << 0.Para salir >>" +
                    "\n Seleccione una opción: ");
                
                menu = Console.ReadLine();

                //Console.WriteLine($"{numAleatorio}");

                switch (menu)
                {
                    case "1":
                        juego(ref numIntento, numAleatorio);
                        salir = true;
                        break;

                    case "2":
                        Console.WriteLine($"\nEl numero aleatorio es: {numAleatorio}" +
                                    $"\nTermino el juego");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.Por favor, seleccione una opción válida.");
                        salir = true;
                        break;
                }

            }

        }

        static void juego(ref int numIntento, int numAleatorio)
        {
            int respuesta;

            Console.WriteLine("\n Empezo el juego");
            do
            {
                numIntento++;

                Console.WriteLine("\n ¿Que numero es?");
                respuesta = Int32.Parse(Console.ReadLine());

                if (respuesta < numAleatorio)
                {
                    Console.WriteLine($"\n El numero ingresado es mayor << {respuesta} >>");
                }
                else if (respuesta > numAleatorio)
                {
                    Console.WriteLine($"\n El numero ingrsado es menor << {respuesta} >>");
                }
                else
                {
                    if (respuesta == numAleatorio)
                    {

                        Console.WriteLine($"\n El numero es correcto, el numero aleatorio es: {numAleatorio}" +
                            $",Los numero de intento es --{numIntento}--");
                    }
                }

            } while (numAleatorio != respuesta);
            

            Console.WriteLine("\n Termino el juego");
        }
    }
}
