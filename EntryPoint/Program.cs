using Operations;
using System;

namespace EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 6;
            var b = 7;
            Console.WriteLine($"Hello World!\nWhat is {a}+{b}?");
            var addition = new Addition();
            var result = addition.Of(a, b);
            Console.WriteLine($"Answer: {result}");
        }
    }
}
