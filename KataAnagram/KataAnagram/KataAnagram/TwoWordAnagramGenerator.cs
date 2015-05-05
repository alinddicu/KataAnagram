﻿namespace KataAnagram
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TwoWordAnagramGenerator
    {
        private static readonly WordDictionary WordDictionary = new WordDictionary();
        private StringBuilder Output = new StringBuilder();
        private string Inputstring;

        private List<string> AllLettersCombinations = new List<string>();

        public IEnumerable<string> Generate(string originalString)
        {
            Inputstring = originalString;

            Combine();

            return Enumerable.Empty<string>();
        }

        public void Combine()
        {
            Combine(0);
        }

        // http://javahungry.blogspot.com/2014/02/algorithm-for-combinations-of-string-java-code-with-example.html
        private void Combine(int start)
        {
            for (int i = start; i < Inputstring.Length; ++i)
            {
                Output.Append(Inputstring[i]);
                AllLettersCombinations.Add(Output.ToString());
                if (i < Inputstring.Length)
                {
                    Combine(i + 1);
                }
                Output.Length = Output.Length - 1;
            }
        }
    }
}