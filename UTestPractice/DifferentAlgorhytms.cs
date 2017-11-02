using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UTestPractice
{
    /// <summary>
    /// Class contains different algorithms to test with NUnit.
    /// </summary>
    public class DifferentAlgorhytms
    {
        /// <summary>
        /// Inserts one number inside of other based on the position given.
        /// </summary>
        /// <param name="num1">Number 1.</param>
        /// <param name="num2">Number 2 smaller than the first one.</param>
        /// <param name="i">Begining of the position.</param>
        /// <param name="j">End of the position.</param>
        /// <returns></returns>
        public int BitsAndIntegers(int num1, int num2, int i, int j)
        {
            int maskOfOnes = ~0;

            int left = maskOfOnes << (j + 1);

            int right = ((1 << i) - 1);

            int mask = left | right;

            int num1_cleared = num1 & mask;
            int num2_shifted = num2 << i;

            return (num1_cleared | num2_shifted);
        }

        /// <summary>
        /// Recursive search algorithm. Returns maximum element in the array.
        /// </summary>
        /// <param name="array">Array to search in.</param>
        /// <param name="index">The index to start with.</param>
        /// <param name="max">Current maximum element.</param>
        /// <returns></returns>
        public int RecursiveSearch(int[] array, int index, int max)
        {
            if (index < array.Length -1)
            {
                if (array[index] > max)
                    max = array[index];

                return RecursiveSearch(array, index + 1, max);
            }
            return max;
        }

        /// <summary>
        /// Returns an element's index if the sums from both sides are equal.
        /// Returns 0 if there is no such element.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int ArraySumSplat(int[] array)
        {
            // To count the sum of elements on the right.
            int rightSum = 0;
            // To count the sum of elements on the left.
            int leftSum = 0;
            // The answer (as index).
            int ourAnswer = 0;

            for (int i = 1; i<array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                    leftSum = leftSum + array[j];
                for (int j = array.Length - 1; j > i; j--)
                    rightSum = rightSum + array[j];

                if (leftSum == rightSum)
                    ourAnswer = i;
                else continue;
            }
            return ourAnswer;           
        }

        /// <summary>
        /// Algorithm for concatenating strings.
        /// Also removes duplicates and sorts.
        /// Other characters than letters are not allowed.
        /// </summary>
        /// <param name="str1">First string to work with.</param>
        /// <param name="str2">Second string to work with.</param>
        /// <returns></returns>
        public string ConcatenateString(string str1, string str2)
        {
            if (Regex.IsMatch(str1, @"^[a-zA-Z]+$") && Regex.IsMatch(str2, @"^[a-zA-Z]+$"))
            {
                string str3 = str1 + str2;
                char[] a = str3.ToCharArray();
                Array.Sort(a);
                return new string(a.Distinct().ToArray());
            }
            else return null;
        }

        /// <summary>
        /// Removes any numbers in the list of integers that have no 7 in their value.
        /// </summary>
        /// <param name="list">List to operate with.</param>
        public void FilterLucky(List<int> list)
        {
            for (int i=0;i<list.Count;i++)
            {
                if (!i.ToString().Contains(7.ToString()))
                    list.RemoveAt(i);
            }
        }
    }
}
