using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            string answer = Console.ReadLine();

            switch (answer) 
            {
                case "Math":
                    Console.WriteLine("Math is great!");
                    break;
                case "English":
                    Console.WriteLine("English is so useful!");
                    break;
                case "History":
                    Console.WriteLine("Thats my favorite too!");
                    break;
                case "Science":
                    Console.WriteLine("Blinding me with science!");
                    break;
                case "Spanish":
                    Console.WriteLine("Eso es impresionante!");
                    break;
                default:
                    Console.WriteLine("Never heard of that one!");
                    break;

            }

        }
    }
}
