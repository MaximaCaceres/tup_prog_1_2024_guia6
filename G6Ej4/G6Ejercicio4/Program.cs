using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6Ejercicio4
{//Implemente una aplicación que dados dos valores enteros ingresados por el usuario
 //muestre en pantalla todos los valores divisibles por 2 y por 3 en el intervalo formado
 //por los números ingresados. No realice ninguna suposición sobre el orden en el que se ingresan los valores y su magnitud.
    class Program
    {
        static void Main(string[] args)
        {


            int num1, num2;
            Console.WriteLine("ingrese dos numeros");
            num1 = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
            RecorrerIntervalo(num1, num2);
            Console.ReadKey();

        }

        static void RecorrerIntervalo(int num1, int num2)
        {
            Console.WriteLine("Valores divisibles por 2 y 3 en el intervalo [{0}, {1}]:",num1,num2);
            if(num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
            else
            {
                for(int i = num1; i >= num2; i--)
                {
                    if (i % 2 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
            
            
        }
        
    }
}
