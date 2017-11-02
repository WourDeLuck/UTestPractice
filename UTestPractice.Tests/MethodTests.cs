using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UTestPractice.Tests
{
    [TestFixture]
    public class MethodTests
    {
        [TestCase]
        public void Search_For_The_Maximum_Value_Recursively_Test()
        {
            DifferentAlgorhytms alg = new DifferentAlgorhytms();
            int[] array = { 5, 2, 0, 3, 19, 10, 34, 2, 1 };

            var res = alg.RecursiveSearch(array, 0, 0);

            Assert.AreEqual(34, res);
        }

        [TestCase]
        public void Concatenate_Sort_And_Delete_Duplicates_From_String_Test()
        {
            DifferentAlgorhytms alg = new DifferentAlgorhytms();
            string str1 = "hello";
            string str2 = "you";

            var answer = alg.ConcatenateString(str1, str2);

            Assert.AreEqual("ehlouy", answer);
        }

        [TestCase("mine", "not")]
        [TestCase("greatest", "weapon")]
        [TestCase("Helo", "Ehlo")]
        public void More_Tests_For_String_Concatenating(string s1, string s2)
        {
            DifferentAlgorhytms alg = new DifferentAlgorhytms();

            var answer = alg.ConcatenateString(s1, s2);

            Assert.IsNotEmpty(answer);
        }

        [TestCase]
        public void Wrong_Characters_Input_For_Concatenating_Method_Test()
        {
            DifferentAlgorhytms alg = new DifferentAlgorhytms();
            string str1 = "Hello world!";
            string str2 = "You done?";

            var answer = alg.ConcatenateString(str1, str2);

            Assert.IsNull(answer);
        }

        [TestCase]
        public void Leave_Lucky_Numbers_Test()
        {
            DifferentAlgorhytms alg = new DifferentAlgorhytms();
            List<int> list = new List<int>();
            list.Add(9);
            list.Add(17);
            list.Add(57);
            list.Add(3);
            list.Add(10);
            list.Add(70);

            alg.FilterLucky(list);

            Assert.IsTrue(list.Count == 3);
        }

        [TestCase]
        public void Summing_Up_Left_And_Right_Elements_Of_An_Array_Test()
        {
            DifferentAlgorhytms alg = new DifferentAlgorhytms();
            int[] array = { 2, 3, 1, 1 };

            var answer = alg.ArraySumSplat(array);

            Assert.AreEqual(1, answer);
        }

        [TestCase]
        public void Null_Input_For_Summing_Up_Test()
        {
            DifferentAlgorhytms alg = new DifferentAlgorhytms();
            int[] array = { 4, 5, 6, 1, 0 };

            var answer = alg.ArraySumSplat(array);

            Assert.AreEqual(0, answer);
        }

        [TestCase(5, 3, 1, 2, ExpectedResult = 7)]
        [TestCase(102, 23, 0, 4, ExpectedResult = 119)]
        [TestCase(1024, 19, 2, 6, ExpectedResult = 1100)]
        public int Insert_M_Into_N_Testing(int n, int m, int i, int j)
        {
            DifferentAlgorhytms alg = new DifferentAlgorhytms();

            var answer = alg.BitsAndIntegers(n, m, i, j);

            return answer;
        }
    }
}
