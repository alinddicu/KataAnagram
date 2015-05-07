namespace KataAnagram
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Combinatorics.Collections;

    public class AllLettersCombinationsGenerator
    {
        // with doc : http://www.codeproject.com/Articles/26050/Permutations-Combinations-and-Variations-using-C-G
        public IEnumerable<string> Generate(string originalString)
        {
            var results = new List<string>();

            var set = originalString
                .ToCharArray()
                .ToArray();

            for (int lowerIndex = 1; lowerIndex <= set.Count(); lowerIndex++)
            {
                var variations = new Variations<char>(set, lowerIndex, GenerateOption.WithoutRepetition);
                foreach (var v in variations)
                {
                    var vs = new List<char>();
                    for (int i = 0; i < lowerIndex; i++)
                    {
                        vs.Add(v[i]);
                    }

                    yield return string.Join(string.Empty, vs.ToArray());
                }
            }
        }
    }
}