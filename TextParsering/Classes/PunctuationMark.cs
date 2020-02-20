using System;
using System.Collections.Generic;
using System.Text;
using TextParsering.Interface;

namespace TextParsering.Classes
{
    public class PunctuationMark: ISentenceItem
    {
        public string Value { get; }
    }
}
