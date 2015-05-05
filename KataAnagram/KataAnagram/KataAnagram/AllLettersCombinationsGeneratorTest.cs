﻿namespace KataAnagram
{
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
    }
}