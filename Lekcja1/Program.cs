using System;

namespace Lekcja1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int w = 0;
            Console.WriteLine(w);
            Console.WriteLine(++w);
            Console.WriteLine(w++);

            Console.WriteLine(w);


            DateTime t = DateTime.Now;



            Console.WriteLine(t);

            Dnitygodnia dzien = Dnitygodnia.niedziela;
            if (dzien == Dnitygodnia.sobota)
                Console.WriteLine("udalosie");
            if (dzien == Dnitygodnia.niedziela)
                Console.WriteLine("cos innego");
            bool weekend = t.DayOfWeek == DayOfWeek.Saturday||t.DayOfWeek == DayOfWeek.Sunday;
            bool wakacje = t.Month==7||t.Month==8;
            
            bool swieta =t.Day == 20 & t.Month==8;
            Console.WriteLine(wakacje);
            Console.WriteLine(weekend);
            Console.WriteLine(swieta);
            Plec plec = Plec.Mezczyzna;

            if (plec == Plec.Kobieta)
                Console.WriteLine("wybierz toalete damska");
            else Console.WriteLine("wybierz toalete meska");

            if (!(weekend||wakacje||swieta))          
                
            Console.WriteLine("Idziemy");
            else
            Console.WriteLine("NIe idziemy");



            //Console.WriteLine(w++);
            //Console.WriteLine(w);
            //Console.WriteLine(++w);
            //Console.WriteLine(w);
            //Console.WriteLine(--w);
            //Console.WriteLine(w);
            //Console.WriteLine(w--);
            //Console.WriteLine(w);
            //Console.WriteLine(w--);
            //Console.WriteLine(w);
            //Console.WriteLine(w-=100);
            //Console.WriteLine(w);
            //Console.WriteLine(--w);
            //Console.WriteLine(w);
            //Console.WriteLine(w--);
            //Console.WriteLine(w);
            //Console.WriteLine(w++);
            //Console.WriteLine(w);
            //Console.WriteLine(++w);
            //Console.WriteLine(w);
            //Console.WriteLine(--w);
            //Console.WriteLine(w);
            Console.ReadLine();












        }
    }
}
//            bool x=true;

//            while (x)
//            {
//                string text = "błedny trujkąt";
//                int bokA;
//                int bokB;
//                int bokC;
//                Console.WriteLine("");
//                Console.WriteLine("podaj bok a");
//                bokA = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("podaj bok b");
//                bokB = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("podaj bok c");
//                bokC = Convert.ToInt32(Console.ReadLine());
//                if (bokA + bokB < bokC || bokA + bokC < bokB || bokB + bokC < bokA)
//                    Console.WriteLine(text);

//                else
//                    Console.WriteLine(bokA + bokB + bokC);
//                Console.WriteLine("czy chcesz zamknąć program");
//                x = Console.ReadLine() == "nie";
//            }
//            Console.ReadLine();
//        }
//    }
//}
