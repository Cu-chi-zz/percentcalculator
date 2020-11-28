using System;

namespace BlanchimentCalculator
{
    class Program
    {
        static void Main()
        {

            Console.Title = "Percentage Calculator";

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("]");

            Console.Write(" Pourcentage de blanchiment : \n> ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string Percent = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("]");

            Console.Write(" Somme à blanchir : \n> ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string WashValue = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            double MoneyLoss = 0;
            double MoneyToGive = 0;

            try
            {
                MoneyLoss = (double.Parse(Percent) / 100) * int.Parse(WashValue);
                MoneyToGive = int.Parse(WashValue) - MoneyLoss;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("-");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("]");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" Erreur : ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("les valeurs entrées ne sont pas des valeurs correctes.");
            }

            Console.WriteLine();

            Console.Write("Perte après blanchiment : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{MoneyLoss}");

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("Argent Propre : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{MoneyToGive}");
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("Appuyez sur une touche pour recommencer...");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}