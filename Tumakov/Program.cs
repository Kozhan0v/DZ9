using System;
using Tumakov.Classes;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 10.1
            Console.WriteLine("Упражнение 10.1");

            ACipher aCipher = new ACipher();

            Console.WriteLine(aCipher.Encode("Привет я 1"));
            Console.WriteLine(aCipher.Decode("Рсйгёу а 1"));


            BCipher bCipher = new BCipher();

            Console.WriteLine(bCipher.Encode("Привет! 1 а я в"));
            Console.WriteLine(bCipher.Decode("Поцэъм! 1 я а э"));
        }
    }
}
