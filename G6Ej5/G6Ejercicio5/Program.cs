using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6Ejercicio5
{//Una forma de determinar si un número es primo consiste en verificar si es divisible por sí mismo y por uno.
    //Implemente una aplicación que determine si un valor entero ingresado por el usuario es o no un número primo.

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            Console.WriteLine("ingrese un numero");
            num1 = Convert.ToInt16(Console.ReadLine());
            VerificarPrimo(num1);
            Console.ReadKey();
        }
        #region//Verificar primo.
        static double VerificarPrimo(int num1)
        {
            double Div;
            int cont = 0;
            for(int i = 1; i <= num1; i++)
            {
                Div = num1 % i;
                if(Div == 0)
                {
                    cont += 1;
                }
            }
            
            if (cont <= 2)
            {
                Console.WriteLine("El numero ingresado es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo.");
            }
            return cont;
        }
        #endregion
    }
}
