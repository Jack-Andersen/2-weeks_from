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

            //double Number1, Number2;

            //Number1 = 10;
            //Number2 = 10;

            //double result = 0;

            //result = Math.Pow(Number1, Number2);

            //long Result = Convert.ToInt64(result);

            //Console.WriteLine(Result);

            //Console.ReadKey();



            /* Find the Smallest and Biggest Numbers! <--- 10th
              
            Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.

            FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]

            FindMinMax([2334454, 5]) ➞ [5, 2334454]

            FindMinMax([1]) ➞ [1, 1]

            All test arrays will have at least one element and are valid.
             
            */

            //int[] arr = { 1, 2, 3, 4, 5};

            //for (int i = 0; i < arr.Length; i++)

            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Max());

            //Console.ReadKey();



            /* Sort Numbers in Ascending Order! <--- 11th
              
            Create a function that takes an array of numbers and returns a new array, sorted in ascending order (smallest to biggest).

            Sort the numbers array in ascending order.
            If the function's argument is null, an empty array, or undefined; return an empty array.
            Return a new array of sorted numbers.

            SortNumsAscending([1, 2, 10, 50, 5]) ➞ [1, 2, 5, 10, 50]

            SortNumsAscending([80, 29, 4, -95, -24, 85]) ➞ [-95, -24, 4, 29, 80, 85]

            SortNumsAscending(null) ➞ []

            SortNumsAscending([]) ➞ []

            Test input can be positive or negative.

            */

            //int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //Array.Sort(arr);

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i + "");
            //}

            //Console.ReadKey();



            /* Return the Factorial! <--- 12th
              
            Create a function that takes an integer and returns the factorial of that integer. That is, the integer multiplied by all positive lower integers.

            Factorial(3) ➞ 6

            Factorial(5) ➞ 120

            actorial(13) ➞ 6227020800

            Assume all inputs are greater than or equal to 0.

            */

            //int number = 5, result;

            //fact = number;

            //for (int i = number - 1; i >= 1; i--)
            //{
            //    result = result * i;
            //}

            //Console.WriteLine(result);

            //Console.ReadKey();



            /* Check if a String Contains only Identical Characters! <--- 13th
              
            Write a function that returns true if all characters in a string are identical and false otherwise.

            isIdentical("aaaaaa") ➞ true

            isIdentical("aabaaa") ➞ false

            isIdentical("ccccca") ➞ false

            isIdentical("kk") ➞ true

            N/A

            */

            //string word = "abaa";
            //int result = word.Length;

            //for (int i = 1; i < result; i++)
            //{
            //    if (word[i] != word[0])
            //    {
            //        Console.WriteLine(false);
            //    }
            //}

            //    Console.WriteLine(true);

            //Console.ReadKey();



            /* Shuffle the Name! <--- 14th
             
            Create a function that accepts a string (of a persons first and last name) and returns a string with the first and last name swapped.

            NameShuffle("Donald Trump") ➞ "Trump Donald"

            NameShuffle("Rosie O'Donnell") ➞ "O'Donnell Rosie"

            NameShuffle("Seymour Butts") ➞ "Butts Seymour"

            There will be exactly one space between the first and last name.

            */

            //string str = "Donald Trump";

            //string[] array = str.Split(new char[] { ' ' });

            //Array.Reverse(array);

            //Console.WriteLine(string.Join(" ", array));

            //Console.ReadKey();



            /* Reverse the Order of a String! <--- 15th
             
            Create a function that takes a string as its argument and returns the string in reversed order.

            Reverse("Hello World") ➞ "dlroW olleH"

            Reverse("The quick brown fox.") ➞ ".xof nworb kciuq ehT"

            Reverse("Edabit is really helpful!") ➞ "!lufpleh yllaer si tibadE"

            You can expect a valid string for all test cases.

            */

            //string str = "Hello World";

            //char[] chars = str.ToCharArray();

            //Array.Reverse(chars);

            //Console.WriteLine(string.Join("", chars));

            //Console.ReadKey();



            /* Calculate the Mean! <--- 16th
             
            Create a function that takes an array of numbers and returns the mean value.

            Mean([1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3]) ➞ 2.55

            Mean([2, 3, 2, 3]) ➞ 2.50

            Mean([3, 3, 3, 3, 3]) ➞ 3.00

            Round to two decimal places.
            You can expect a number ranging from 0 to 10,000.

            */

            //double[] arr = { 1, 1, 2, 2, 3, 3, 3 };

            //double sum = 0;

            //foreach (int value in arr)

            //    sum += value;

            //double result = (sum / arr.Length);

            //Console.WriteLine(Math.Round(result, 2));

            //Console.ReadKey();



            /* Between Words! <--- 17th
              
            Write a function that takes three string arguments (first, last, word) and returns true if (when alphabetically sorted) word is found between first and last.

            isBetween("apple", "banana", "azure") ➞ true

            isBetween("monk", "monument", "monkey") ➞ true

            isBetween("bookend", "boolean", "boost") ➞ false

            All letters will be in lowercase.
            All three words will be different.
            Remember the string word is in the middle.

            */



        }
    }
}
