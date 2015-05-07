namespace KataAnagram
{
    using System.Collections.Generic;
    using System.Linq;
    using Combinatorics.Collections;

    public class AllPossibleSubWordsGenerator
    {
        private static readonly WordDictionary WordDictionary = new WordDictionary();

        private readonly HashSet<string> _subWords = new HashSet<string>();

        // with doc : http://www.codeproject.com/Articles/26050/Permutations-Combinations-and-Variations-using-C-G
        public IEnumerable<string> Generate(string originalString)
        {
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

                    var subWordCandidate = string.Join(string.Empty, vs.ToArray());
                    if (WordDictionary.Contains(subWordCandidate) && !_subWords.Contains(subWordCandidate))
                    {
                        _subWords.Add(subWordCandidate);
                    }
                }
            }

            return _subWords;
        }
    }
}