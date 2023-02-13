using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_estructura_secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 25;
            Console.WindowWidth = 70;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "perimetro de una elipse";
            Console.Write("\nEjercicio6");
            Console.Write("\n\n");


            double a, b, p, p2, pul, z ;
            
            Console.Write("Ingrese el primer valor: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el primer valor: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("\n\n");
            p = ((3 * a + b) * (3 * b + a));

            p2 = 3 * (a + b);

            p = Math.PI * (p2 - Math.Sqrt(p));

            z = (p * 1 / 10);

            pul = p * (10 / 1)*(1/25.4);

            Console.Write("Respuesta en milimetros:... " + p);
            Console.Write("\n");
            Console.Write("Respuesta en centimetros:... " + z);
            Console.Write("\n");
            Console.Write("Respuesta en pulgadas:... " + pul);
            Console.Write("\n\n");

            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
    }
}
