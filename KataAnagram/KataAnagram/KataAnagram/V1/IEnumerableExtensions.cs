using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataAnagram
{
    public static class IEnumerableExtensions
    {
        private static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> source, int n)
        {
            if (n == 0)
                yield return Enumerable.Empty<T>();

            int count = 1;
            foreach (T item in source)
            {
                foreach (var innerSequence in source.Skip(count).Combinations(n - 1))
                {
                    yield return new T[] { item }.Concat(innerSequence);
                }
                count++;
            }
        }

        public static IEnumerable<IEnumerable<T>> AllCombinations<T>(this IList<T> source)
        {
            IEnumerable<IEnumerable<T>> output = Enumerable.Empty<IEnumerable<T>>();
            for (int i = 0; i < source.Count; i++)
            {
                output = output.Concat(source.Combinations(i));
            }
            return output;
        }
    }
}