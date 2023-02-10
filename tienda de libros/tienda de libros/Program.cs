using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Salida_Entrada_Pantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Marvin Edgardo Artiga Gonzalez
            //12/02/2023
            // monto total de venta de libros

            Console.WindowHeight = 25; // alto de la ventana
            Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            //declaracion de variables
            int book,noteB,pencil;
            
            //entrada de datos

            Console.WriteLine("Ingresar libros vendidos");
            book =int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar cuadernos vendidos");
            noteB = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar plumas vendidos");
            pencil = int.Parse(Console.ReadLine());

            Console.WriteLine("\t");
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("Libros vendidos: "+ book);
            Console.WriteLine("Cuadernos vendidos: " + noteB);
            Console.WriteLine("Plumas vendidas: " + pencil);

            //calculos
            double bookT = book*100.00;
            double noteBT = noteB*31.00;
            double pencilT = pencil * 7.05;
            double monto = bookT+noteBT+pencilT;

            //muestra de resultado "monto total"
            Console.WriteLine("\t");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Monto total: "+monto+"$");
            Console.WriteLine("\t");
            

            //Pantalla de presentacion
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t* *");
            Console.WriteLine("\t* Este programa fue diseñado por: *");
            Console.WriteLine("\t* *");
            Console.WriteLine("\t* Grupo: Los ingenieros *");
            Console.WriteLine("\t* *");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            
            Console.ReadKey();

        }
    }
}