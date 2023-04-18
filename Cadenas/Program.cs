using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una cadena que tenga al menos 40 caracteres.\n");

            string input = Console.ReadLine();

            if(input.Length < 40)
            {
                do
                {
                    Console.WriteLine($"La cadena introducida posee únicamente {input.Length} caracteres. Por favor, introduzca una nueva cadena con más de 40 caracteres. \n");
                    input = Console.ReadLine();

                    if(input.Length >= 40)
                    {
                        Menu(input);
                    }

                } while (input.Length < 40);
            }
            else if(input.Length >= 40)
            {
                Menu(input);
            }

            Console.ReadLine();

        }

        public static void Menu(string cadena)
        {
            bool goOut = false;
            int option = 0;

            do
            {

                Console.WriteLine("Menú :D");
                Console.WriteLine("1-. Sustituir una palabra por otra. ");
                Console.WriteLine("2-. Buscar texto en la cadena. ");
                Console.WriteLine("3-. Buscar texto de inicio en la cadena. ");
                Console.WriteLine("4-. Introducir un dígito y convertir a cadena de 12 caracteres rellenados por cero por delante. ");
                Console.WriteLine("0-. Salir \n");

                try
                {

                    option = int.Parse(Console.ReadLine());


                }catch(Exception e )
                {
                    Console.WriteLine("La opción elegida debe ser un número.");
                }

                switch(option) {

                    case 0:
                        goOut = true;
                        Console.WriteLine("Adios!");
                        break;

                    case 1:
                        Sustitucion(cadena);
                        break;

                    case 2:
                        BuscadoEnCadena(cadena);
                        break;

                    case 3:
                        BuscadoEnInicio(cadena);
                        break;

                    case 4:
                        IntroduceDigito();
                        break;

                }

               

            } while (goOut == false);
        }

        public static void Sustitucion (string cadena) {

            Console.WriteLine("Introduzca, separadas por un espacio, la palabra a sustituir, y la sustituta.\n");

            string texto = Console.ReadLine();

            string[] palabras = texto.Split(' ');

            string palabraASusitutir = palabras[0];
            string palabraSustituta = palabras[1];

            string cadenaModificada = cadena.Replace(palabraASusitutir, palabraSustituta);

            Console.WriteLine(cadenaModificada+"\n");

        }

        public static void BuscadoEnCadena (string cadena)
        {

            Console.WriteLine("Introduzca un texto para comprobar si existe o no.\n");

            string texto = Console.ReadLine();

            if (cadena.Contains(texto))
            {
                Console.WriteLine("El texto escrito existe en la cadena.\n");
            }
            else
            {
                Console.WriteLine("El texto escrito no existe en la cadena.\n");
            }

        }

        public static void BuscadoEnInicio (string cadena)
        {

            Console.WriteLine("Introduzca un texto para comprobar si la cadena comienza por el mismo.\n");

            string texto = Console.ReadLine ();

            if (cadena.StartsWith(texto))
            {
                Console.WriteLine("La cadena comienza por el texto escrito.\n");
            }
            else{
                Console.WriteLine("La cadena no comienza por el texto escrito.\n");
            }

        }

        public static void IntroduceDigito()
        {
            Console.WriteLine("Introduce un dígito.\n");

            int digito = int.Parse(Console.ReadLine());

            string cadena = digito.ToString().PadLeft(12, '0');

            Console.WriteLine(cadena);
        }


    }
}
