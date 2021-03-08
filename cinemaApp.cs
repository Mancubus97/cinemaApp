using System;

namespace CinemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}.");
        }
    }
}