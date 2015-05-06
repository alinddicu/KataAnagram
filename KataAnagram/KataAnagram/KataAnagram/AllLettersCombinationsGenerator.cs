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
                .ToArray();

            var combinations = new Combinations<char>(set, 2);

            foreach (var c in combinations)
            {
                //for (int i = 0; i < set.Count(); i++)
                //{
                yield return string.Join(string.Empty, new[] { c[0], c[1] });
                //}
                //Console.WriteLine(String.Format("{{{0} {1} {2}}}", c[0], c[1], c[2]));
            }

            //return Enumerable.Empty<string>();
        }
    }
}