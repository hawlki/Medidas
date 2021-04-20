using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("           Medidas           ");
            Console.WriteLine("-----------------------------");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Escreva uma medida em metros: ");
            String medida = Console.ReadLine();
            Double metros = Convert.ToDouble(medida);
            Double quilometros = metros / 1000;
            Double centimetros = metros * 100;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"A medida {metros}m é igual a: ");
            Console.WriteLine($"{quilometros}km");
            Console.WriteLine($"{centimetros}cm");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("clique em uma tecla para finalizar...");
            Console.ReadKey();
            
            Console.Clear();
        }
    }
}
