using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataAnagram
{
    public class AllLettersCombinationsGenerator
    {
        private StringBuilder _stringBuilder = new StringBuilder();
        private string _inputstring;

        private List<string> _allLettersCombinations = new List<string>();

        public IEnumerable<string> Generate(string originalString)
        {
            _inputstring = originalString;

            Combine(0);

            return _allLettersCombinations;
        }

        // http://javahungry.blogspot.com/2014/02/algorithm-for-combinations-of-string-java-code-with-example.html
        private void Combine(int start)
        {
            for (int i = start; i < _inputstring.Length; ++i)
            {
                _stringBuilder.Append(_inputstring[i]);
                _allLettersCombinations.Add(_stringBuilder.ToString());
                if (i < _inputstring.Length)
                {
                    Combine(i + 1);
                }
                _stringBuilder.Length = _stringBuilder.Length - 1;
            }
        }
    }
}