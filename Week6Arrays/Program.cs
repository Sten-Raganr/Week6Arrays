using System;

namespace Week6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = { " win a million", "lose your smartphone", "fall in love", "buy youtube premium", "join a dark side " };
            Random rnd = new Random();
            int random = rnd.Next(0, predictions.Length);
            Console.WriteLine($"Today you will {predictions[random]}.");

        }
    }
}
