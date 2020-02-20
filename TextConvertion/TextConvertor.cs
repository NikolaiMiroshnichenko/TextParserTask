using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextConvertion
{
    public class TextConvertor
    {
        public static string Convert()
        {
            using (FileStream fstream = File.OpenRead(@"C:\13.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string text = System.Text.Encoding.Default.GetString(array);
                return text;
            }
        }
    }
}
