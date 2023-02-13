using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2calcularareafiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("FIGURAS GEOMETRICAS");
            Console.WriteLine("\t 1. PIRAMIDE");
             Console.WriteLine("\t 2. ESFERA");
             Console.WriteLine("\t 3. CONO");
            Console.WriteLine("\t 4. SALIR DEL PROGRAMA");
            byte geo;
            Console.WriteLine(" INGRESE UN NUMERO DEL 1-3 PARA SELECIONAR LA FIGURA GEOMETRICA ");

            geo = Convert.ToByte(Console.ReadLine());

            switch (geo)
            {
                case 1:
                    Console.WriteLine("\t haz elegido la figura de piramide"); 

                    int b, h;
                    Console.WriteLine("ingresar la base"); 
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingresar la altura"); 
                    h = int.Parse(Console.ReadLine());
                    double area = Math.Pow(b, 2) + 4 * 1 / 2.0 * b * h;
                    Console.WriteLine($"la superficie de la piramide es : {area}");
                    break;


                case 2:
                    Console.WriteLine("\t haz elegido la figura de esfera");
                    int R;
                    Console.WriteLine("ingresar el radio");
                    R = int.Parse(Console.ReadLine());
                    Console.Write("El area de la esfera es: " + 4 * Math.PI * R * R);
                    break;


                case 3:
                    Console.WriteLine("\t haz elegido la figura de el cono");
                    int x1, x2;

                    Console.WriteLine("ingresar el radio");
                    x1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("ingresar la generatriz");
                    x2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("El area del cono es: " + (Math.PI * x1 * (x1 + x2)));
                    break;
                case 4:
                     Environment.Exit(0); 
                     break;
                    

            }
            Console.ReadKey();
            

        }
    }
}