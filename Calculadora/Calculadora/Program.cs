using System;
using System.ComponentModel.Design;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("CALCULADORA C#");
            Console.WriteLine("[1] - SOMA");
            Console.WriteLine("[2] - SUBTRAÇÃO");
            Console.WriteLine("[3] - DIVISÃO");
            Console.WriteLine("[4] - MULTIPLICAÇÃO");
            Console.WriteLine("[5] - SAIR\n");
            Console.WriteLine("---------------------");
            Console.Write("Digite uma opção: ");
            short res = short.Parse(Console.ReadLine()!);

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multi(); break;
                case 5: Environment.Exit(0);break;
                default:Menu(); break;
            }
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("--SUBTRAÇÃO--\n");
            Console.Write("Primeiro Valor: ");
            float p = float.Parse(Console.ReadLine()!);
            Console.Write("Segundo Valor: ");
            float s = float.Parse(Console.ReadLine()!);
            float resultado = p + s;

            Console.WriteLine($"\nO resultado é {p - s}");
            Console.ReadKey(); Menu();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("--SOMA--\n");
            Console.Write("Primeiro Valor: ");
            float p = float.Parse(Console.ReadLine()!);
            Console.Write("Segundo Valor: ");
            float s = float.Parse(Console.ReadLine()!);
            float resultado = p + s;

            Console.WriteLine($"\nO resultado é {p + s}");
            Console.ReadKey(); Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("--DIVISAO--\n");
            Console.Write("Primeiro Valor: ");
            float p = float.Parse(Console.ReadLine()!);
            Console.Write("Segundo Valor: ");
            float s = float.Parse(Console.ReadLine()!);
            float resultado = p + s;

            Console.WriteLine($"\nO resultado é {p / s}");
            Console.ReadKey(); Menu();
        }
        static void Multi()
        {
            Console.Clear();
            Console.WriteLine("--MULTIPLICAÇÃO--\n");
            Console.Write("Primeiro Valor: ");
            float p = float.Parse(Console.ReadLine()!);
            Console.Write("Segundo Valor: ");
            float s = float.Parse(Console.ReadLine()!);
            float resultado = p + s;

            Console.WriteLine($"\nO resultado é {p * s}");
            Console.ReadKey();
            Menu();
        }
    }
}