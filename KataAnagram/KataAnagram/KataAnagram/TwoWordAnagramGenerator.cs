namespace KataAnagram
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NFluent;

    public class TwoWordAnagramGenerator
    {
        private static readonly WordDictionary WordDictionary = new WordDictionary();

        public IEnumerable<string> Generate(string baseWord)
        {
            var anagrams = new List<string>();

            var _allPossibleSubWords = new AllPossibleSubWordsGenerator().Generate(baseWord).ToList();

            foreach (var combination1 in _allPossibleSubWords)
            {
                foreach (var combination2 in _allPossibleSubWords)
                {
                    if (AreCombinationsComplementary(baseWord, combination1, combination2))
                    {
                        var anagram1 = combination1 + " " + combination2;
                        if (!anagrams.Contains(anagram1))
                        {
                            anagrams.Add(anagram1);
                        }

                        var anagram2 = combination1 + combination2;
                        if (!anagrams.Contains(anagram2) && WordDictionary.Contains(anagram2))
                        {
                            anagrams.Add(anagram2);
                        }
                    }
                }
            }

            return anagrams.Distinct();
        }

        private static bool AreCombinationsComplementary(string originalString, string combination1, string combination2)
        {
            var original = originalString.ToCharArray().ToList();
            var comb1 = combination1.ToCharArray().ToList();
            var comb2 = combination2.ToCharArray().ToList();
            var combConcatResult = comb1.Concat(comb2).ToList();

            //return original.Count == (comb1.Count + comb2.Count)
            //    && !original.Except(combConcatResult).Any()
            //    && !combConcatResult.Except(original).Any();

            return original.OrderBy(c => c).SequenceEqual(combConcatResult.OrderBy(c => c));
        }
    }
}