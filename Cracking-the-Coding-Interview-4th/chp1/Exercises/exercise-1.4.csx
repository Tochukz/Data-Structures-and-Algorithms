/**
 Problem:
   Write a method to decide if two strings are anagrams or not.
   An anagram is a word, phrase, or name formed by rearranging the letters of another, such as spar, formed from rasp.
*/
public class Excerise14
{
    public static bool IsAnagram(string word, string anagram)
    {
        if (word.Length != anagram.Length)
        {
            return false;
        }
        if (word == anagram)
        {
            return true;
        }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int i = 0; i < word.Length; i++)
        {
            char x = word[i];
            if (!dict.ContainsKey(x))
            {
                dict.Add(x, 0);
            }
            dict[x] += 1;
        }

        for(int j = 0; j < anagram.Length; j++)
        {
            char y = anagram[j];
            if (!dict.ContainsKey(y))
            {
                return false;
            }
            if (dict[y] == 0)
            {
                return false;
            }
            dict[y]--;
        }

        return true;
    }

    public static bool IsAnagram2(string word, string anagram)
    {
        if (word.Length != anagram.Length)
        {
            return false;
        }

        char[] letters1 = word.ToCharArray();
        char[] letters2 = anagram.ToCharArray();
        Array.Sort(letters1);
        Array.Sort(letters2);
        for(int i = 0; i < letters1.Count(); i++)
        {
            if (letters1[i] != letters2[i])
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsAnagram3(string word, string anagram)
    {
         if (word.Length != anagram.Length)
         {
            return false;
         }
         char[] letters1 = word.ToCharArray();
         char[] letters2 = anagram.ToCharArray();
         Array.Sort(letters1);
         Array.Sort(letters2);
         string str1 = string.Join("", letters1);
         string str2 = string.Join("", letters2);
         return string.Equals(str1, str2);
    }
}

/*
* An anagram is a word or phrase that's formed by rearranging the letters of another word or phrase.
* For example, the word "secure" is an anagram of "rescue", and "spar" is an anagram of "rasp".
*/

string word1 = "secure", anagram1  = "rescue";
if (Excerise14.IsAnagram2(word1, anagram1))
{
    Console.WriteLine($"{anagram1} is an anagram of {word1}");
}
else
{
    Console.WriteLine($"{anagram1} NOT an anagram of {word1}");
}

string word2 = "spar", anagram2 = "rasp";
if (Excerise14.IsAnagram2(word2, anagram2))
{
    Console.WriteLine($"{anagram2} is an anagram of {word2}");
}
else
{
    Console.WriteLine($"{anagram2} NOT an anagram of {word2}");
}

string word3 = "master", anagram3 = "sister";
if (Excerise14.IsAnagram2(word3, anagram3))
{
    Console.WriteLine($"{anagram3} is an anagram of {word3}");
}
else
{
    Console.WriteLine($"{anagram3} NOT an anagram of {word3}");
}


/** Output:
rescue is an anagram of secure
rasp is an anagram of spar
sister NOT an anagram of master

*/


/**
 Method     | Time Complexity | Space Complexity |
IsAnagrams  |     O(n)        |    O(n+n)        |
IsAnagram2  |     O(n+n)      |    O(n)          | Have same performace as IsAnagrams()
IsAnagram3  |     O(n)        |    O(n+n)        | Fastest. Two times faster than IsAnagrams() or IsAnagrams2()
 */
