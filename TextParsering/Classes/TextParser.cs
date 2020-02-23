using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using TextParsering.Interface;

namespace TextParsering.Classes
{
    public class TextParser
    {
        public List<Sentence> SomeMeth()
        {
            string text = File.ReadAllText(@"C:\13.txt");
            Regex regex = new Regex(@"(?<=[\.!\?])\s+");
            string[] sentences = regex.Split(text);
            List<Sentence> sentencesList = new List<Sentence>();
            foreach (var sentence in sentences)
            {
                string[] words = Regex.Split(sentence, @"[\s.,;]+");
                List<string> punctuationMarks = new List<string>();
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (Regex.IsMatch(sentence[i].ToString(), @"[;,.!?\\-]"))
                    {
                        punctuationMarks.Add(sentence[i].ToString());
                    }
                }
                List<string> digits = new List<string>();
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (Regex.IsMatch(sentence[i].ToString(), @"[;,.!?\\-]"))
                    {
                        digits.Add(sentence[i].ToString());
                    }
                }

                var listOfWords = new List<Word>();
                var listOfPM = new List<PunctuationMark>();
                var listOfDigits = new List<Digit>();

                foreach (var item in words)
                {
                    listOfWords.Add(new Word { Value = item });
                }
                foreach (var item in punctuationMarks)
                {
                    listOfPM.Add(new PunctuationMark { Value = item });
                }
                foreach (var item in digits)
                {
                    listOfDigits.Add(new Digit { Value = item });
                }

                List<ISentenceItem> sentenceItems = new List<ISentenceItem>();
                sentenceItems.AddRange(listOfWords);
                sentenceItems.AddRange(listOfPM);
                sentenceItems.AddRange(listOfDigits);

                Sentence senten = new Sentence { SentenceItems = sentenceItems };
                sentencesList.Add(senten);
            }
            return sentencesList;
        }
    }
}
