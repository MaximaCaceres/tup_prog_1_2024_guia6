using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6Ejercicio3
{//Realizar un programa que permita ingresar 10 números y calcule su promedio.
    class Program
    {
        
        static void Main(string[] args)
        {
            double num = 0, prom = 0;
            double[] valores = new double[10];
            valores = TomarValor();
       
            num = CalcularValor(valores);//guardo el valor calculado por el metodo CalcularValor en una variable double para poder sacar prom.
            prom = num / 10;//calculo el promedio.
            Console.WriteLine("el promedio es de: {0:F1}",prom);//finalmente muestro el promedio con un decimal.
            Console.ReadKey();

        }
        //tomo el valor de cada posicion del vector
        static double[] TomarValor()
        {
            double[] numeros = new double[10];

            for (int i = 0; i <10; i++)
            {
                numeros[i] = Convert.ToDouble(Console.ReadLine());//cada vez que se incremente i, espero a que ingrese un numero.
            }
            return numeros;//mi retorno es el valor de cada parte del vector.
        } 
        //calculo el valor de la suma de cada numero dentro del vector.
        static double CalcularValor(double[] numeros)
        {
            double acumN = 0;//inicio el acumulador para poder usarlo en el for.
            for(int i = 0; i <10; i++)//paso por cada posicion del vector.
            {
                acumN += numeros[i];//a medida que paso por la posicion acumulo el valor en acumN
            }
            return acumN;//retorno la suma de los valores del vector.
        }
    }
}
