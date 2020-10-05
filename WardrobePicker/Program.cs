using System;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = { "shirt", "hoodie", "jeans", "hat", "dress" };
            string[] colors = { "red", "blue", "green", "black", "white" };
            string[] patterns = { "flowery", "striped", "plka dot", "circles", "checked" };
            Random rnd = new Random();
            int random = rnd.Next(0, wardrobe.Length);
            int random1 = rnd.Next(0, colors.Length);
            int random2 = rnd.Next(0, patterns.Length);            
            string outfit;
            bool correctanswer = false;
            Console.WriteLine("Do you need help with outfit picking?");
            while (!correctanswer)
            {
                outfit = Console.ReadLine().ToLower();

                if (outfit == "no")
                {
                    Console.WriteLine("farewell");
                    correctanswer = true;
                }
                else if (outfit == "yes")
                {
                    Console.WriteLine("Okey i will help u.");
                    Console.WriteLine($"Today you should wear {colors[random1]} {patterns[random2]} {wardrobe[random]} ");
                    correctanswer = true;
                }
                else Console.WriteLine("answer yes or no !!!!");


            }

        }
    }
}
