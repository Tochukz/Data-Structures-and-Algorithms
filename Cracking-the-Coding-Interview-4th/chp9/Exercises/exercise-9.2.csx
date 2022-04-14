/**
Problem: Write a method to sort an array of strings so that all the anagrams are next to each other.
 
*/
class Exercise92 
{
    private static bool AreAnagrams(string word1, string word2)
    {
        char[] letters1 = word1.ToCharArray();
        char[] letters2 = word2.ToCharArray();
        Array.Sort(letters1);
        Array.Sort(letters2);

        string name1 = string.Join("", letters1);
        string name2 = string.Join("", letters2);

        return string.Equals(name1, name2);
    }

    public static void SortByAnagram(string[] words)
    {
        for(int i = 0; i < words.Length -1; i++)
        {           
           string word1 = words[i];
           for(int j = i + 1; j < words.Length; j++)
           {
              string word2 = words[j];
              if (AreAnagrams(word1, word2))
              {
                 string temp = words[i+1];
                 words[i+1] = word2;
                 words[j] = temp;
              } 
           }        
        }
    }

    public static void PrintArray(string[] words)
    {
        foreach(string word in words)
        {
            Console.Write($"{word} ");
        }
        Console.Write("\n");
    }
}

string[] names = {"apple", "banana", "carrot", "ele", "duck", "papel", "tarroc", "cudk", "eel", "lee"};
Exercise92.SortByAnagram(names);
Exercise92.PrintArray(names);

/**

Output: 
  apple papel carrot tarroc duck cudk ele lee eel banana 


Online Resource: 
  https://www.geeksforgeeks.org/given-a-sequence-of-words-print-all-anagrams-together/
  https://practice.geeksforgeeks.org/problems/print-anagrams-together/1
*/