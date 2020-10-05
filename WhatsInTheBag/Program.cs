using System;
using System.Dynamic;

namespace WhatsInTheBag
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bagItems = new string[5];
            int i = 0;
            while (i < bagItems.Length)
            {
                Console.WriteLine("What's in the bag?");
                bagItems[i] = Console.ReadLine();
                i++;
            }

            Random rnd = new Random();

            Console.WriteLine($"You will have to fight the zombies with a {bagItems[rnd.Next(0, bagItems.Length)]}");
        }
    }
}
