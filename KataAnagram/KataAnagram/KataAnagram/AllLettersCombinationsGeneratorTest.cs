namespace KataAnagram
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class AllLettersCombinationsGeneratorTest
    {
        private AllLettersCombinationsGenerator _generator;

        [TestInitialize]
        public void Initialize()
        {
            _generator = new AllLettersCombinationsGenerator();
        }

        [TestMethod]
        public void GivenWxyzWhenGenerateThenReturnAllCombinations()
        {
            var combinations = _generator.Generate("wxyz");

            Check.That(combinations).ContainsExactly(new[] { "w", "wx", "wxy", "wxyz", "wxz", "wy", "wyz", "wz", "x", "xy", "xyz", "xz", "y", "yz", "z" });
        }

        [TestMethod]
        public void GivenXyxWhenGenerateThenReturnAllCombinations()
        {
            var combinations = _generator.Generate("xyx").ToList();

            Check.That(combinations).ContainsExactly(new[] { "", "x", "y", "xy", "xx", "yx" });
        }
    }
}