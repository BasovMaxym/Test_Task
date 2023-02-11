using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UniqueSymbol
{
    internal class TextHandler
    {

        private string pathFile = string.Empty;

        public TextHandler() { }

        public TextHandler(string path)
        {
            PathFile = path;
        }

        public string PathFile
        {
            get { return pathFile; }
            set
            {
                if (File.Exists(value))
                    pathFile = value;
                else
                    Console.WriteLine("File doesn't exist! Set path to the file!");
            }
        }

        public string GetUniqueCharFromText()
        {
            if (PathFile != string.Empty)
            {
                StringBuilder uniqueChars = new StringBuilder();
                string text = File.ReadAllText(PathFile);
                string pattern = @"[\w']+";
                foreach (Match word in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
                {
                    char unCh = GetUniqueChar(word.Value);
                    if (unCh != '\0')
                        uniqueChars.Append(unCh);
                }

                return GetUniqueChar(uniqueChars.ToString()).ToString();
            }
            else
            {
                return "Set path to the file and try again!";
            }
        }
        private char GetUniqueChar(string word)
        {
            foreach (char item in word)
            {
                if (word.Count(ch => ch == item) == 1)
                    return item;
            }
            return '\0';
        }
    }
}
