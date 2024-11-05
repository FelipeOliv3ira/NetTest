using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("teste");

        }
    }

    public class Calculadora
    {
        public double Adicionar(double a, double b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Divisão por zero!");
            }
            return a / b;
        }
    }
}