using System;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            do
            {
                Console.WriteLine("1 - первое задание. ");
                Console.WriteLine("2 - второе задание.");
                string vibor = Console.ReadLine();
                switch (vibor)
                {
                    

                    case "2":
                        Schet B = new Schet();
                        B.Imput();
                        break;
                }
                break;
            }
            while (Exit != true);
            Console.ReadKey()
        }
    }
}
 