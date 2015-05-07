namespace KataAnagram.V2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AllDictionaryWordsInOriginalWordFinder
    {
        private static WordDictionary WordDictionary = new WordDictionary();

        public IEnumerable<string> Find(string originalWord)
        {
            var originalWordOrderedChars = string.Join(string.Empty, originalWord.ToCharArray().OrderBy(o => o)).ToUpperInvariant();

            return WordDictionary
                    .Words
                    .Where(w => originalWordOrderedChars.IndexOf(string.Join(string.Empty, w.ToCharArray().OrderBy(o => o)).ToUpper()) > -1);
        }
    }
}