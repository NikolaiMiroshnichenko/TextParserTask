using System;
using TextParsering.Classes;
using TextParsering.Interface;

namespace TextParserTask
{
    class Program
    {
        static void Main(string[] args)
        {
            TextParser tp = new TextParser();
            var list = tp.SomeMeth();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
