namespace KataAnagram.V2
{
    using System.Collections.Generic;
    using System.Linq;

    public class TwoWordAnagramGenerator
    {
        private static readonly WordDictionary WordDictionary = new WordDictionary();
        private static readonly AllDictionaryWordsInOriginalWordFinder Finder = new AllDictionaryWordsInOriginalWordFinder();

        public IEnumerable<string> Generate(string baseWord)
        {
            var anagrams = new List<string>();

            var _allDictionarySubWords = new AllDictionaryWordsInOriginalWordFinder().Find(baseWord).ToList();

            foreach (var subWord1 in _allDictionarySubWords)
            {
                foreach (var subWord2 in _allDictionarySubWords)
                {
                    if (AreCombinationsComplementary(baseWord, subWord1, subWord2))
                    {
                        var anagram1 = subWord1 + " " + subWord2;
                        if (!anagrams.Contains(anagram1))
                        {
                            anagrams.Add(anagram1);
                        }

                        var anagram2 = subWord1 + subWord2;
                        if (!anagrams.Contains(anagram2) && WordDictionary.Contains(anagram2))
                        {
                            anagrams.Add(anagram2);
                        }
                    }
                }
            }

            return anagrams;
        }

        private static bool AreCombinationsComplementary(string originalString, string combination1, string combination2)
        {
            var original = originalString.ToCharArray().ToList();
            var comb1 = combination1.ToCharArray().ToList();
            var comb2 = combination2.ToCharArray().ToList();
            var combConcatResult = comb1.Concat(comb2).ToList();

            return original.OrderBy(c => c).SequenceEqual(combConcatResult.OrderBy(c => c));
        }
    }
}