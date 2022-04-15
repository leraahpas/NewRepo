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
                Console.WriteLine("1 - создание класса ");
                Console.WriteLine("2 - выход");
                string vibor = Console.ReadLine();
                switch (vibor)
                {
                    

                    case "1":
                        Schet B = new Schet();
                        B.Imput();
                        break;
                    case "2":
                        Exit = true;
                        break;
                }
                break;
            }
            while (Exit != true);
            Console.ReadKey();
        }
    }
}
 