namespace KataAnagram
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Combinatorics.Collections;

    public class AllLettersCombinationsGenerator
    {
        private StringBuilder _stringBuilder = new StringBuilder();
        private string _inputstring;

        private List<string> _allLettersCombinations = new List<string>();

        public IEnumerable<string> Generate(string originalString)
        {
            var set = originalString
                .ToCharArray()
                .Distinct()
                .ToArray();

            var permutations = new Permutations<char>(set);

            //permutations.

            return Enumerable.Empty<string>();
        }
    }
}