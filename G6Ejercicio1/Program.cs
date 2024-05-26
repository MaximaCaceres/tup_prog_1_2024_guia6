using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {//Un estudiante de matemáticas requiere una aplicación que permita calcular la suma de los números naturales hasta un valor determinado.
        static void Main(string[] args)
        {
            int num = 0, num2 = 0;
            Console.WriteLine("ingrese dos numeros naturales para calcular la suma de su intervalo de numeros");
            num = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
            int suma = Determinado(num, num2);
            Console.WriteLine("La suma de los números naturales desde " + num + " hasta " + num2 + " es: " + suma);

            Console.ReadKey();
        }
        // Método que calcula la suma de los números naturales entre dos valores.
        public static int Determinado(int num, int num2)
        {
            int acumN = 0;
            for (int i = num; i <= num2; i++)
            {
                acumN += i;
            }
            return acumN;
        }

    }
}