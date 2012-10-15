using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obiekty
{
    class Program
    {
        static void Main(string[] args)
        {   
            Obiekt ob = new Obiekt();
            ob.Drukuj();
            Console.WriteLine("A");
            Console.ReadKey();
        }
    }
    class Obiekt
    {
        public void Drukuj()
        {
            Console.WriteLine("B");
        }
    }
}
