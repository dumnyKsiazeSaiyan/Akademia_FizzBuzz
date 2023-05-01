using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {

        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            while (true)
            {
                Console.Write("\nZagrajmy w FizzBuzz. \nPodaj liczbę: ");

                float number = GetNumber();

                Console.WriteLine(fizzBuzz.ReturnFizzBuzz(number) + "\n");
                Console.WriteLine("Wciśnij 'X' aby zakończyć program lub kliknij dowlny znak aby zacząć od nowa.");

                EndProgram();
            }
        }

        private static void EndProgram()
        {
            string endProgram;
            endProgram = Console.ReadLine();

            if (endProgram.ToUpper() == "X")
                Environment.Exit(0);
        }

        static float GetNumber()
        {
            while (true)
            {
                if (!float.TryParse(Console.ReadLine(), out float userNumber))
                {
                    Console.WriteLine("Podana nieprawidłowy znak. Spróbój jeszcze raz.");
                    continue;
                }
                return userNumber;
            }
        }
    }
}
