using System;
using System.Collections.Generic;
using System.Text;

namespace pr1
{
    class Schet
    {
        private string name;
        private int nomer;
        private double symma;

        public void Imput()
        {
            Console.WriteLine("Введите название: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите номер счета: ");
            nomer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость: ");
            symma = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}  {1}  {2}", name, nomer, symma);
        }

        public Schet (string name, int nomer, double symma)
        {
            this.name = name;
            this.nomer = nomer;
            this.symma = symma;
        }

     
    }
}
