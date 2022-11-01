using System;

namespace Lektionsövning
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(10, " Pelle", "Pellson", "PelPellson@gmail.com");
            Customer C2 = new Customer(11, " Palle", "Pallson", "PalPalsson@gmail.com");
            Customer C3 = new Customer();

            Console.WriteLine(C1);
            Console.WriteLine(C2);
            Console.WriteLine(C3);
        }
    }
}
