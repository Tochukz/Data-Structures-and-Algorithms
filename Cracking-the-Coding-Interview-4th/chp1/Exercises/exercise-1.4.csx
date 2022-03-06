/* Write a method to decide if two strings are anagrams or not. */
public class Excerise14
{
    public static bool isAnagrams(string word, string anagram)
    {
        if (word.Length != anagram.Length)
        {
            return false;
        }

        char[] letters1 = word.ToCharArray();
        char[] letters2 = anagram.ToCharArray();
        Array.Sort(letters1);
        Array.Sort(letters2);
        bool isAnagram = true;
        for(int i = 0; i < letters1.Count(); i++)
        {
            if (letters1[i] != letters2[i]) 
            {
                isAnagram = false;
            }
        }
        return isAnagram;
    }
}

/*
* An anagram is a word or phrase that's formed by rearranging the letters of another word or phrase.
* For example, the word "secure" is an anagram of "rescue", and "spar" is an anagram of "rasp".
*/

string word1 = "secure", anagram1  = "rescue";
if (Excerise14.isAnagrams(word1, anagram1))
{
    Console.WriteLine($"{anagram1} is an anagram of {word1}");
}
else 
{
    Console.WriteLine($"{anagram1} NOT an anagram of {word1}");
}

string word2 = "spar", anagram2 = "rasp";
if (Excerise14.isAnagrams(word2, anagram2))
{
    Console.WriteLine($"{anagram2} is an anagram of {word2}");
}
else 
{
    Console.WriteLine($"{anagram2} NOT an anagram of {word2}");
}

string word3 = "master", anagram3 = "sister";
if (Excerise14.isAnagrams(word3, anagram3))
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
 Method                   | Time Complexity | Space Complexity | Desciption
 Excerise14.isAnagrams()  | O(n Log n)      |                  | 
 */