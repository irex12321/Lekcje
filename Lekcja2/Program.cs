using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grasz = "t";
            int P = 0; 
            int X, Y, Z;
            bool B = true;
            Random r = new Random();
            try
            {
                while (grasz == "t")

                {
                    P = 0;
                    while (B)
                    {

                        X = r.Next(1, 15);
                        Y = r.Next(1, 15);
                        Console.WriteLine($"ile to jest {X}*{Y}?");
                        Z = int.Parse(Console.ReadLine()); // Pobranie wartosci z konsoli i zmiana na liczbe
                        B = (Z == Y * X);
                        if (B)
                        {
                            Console.WriteLine("odpowiedz poprawna");
                            P++;
                        }
                        else
                            Console.WriteLine("odpowiedz niepoprawna");
                    }
                    Console.WriteLine($"zdobyłeś {P} punktów.Grasz dalej?");
                    grasz = Console.ReadLine();
                    B = true;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.Read();
           



        }

    }
}

