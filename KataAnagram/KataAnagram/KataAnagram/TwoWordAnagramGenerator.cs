namespace KataAnagram
{
    using System.Collections.Generic;
    using System.Linq;

    public class TwoWordAnagramGenerator
    {
        private static readonly WordDictionary WordDictionary = new WordDictionary();

        public IEnumerable<string> Generate(string originalString)
        {
            return Enumerable.Empty<string>();
        }
    }
}