using System;

namespace equacaoExerc
{
    class Program
    {
        static void Main(string[] args)
        {               
            EquacaoPrimeiroGrau();
        }

        static void EquacaoSegundoGrau(){
            Console.WriteLine("Digite A, B e C para Fazer uma Equação de Segundo Grau.");
            Console.Write("A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("C: ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }

        static void EquacaoPrimeiroGrau(){
            Console.WriteLine("Digite A e B para Fazer uma Equação de Primeiro Grau(ax + b = 0).");
            Console.Write("A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Equação:{a}x + {b} = 0");

            double x = (-1 * b) / a;
            Console.WriteLine(x);            

        }
    }
}
