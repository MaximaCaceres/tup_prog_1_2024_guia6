using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6EjCuatro1._2
{
    using System;
    class Program
    {
        static void Main()
        {
            // Leer los números del usuario para definir el intervalo
            Console.Write("Ingresa el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Determinar el inicio y fin del intervalo
            int inicio, fin;

            if (num1 <= num2)
            {
                inicio = num1;
                fin = num2;
            }
            else
            {
                inicio = num2;
                fin = num1;
            }

            Console.WriteLine($"El intervalo válido es de {inicio} a {fin}.");

            // Bucle para procesar valores dentro del rango
            int valor;
            do
            {
                Console.Write("Ingresa un valor (ingresa -1 para terminar): ");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor == -1)
                {
                    break; // Terminar el bucle si se ingresa -1
                }

                if (valor >= inicio && valor <= fin)
                {
                    if (valor % 2 == 0 && valor % 3 == 0)
                    {
                        Console.WriteLine($"{valor} es divisible por 2 y por 3.");
                    }
                    else
                    {
                        Console.WriteLine($"{valor} no cumple con las condiciones requeridas.");
                    }
                }
                else
                {
                    Console.WriteLine("Valor fuera del intervalo.");
                }

            } while (true);

            Console.WriteLine("Programa terminado.");
            Console.ReadKey();
        }
    }


}
