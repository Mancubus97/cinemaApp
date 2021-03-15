using System;

namespace CinemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name: ");
            //var name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");
            //Patrick doe is hoofdletter ;

            class addAccount(username, password){
                accountList.Add(username, password);
            }

            Dictionary<string, string> accountList = new Dictionary<string, string>();
            addAccount("user1", "password123");
            Console.WriteLine(accountList);
        }
    }
}