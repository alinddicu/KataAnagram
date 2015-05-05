using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataAnagram
{
    public class AllLettersCombinationsGenerator
    {
        private StringBuilder Output = new StringBuilder();
        private string Inputstring;

        private List<string> AllLettersCombinations = new List<string>();

        public IEnumerable<string> Generate(string originalString)
        {
            Inputstring = originalString;

            Combine();

            return AllLettersCombinations;
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