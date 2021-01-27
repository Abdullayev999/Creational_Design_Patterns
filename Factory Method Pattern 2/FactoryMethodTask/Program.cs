using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using Factory_Method_Pattern;

namespace Factory_Method_Pattern
{
    public class Program
    {
        public static ConsoleColor RandColor()
        {
           Random rand = new Random();
           int randNumber = rand.Next(10);

           switch (randNumber)
           {
                case 0:
                    return ConsoleColor.Blue;
                case 1:
                    return ConsoleColor.Red;
                case 2:
                    return ConsoleColor.Yellow;
                case 3:
                    return ConsoleColor.Green;
                case 4:
                    return ConsoleColor.Red;
                case 5:
                    return ConsoleColor.White;
                case 6:
                    return ConsoleColor.Magenta;
                case 7:
                    return ConsoleColor.Cyan;
                case 8:
                    return ConsoleColor.DarkBlue;
                case 9:
                    return ConsoleColor.DarkRed;
                default:
                    return ConsoleColor.DarkGreen;
            }
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Random rand = new Random();
            List<Figure> figures = new List<Figure>();
            List<IFigureFactory> figureCreartors = new List<IFigureFactory>();


            figureCreartors.Add(new IFactory());
            figureCreartors.Add(new OFactory());
            figureCreartors.Add(new SFactory());
            figureCreartors.Add(new LFactory());
            figureCreartors.Add(new JFactory());
            figureCreartors.Add(new TFactory());
            figureCreartors.Add(new ZFactory());


            for (int i = 0; i < 10; i++)
            {
                int randCreatorIndex = rand.Next(0, figureCreartors.Count);
                Figure figure= figureCreartors[randCreatorIndex].Create();
                figures.Add(figure);
            }

            foreach (var creartor in figures)
            {
                Console.Clear();
                Console.WriteLine($"Created {creartor.Name} figure\n");
                Console.WriteLine(creartor);
                Console.ResetColor();
                Thread.Sleep(500);
               
                
            }

           
        }
    }
}
