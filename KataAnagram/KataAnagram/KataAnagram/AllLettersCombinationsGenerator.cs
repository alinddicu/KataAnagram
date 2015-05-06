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

        // with doc : http://www.codeproject.com/Articles/26050/Permutations-Combinations-and-Variations-using-C-G
        public IEnumerable<string> Generate(string originalString)
        {
            var results = new List<string>();

            var set = originalString
                .ToCharArray()
                .ToArray();

            var variationsOf1 = new Variations<char>(set, 1, GenerateOption.WithoutRepetition);
            foreach (var v in variationsOf1)
            {
                results.Add(v[0].ToString());
            }

            var variationsOf2 = new Variations<char>(set, 2, GenerateOption.WithoutRepetition);
            foreach (var v in variationsOf2)
            {
                results.Add(string.Join(string.Empty, new[] { v[0], v[1] }));
            }

            var variationsOf3 = new Variations<char>(set, 3, GenerateOption.WithoutRepetition);
            foreach (var v in variationsOf3)
            {
                results.Add(string.Join(string.Empty, new[] { v[0], v[1], v[2] }));
            }

            return results.Distinct();
        }
    }
}