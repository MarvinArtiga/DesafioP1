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

                    double b, h;
                    Console.WriteLine("ingresar la base"); 
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingresar la altura"); 
                    h = double.Parse(Console.ReadLine());
                    double area = Math.Pow(b, 2) + 4 * 1 / 2.0 * b * h;
                    Console.WriteLine($"la superficie de la piramide es :"+ Math.Round(area,2));
                    break;


                case 2:
                    Console.WriteLine("\t haz elegido la figura de esfera");
                    double R,R2;
                    Console.WriteLine("ingresar el radio");
                    R = double.Parse(Console.ReadLine());
                    R2 = (4 * Math.PI * R * R);
                    Console.Write("El area de la esfera es: " + Math.Round(R2, 2));
                    break;

                    
                case 3:
                    Console.WriteLine("\t haz elegido la figura de el cono");
                    double x1, x2, r3;

                    Console.WriteLine("ingresar el radio");
                    x1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("ingresar la generatriz");
                    x2 = double.Parse(Console.ReadLine());

                    r3 = Math.PI * x1 * (x1 + x2);

                    Console.WriteLine("El area del cono es: " + Math.Round(r3, 2));
                    break;
                case 4:
                     Environment.Exit(0); 
                     break;
                    

            }
            Console.ReadKey();
            

        }
    }
}