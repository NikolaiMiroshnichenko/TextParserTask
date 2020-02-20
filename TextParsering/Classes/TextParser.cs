using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using TextConvertion;
using TextParsering.Interface;

namespace TextParsering.Classes
{
    public class TextParser
    {
        string text = File.ReadAllText(@"C:\13.txt");
        Regex regex = new Regex(@"(?<=[\.!\?])\s+");
        string[] sentences = regex.Split(text);

        foreach (var sentece in sentences)
            {
            }
    }
}
