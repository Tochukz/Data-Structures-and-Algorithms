/**
There is a string, , of lowercase English letters that is repeated infinitely many times. Given an integer, , find and print the number of letter a's in the first  letters of the infinite string.

Example
s = 'abcac'
n = 10
The substring we consider is abcacabcac, the first 10  characters of the infinite string. There are 4 occurrences of a in the substring.

Function Description

Complete the repeatedString function in the editor below.

repeatedString has the following parameter(s):

* s: a string to repeat
* n: the number of characters to consider
Returns

* int: the frequency of a in the substring
Input Format

The first line contains a single string, s.
The second line contains an integer, n.

Constraints
* 1 <= |s| <= 100
* 1 <= n <= 10^12
* For 25% of the test cases, n <= 10^6.
Sample Input

Sample Input 0

aba
10
Sample Output 0

7
Explanation 0
The first n =10  letters of the infinite string are abaabaabaa. Because there are  7 a's, we return 7.

Sample Input 1

a
1000000000000
Sample Output 1

1000000000000
Explanation 1
Because all of the first n = 1000000000000  letters of the infinite string are a, we return 1000000000000 .
*/

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long repeatedString(string s, long n)
    {
        //For edge case 1: where no concatenation is needed
        if (n < s.Length)
        {
            return GetNumbersOfA(s, n);
        }
        //For edge case 2: where the string s == "a"  or s != "a"
        if (s.Length == 1)
        {
            if (s[0] == 'a')
            {
                return n;
            }
            else
            {
                return 0;
            }
        }
        long len = s.Length;
        long aCount = GetNumbersOfA(s, len);
        long loopsNeeded = n/len;
        long reminderLoops = n - (loopsNeeded * len);
        long totalACount = (loopsNeeded * aCount) + GetNumbersOfA(s, reminderLoops);
        return totalACount;
    }

    public static long GetNumbersOfA(string s, long limit)
    {
        long aCount = 0;
        char[] chars = s.ToCharArray();
        for(long i = 0; i < limit; i++)
        {
            char x = chars[i];
            if (x == 'a')
            {
                aCount++;
            }
        }
        return aCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
