using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6Ejercicio2
{//Realizar un marco de pantalla con signos asteriscos desde la posición (5,2) a (75,22)
    class Program
    {
        static void Main(string[] args)
        {

            string marco = Marquito(5, 2, 75, 22);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(marco);
            Console.ReadKey();
        }

        // Definimos la función Marquito que recibe las coordenadas como parámetros
        static public string Marquito(int x1, int y1, int x2, int y2)
        {
            // Creamos una variable para almacenar el marco
            string marco = "";

            // Iteramos sobre las filas
            for (int y = y1; y <= y2; y++)
            {
                // Iteramos sobre las columnas
                for (int x = x1; x <= x2; x++)
                {
                    // Verificamos si estamos en los bordes del marco
                    if (y == y1 || y == y2 || x == x1 || x == x2)
                    {
                        // Si estamos en un borde, añadimos un asterisco al marco
                        marco += "*";
                    }
                    else
                    {
                        // Si no estamos en un borde, añadimos un espacio al marco
                        marco += " ";
                    }
                }
                // Agregamos un salto de línea al final de cada fila
                marco += "\n";
            }

            return marco;
        }
    }
}
