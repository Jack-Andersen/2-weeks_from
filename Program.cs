using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Edabit__the_2_weeks_we_re_not_in_school
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Hurdle Jump! <--- 1st
             
            Create a function that takes an array of hurdle heights and a jumper's jump height, and
            determine whether or not the hurdler can clear all the hurdles.

            A hurdler can clear a hurdle if their jump height is greater than equal to the hurdle height.

            hurdleJump([1, 2, 3, 4, 5], 5) ➞ true

            hurdleJump([5, 5, 3, 4, 5], 3) ➞ false

            hurdleJump([5, 4, 5, 6], 10) ➞ true

            hurdleJump([1, 2, 1], 1) ➞ false

            Notes

            Return true for the edge case of an empty array of hurdles. (Zero hurdles means that any jump height can clear them).

            */

            //int[] hurdles = { 1, 2, 3, 4, 5 };

            //int jumpHeight = 10;

            //foreach (int num in hurdles)
            //{

            //    if (num > jumpHeight)

            //    {
            //        Console.WriteLine("True");
            //    }

            //}
            //  Console.WriteLine("true");

            //Console.ReadKey();



            /*Convert Number to Corresponding Month Name! <--- 2nd
             
            Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string.
            For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.

            You can expect only integers ranging from 1 to 12 as test input.
            
            */

            //int num = 1;

            //for (int i = 0; i < num; num++)
            //{

            //    DateTime date = new DateTime(2010, num, 1);
            //    Console.WriteLine(date.ToString("MMMM"));

            //}

            //Console.ReadKey();



            /* Count Instances of a Character in a String! <--- 3rd
             
            Create a function that takes a character and a string as arguments and returns the number of times the character is found in the string.
             
            CharCount("a", "edabit") ➞ 1

            CharCount("c", "Chamber of secrets") ➞ 1

            CharCount("b", "big fat bubble") ➞ 4

            Your output must be case-sensitive (see second example).

            */

            //char myChar = 'a';

            //string str = "aaa";

            //int count = 0;

            //foreach (char c in str)
            //{
            //    if (c == myChar) count++;
            //}

            //Console.WriteLine(count);

            //Console.ReadKey();



            /* Hamming Distance! <--- 4th

            Hamming distance is the number of characters that differ between two strings.

            String1: "abcbba"
            String2: "abcbda"

            Hamming Distance: 1 - "b" vs. "d" is the only difference.

            Create a function that computes the hamming distance between two strings.

            HammingDistance("abcde", "bcdef") ➞ 5

            HammingDistance("abcde", "abcde") ➞ 0

            HammingDistance("strong", "strung") ➞ 1

            Both strings will have the same length.

            */

            //string str1 = "Katte";
            //string str2 = "Kattt";

            //int i = 0, count = 0;
            //while (i < str1.Length)
            //{
            //    if (str1[i] != str2[i])
            //        count++;
            //    i++;
            //}
            //Console.WriteLine(count);

            //Console.ReadKey();



            /* Absolute Sum! <--- 5th

            Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.

            getAbsSum([2, -1, 4, 8, 10]) ➞ 25

            getAbsSum([-3, -4, -10, -2, -3]) ➞ 22

            getAbsSum([2, 4, 6, 8, 10]) ➞ 30

            getAbsSum([-1]) ➞ 1

            The term "absolute value" means to remove any negative sign in front of a number, and to think of all numbers as positive (or zero).

            */

            //int[] arr = { 2, 0, -1, 10, -2 };

            //int sum = 0;

            //foreach (int value in arr)
            //{
            //    sum += Math.Abs(value);
            //}

            //Console.WriteLine(sum);

            //Console.ReadKey();



            /* How Many Vowels? <--- 6th
             
            Create a function that takes a string and returns the number (count) of vowels contained within it.

            CountVowels("Celebration") ➞ 5

            CountVowels("Palm") ➞ 1

            CountVowels("Prediction") ➞ 4

            a, e, i, o, u are considered vowels (not y).
            All test cases are one word and only contain letters.

            */

            //string str = "abcde";

            //int count = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'a' || str[i] == 'i' || str[i] == 'e' || str[i] == 'u' || str[i] == 'o')
            //        count++;
            //}

            //Console.WriteLine(count);

            //Console.ReadLine();



            /* Multiply by Length! <--- 7th
             
            Create a function to multiply all of the values in an array by the amount of values in the given array.

            MultiplyByLength([2, 3, 1, 0]) ➞ [8, 12, 4, 0]

            MultiplyByLength([4, 1, 1]) ➞ ([12, 3, 3])

            MultiplyByLength([1, 0, 3, 3, 7, 2, 1]) ➞  [7, 0, 21, 21, 49, 14, 7]

            MultiplyByLength([0]) ➞ ([0])

            All of the values given are numbers.
            All arrays will have at least one element.
            Don't forget to return the result.

            */

            //int[] arr = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] *= arr.Length;
            //}

            //foreach (int value in arr)
            //{
            //   Console.WriteLine(value);
            //}

            //Console.ReadKey();



            /* Smaller String Number <--- 8th

            Create a function that returns the smaller number.

            smallerNum("21", "44") ➞ "21"

            smallerNum("1500", "1") ➞ "1"

            smallerNum("5", "5") ➞ "5"

            Numbers will be represented as strings, and your output should also be a string.
            If both numbers tie, return either number.
            Numbers will be positive.
            Bonus: See if you can do this without converting to integers.

            */

            //string n1 = "100";
            //string n2 = "23";

            //if (n1.Length < n2.Length || n1.Length == n2.Length)

            //{
            //    Console.WriteLine(n1);
            //}

            //else

            //{
            //    Console.WriteLine(n2);
            //}

            //Console.ReadKey();



            /* To the Power of____! <--- 9th
             
            Create a function that takes a base number and an exponent number and returns the calculation.

            СalculateExponent(5, 5) ➞ 3125

            СalculateExponent(10, 10) ➞ 10000000000

            СalculateExponent(3, 3) ➞ 27

            All test inputs will be positive integers.
            Don't forget to return the result.

            */

            long result, Number1, Number2, N1, N2;

            Number1 = 10;
            Number2 = 10;

            N1 = Convert.ToInt64(Number1);
            N2 = Convert.ToInt64(Number2);

            result = Math.Pow(Number1, Number2);

            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
