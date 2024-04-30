using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("informe o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("INFORME A ALTURA EM METROS".ToLower());
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> " + "abaixo do peso");

            }
            else if (valorIMC >= 20 && valorIMC <= 24)
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> normal");
            }
            else if (valorIMC >= 25 && valorIMC <= 26)
            {
                Console.WriteLine("\nIMC = " + valorIMC + " -> acimda do peso");
            }

            Console.WriteLine(valorIMC);
            Console.ReadKey();
        }
    }
}
