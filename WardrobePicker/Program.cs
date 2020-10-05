using System;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobeClothes = { "hoodie", "shirt", "jeans", "hat", "underwear" };
            string[] wardrobeColors = { "red", "green", "blue", "black", "yellow" };
            string[] wardrobePatterns = { "flowery", "striped", "polka dot", "circles", "checkered" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, wardrobeClothes.Length);
            int randomIndex2 = rnd.Next(0, wardrobeColors.Length);
            int randomIndex3 = rnd.Next(0, wardrobePatterns.Length);

            Console.WriteLine("Do you need any assistance on what to take from the wardrobe?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "no")
            {
                Console.WriteLine("Farewell.");
            }else if(answer == "yes")
            {
                Console.WriteLine($"Today you will wear {wardrobeColors[randomIndex2]} {wardrobePatterns[randomIndex3]} {wardrobeClothes[randomIndex]}");
            }else
            {
                Console.WriteLine("Sadly I cannot help you.");
            }

        }
    }
}
