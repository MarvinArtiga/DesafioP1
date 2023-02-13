﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistenciaElectronicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //by David Alejandro 
            //Date: 30012022
            //Console.WindowHeight = 100; // alto de la ventana
            //Console.WindowWidth = 100;  //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Title = ("Calculadora de Resistencias");

            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t----Calculadora de 4 bandas en Resistencia Electronicas---- ");
            Console.WriteLine("\t                                     ~ Ω ~");
            Console.WriteLine("\t             Puedes escribir el numero de opcion segun el color.");

            string xb1 = "0", xb2 = "0", xrt = "0";
            double xb3 = 0, respuesta1 = 0, rt;
            int respuesta = 0, tb4 = 0;
            int k = 1000;
            int m = 1000000;
            int g = 10000000;

            string opb, r1;          //Aca guardo las Variables de las opciones del primer (r1) y segundo (opb1) Switch
            Boolean continua = true; //Este boolean es para regresar en el primer Switch (r1) 

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            do
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("\t          ----Calculadora de 4 bandas en Resistencia Electronicas---- ");
                Console.WriteLine("\t                                     ~ Ω ~");
                Console.WriteLine("\t           Puedes escribir el (NUMERO) de banda que deseas ingresar");

                Console.WriteLine("\n\t");
                Console.WriteLine("\t Banda 1?");
                Console.WriteLine("\t Banda 2?");
                Console.WriteLine("\t Banda 3?");
                Console.WriteLine("\t Banda 4?");
                Console.WriteLine("\t Escribe 'R' para ver la (RESPUESTA)");

                r1 = Console.ReadLine();
                Console.Clear();

                switch (r1) //En esta variable guardo las opciones del primer Menu.
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("  ═════════════════════════════════════════════════════════════");
                        Console.WriteLine("        ║BANDA 1║   ║   ?   ║   ║   ?   ║   ║   ?   ║");
                        Console.WriteLine("  ═════════════════════════════════════════════════════════════");
                        Console.WriteLine("  ╔═  Escribe el (NUMERO) correspondiente al 'Color' la banda");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("╔═╩═╗");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;       //Color de la banda
                        Console.WriteLine("║   ║ - 1).  Negro    : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;  //Color de la banda
                        Console.WriteLine("║   ║ - 2).  Marron   : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Red;         //Color de la banda
                        Console.WriteLine("║   ║ - 3).  Rojo     : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkRed;     //Color de la banda
                        Console.WriteLine("║   ║ - 4).  Naranja  : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;      //Color de la banda
                        Console.WriteLine("║   ║ - 5).  Amarillo : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;       //Color de la banda
                        Console.WriteLine("║   ║ - 6).  Verde    : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Blue;        //Color de la banda
                        Console.WriteLine("║   ║ - 7).  Azul     : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; //Color de la banda
                        Console.WriteLine("║   ║ - 8). Morado    : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Gray;        //Color de la banda
                        Console.WriteLine("║   ║ - 9).  Gris     : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("║   ║ - 10). Blanco   : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("╚═╦═╝");

                        opb = (Console.ReadLine());
                        Console.Clear();

                        switch (opb)
                        {
                            case "1":
                                xb1 = "0";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 0");
                                break;

                            case "2":
                                xb1 = "1";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 1");
                                break;

                            case "3":
                                xb1 = "2";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 2");
                                break;

                            case "4":
                                xb1 = "3";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 3");
                                break;

                            case "5":
                                xb1 = "4";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 4");
                                break;

                            case "6":
                                xb1 = "5";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 5");
                                break;

                            case "7":
                                xb1 = "6";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 6");
                                break;

                            case "8":
                                xb1 = "7";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 7");
                                break;

                            case "9":
                                xb1 = "8";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 8");
                                break;

                            case "10":
                                xb1 = "9";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 9");
                                break;

                            default:
                                Console.WriteLine("\n");
                                Console.WriteLine("\tFavor ingresa una opcion valida");
                                break;
                        }

                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("  ═════════════════════════════════════════════════════════════");
                        Console.WriteLine("        ║   " + xb1 + "   ║   ║BANDA 2║   ║   ?   ║   ║   ?   ║");
                        Console.WriteLine("  ═════════════════════════════════════════════════════════════");
                        Console.WriteLine("  ╔═  Escribe el (NUMERO) correspondiente al 'Color' la banda");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("╔═╩═╗");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;       //Color de la banda
                        Console.WriteLine("║   ║ - 1).  Negro    : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;  //Color de la banda
                        Console.WriteLine("║   ║ - 2).  Marron   : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Red;         //Color de la banda
                        Console.WriteLine("║   ║ - 3).  Rojo     : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkRed;     //Color de la banda
                        Console.WriteLine("║   ║ - 4).  Naranja  : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;      //Color de la banda
                        Console.WriteLine("║   ║ - 5).  Amarillo : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;       //Color de la banda
                        Console.WriteLine("║   ║ - 6).  Verde    : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Blue;        //Color de la banda
                        Console.WriteLine("║   ║ - 7).  Azul     : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; //Color de la banda
                        Console.WriteLine("║   ║ - 8). Morado    : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Gray;        //Color de la banda
                        Console.WriteLine("║   ║ - 9).  Gris     : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("║   ║ - 10). Blanco   : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("╚═╦═╝");

                        opb = (Console.ReadLine());
                        Console.Clear();

                        switch (opb)
                        {
                            case "1":
                                xb2 = "0";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 0");
                                break;

                            case "2":
                                xb2 = "1";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 1");
                                break;

                            case "3":
                                xb2 = "2";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 2");
                                break;

                            case "4":
                                xb2 = "3";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 3");
                                break;

                            case "5":
                                xb2 = "4";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 4");
                                break;

                            case "6":
                                xb2 = "5";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 5");
                                break;

                            case "7":
                                xb2 = "6";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 6");
                                break;

                            case "8":
                                xb2 = "7";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 7");
                                break;

                            case "9":
                                xb2 = "8";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 8");
                                break;

                            case "10":
                                xb2 = "9";
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 9");
                                break;

                            default:
                                Console.WriteLine("\n");
                                Console.WriteLine("\tFavor ingresa una opcion valida");
                                break;
                        }

                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("  ═════════════════════════════════════════════════════════════");
                        Console.WriteLine("        ║" + xb1 + "║   ║" + xb2 + "║   ║BANDA 3║   ║   ?   ║");
                        Console.WriteLine("  ═════════════════════════════════════════════════════════════");
                        Console.WriteLine("  ╔═  Escribe el (NUMERO) correspondiente al 'Color' la banda");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("╔═╩═╗");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;       //Color de la banda
                        Console.WriteLine("║   ║ - 1).  Negro    : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;  //Color de la banda
                        Console.WriteLine("║   ║ - 2).  Marron   : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Red;         //Color de la banda
                        Console.WriteLine("║   ║ - 3).  Rojo     : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkRed;     //Color de la banda
                        Console.WriteLine("║   ║ - 4).  Naranja  : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;      //Color de la banda
                        Console.WriteLine("║   ║ - 5).  Amarillo : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;       //Color de la banda
                        Console.WriteLine("║   ║ - 6).  Verde    : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Blue;        //Color de la banda
                        Console.WriteLine("║   ║ - 7).  Azul     : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta; //Color de la banda
                        Console.WriteLine("║   ║ - 8). Morado    : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Gray;        //Color de la banda
                        Console.WriteLine("║   ║ - 9).  Gris     : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("║   ║ - 10). Blanco   : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("║   ║ - 11). Dorado   : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("║   ║ - 12). Plateado : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("╚═╦═╝");

                        opb = (Console.ReadLine());
                        Console.Clear();

                        switch (opb)
                        {
                            case "1":
                                xb3 = 1;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 1");
                                break;

                            case "2":
                                xb3 = 10;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 10");
                                break;

                            case "3":
                                xb3 = 100;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 100");
                                break;

                            case "4":
                                xb3 = 1000;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 1,000");
                                break;

                            case "5":
                                xb3 = 10000;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 10,000");
                                break;

                            case "6":
                                xb3 = 100000;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 100,000");
                                break;

                            case "7":
                                xb3 = 1000000;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 1,000,000");
                                break;

                            case "8":
                                xb3 = 10000000;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 10,000,000");
                                break;

                            case "9":
                                xb3 = 100000000;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 100,000,000");
                                break;

                            case "10":
                                xb3 = 1000000000;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 1,000,000,000");
                                break;

                            case "11":
                                xb3 = 0.1;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 0.1");
                                break;

                            case "12":
                                xb3 = 0.01;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: 0.01");
                                break;


                            default:
                                Console.WriteLine("\n");
                                Console.WriteLine("\tFavor ingresa una opcion valida");
                                break;
                        }
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("  ═════════════════════════════════════════════════════════════");
                        Console.WriteLine("        ║" + xb1 + "║   ║" + xb2 + "║   ║" + xb3 + "║   ║BANDA 4║");
                        Console.WriteLine("  ═════════════════════════════════════════════════════════════");
                        Console.WriteLine("  ╔═  Escribe el (NUMERO) correspondiente al 'Color' la banda");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("╔═╩═╗");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;  //Color de la banda
                        Console.WriteLine("║   ║ - 1). Marron    : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Red;         //Color de la banda
                        Console.WriteLine("║   ║ - 2).  Rojo     : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("║   ║ - 3).  Dorado   : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("║   ║ - 4). Plateado  : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("║   ║ - 5). Sin BANDA : ");

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;       //Color de la banda
                        Console.WriteLine("╚═╦═╝");

                        opb = (Console.ReadLine());
                        Console.Clear();

                        switch (opb)
                        {
                            case "1":
                                tb4 = 1;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: ±1%");
                                break;

                            case "2":
                                tb4 = 2;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: ±2%");
                                break;

                            case "3":
                                tb4 = 5;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: ±5%");
                                break;

                            case "4":
                                tb4 = 10;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: ±10%");
                                break;

                            case "5":
                                tb4 = 10;
                                Console.WriteLine("\n");
                                Console.WriteLine("\tValor de: ±20%");
                                break;

                            default:
                                Console.WriteLine("\n");
                                Console.WriteLine("\tFavor ingresa una opcion valida");
                                break;

                        }
                        break;

                    case "r":
                    case "R":
                        continua = false;
                        break;

                    default:
                        Console.WriteLine("\n\t");
                        Console.WriteLine("\tFavor ingresa una opcion valida");
                        break;
                }
            }
            while (continua);
            Console.WriteLine("\n\t");
            Console.WriteLine("\t ----Calculadora de 4 bandas en Resistencia Electronicas---- ");
            Console.WriteLine("\t                             ~ Ω ~");
            Console.Write("\n\n");
            Console.WriteLine("\t\tLos datos son: " + xb1 + " - " + xb2 + " * " + xb3 + " Tolerancia de ±" + tb4 + "%");
            xrt = xb1 + xb2;
            respuesta = Convert.ToInt32(xrt); //respuesta que es una string que le asigno la respuesta entera de la conquenacion de xb1 y xb2
            respuesta1 = respuesta * xb3;     //Genero otra var. respuesta, para operar con un entero con entero
            rt = respuesta1;

            if (rt < k)
            {
                Console.WriteLine("\t\tLa (RESITENCIA) tiene un valor de: ═╣ " + rt + " homs. ╠═");
            }
            else if (rt >= k && rt < m)
            {
                Console.WriteLine("\t\tLa (RESITENCIA) tiene un valor de: ═╣ " + rt / 1000 + "K homs. ╠═");
            }
            else if (rt >= m && rt < g)
            {
                Console.WriteLine("\t\tLa (RESITENCIA) tiene un valor de: ═╣ " + rt / 1000000 + "M homs. ╠═");
            }
            else if (rt >= g)
            {
                Console.WriteLine("\t\tLa (RESITENCIA) tiene un valor de: ═╣ " + rt / 10000000 + "G homs. ╠═");
            }

            Console.Write("\n");
            Console.Write("\t\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t*                                           *");
            Console.WriteLine("\t\t*       Este programa fue diseñado por:     *");
            Console.WriteLine("\t\t*                                           *");
            Console.WriteLine("\t\t*              David Alejandro              *");
            Console.WriteLine("\t\t*   ***Ejercicio V. del trabajo grupal***   *");
            Console.WriteLine("\t\t*            DESAFIO PRACTICO #1            *");
            Console.WriteLine("\t\t*                                           *");
            Console.Write("\t\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\t\t");

            Console.ReadKey();

        }
    }
}