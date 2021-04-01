using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;



namespace NUnitTestProject1
{


    [TestFixture]
    public class SolutionTest
    {
        [Test]

        public void SampleTest()
        {
            Assert.AreEqual(new List<string> { "a" }, CodeWars.Anagrams("a", new List<string> { "a", "b", "c", "d" }));
            Assert.AreEqual(new List<string> { "carer", "arcre", "carre" }, CodeWars.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }

        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(new List<string> { "ab", "ba" }, CodeWars.Anagrams("ab", new List<string> { "ab", "aa", "bb", "cc", "ac", "bc", "cd", "ba" }));
            Assert.AreEqual(new List<string> { "aabb", "bbaa", "abab", "baba", "baab" }, CodeWars.Anagrams("abba", new List<string> { "aabb", "bbaa", "abcd", "abbba", "baaab", "abbab", "abbaa", "babaa", "abab", "baba", "baab" }));
            Assert.AreEqual(new List<string> { }, CodeWars.Anagrams("big", new List<string> { "gig", "dib", "bid", "biig" }));
        }

        [Test]
        public void EdgeTest()
        {
            Assert.AreEqual(new List<string>(), CodeWars.Anagrams("dddddd", new List<string> { "xxxxx" }));
            Assert.AreEqual(new List<string>(), CodeWars.Anagrams("ddddddddddd", new List<string> { "nnnnnnnnnn" }));
            Assert.AreEqual(new List<string>(), CodeWars.Anagrams("ln", new List<string> { "cx" }));
        }

        private static Random rnd = new Random();

        private static List<string> solution(string word, List<string> words)
        {
            // Hash of the count of each character in word
            Dictionary<char, int> wordCount = word.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count(c => c == c));

            // Filter words due to the following predicate
            return words.Where(w =>
            {
                // Hash of the count of each character of a word in words
                Dictionary<char, int> wCount = w.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count(c => c == c));

                // Check if the two hashes are equal
                return wCount.Count == wordCount.Count && !wCount.Except(wordCount).Any();
            }).ToList();
        }

        private static string generateWord() =>
          String.Concat(new char[rnd.Next(2, 12)].Select(_ => (char)rnd.Next(97, 123)));

        [Test]
        public void RandomTest()
        {
            const int Tests = 1000;


            for (int i = 0; i < Tests; ++i)
            {
               
                    string word = generateWord();
                    List<string> words = new string[rnd.Next(3, 20)].Select(_ => rnd.Next(0, 2) == 0 ? String.Concat(word.OrderBy(__ => rnd.Next())) : generateWord()).ToList();

                    List<string> expected = solution(word, words);
                    List<string> actual = CodeWars.Anagrams(word, words);
                try
                {
                    Assert.AreEqual(expected, actual);
                }
                catch (Exception ex)
                {
                    foreach(string wrd in words)
                    {
                        Console.WriteLine(wrd);
                    }


                }
            }


        }
    }
}