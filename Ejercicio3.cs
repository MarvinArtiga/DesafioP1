using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

         //declaracion de variables
            int op;
            string a;
            string b;

            Console.WriteLine("Digite 1 si su compuerta es XOR:");
            Console.WriteLine("Digite 2 si su compuerta es NAND:");
            op=int.Parse(Console.ReadLine());
            
            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite el valor de a: ");
                    a = Console.ReadLine();
                    Console.WriteLine("Digitar el valor de b: ");
                    b = Console.ReadLine();
                    if (( a=="V" || a=="v") && (b=="V"|| b=="v"))
                    {
                        Console.WriteLine("El valor de salida es:  F ");

                    }
                    if ((a == "V" || a == "v") && (b == "F" || b == "f"))
                    {
                        Console.WriteLine("El valor de salida es: V ");
                    }
                    if ((a == "F" || a == "f") && (b == "V" || b == "v"))
                    {
                        Console.WriteLine("El valor de salida es: V ");
                    }
                    if((a=="F"||a=="f")&& (b=="F"||b=="f"))
                    {
                        Console.WriteLine("El valor de salida es: F ");
                    }
                    break;
                case 2:
                    Console.WriteLine("Digite el valor de a: ");
                    a = Console.ReadLine();
                    Console.WriteLine("Digitar el valor de b: ");
                    b = Console.ReadLine();
                    if((a=="V"|| a=="v")&& (b=="V" || b=="v"))
                    {
                        Console.WriteLine("El valor de salida es: F ");
                    }
                    if((a=="V" ||a=="v")&& (b=="F"||b=="f"))
                    {
                        Console.WriteLine("El valor de salida es: V ");
                    }
                    if((a=="F"|| a=="f")&& (b=="V"|| b=="v"))
                    {
                        Console.WriteLine("El valor de salida es: V ");
                    }
                    if((a=="F"||a=="f")&& (b=="F"||b=="f"))
                        {
                        Console.WriteLine("El valor de salida es: V ");
                    }

                    break;
            }
                



            Console.ReadLine();
        }
    }
}
