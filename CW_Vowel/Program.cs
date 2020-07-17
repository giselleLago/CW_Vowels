using System;

namespace CW_Vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Kata();
            Console.WriteLine(a.GetVowelCount("Hola"));
            Console.ReadKey();
        }
    }
}
