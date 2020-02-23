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
                foreach (var si in item.SentenceItems)
                {
                    Console.WriteLine(si.Value);
                }
            }
            Console.ReadKey();
        }
    }
}
