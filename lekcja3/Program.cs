using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[4];
            Console.WriteLine("ile żyje pszeciętny pies");
            tablica[0] = "A. Rok";
            tablica[1] = "B. od 10 do 13 lat";
            tablica[3] = "D. od 5 do 8";
            tablica[2] = "C. od 3 do 4";
            int i = 0;
            while (i < 4)
                Console.WriteLine(tablica[i++]);
            if (Console.ReadLine() == "B")

                Console.WriteLine("gratulacje wygrałeś 5.000$");
            else Console.WriteLine("błedna odpowiedz");

            Console.Read();
        }

        //int max = 0;
        //int[] tablica = new int[10];//tworzymy tablice liczb
        //Random random = new Random();//tworzymy generator liczb losowych

        //int i = 0; // tworzymy numerator
        //while (i < 10)// powtarzaj dopuki i<10
        //{
        //    tablica[i] = random.Next(0, 100);
        //    if(tablica[i]>max)
        //        max = tablica[i];
        //    Console.WriteLine(tablica[i]);
        //    i++;
        //}
        //Console.WriteLine($"Najwieksza wylosowana liczba jest {max}");
        //Console.Read();
    }
}
