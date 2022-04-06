/**
Problem: String segmentation
   You are given a dictionary of words and a large input string. 
   You have to find out whether the input string can be completely segmented into the words of a given dictionary. 
Constraint: 
  Runtime Complexity: Exponential, O(2^n)
  Memory Complexity: Polynomial, O(n^2)
*/


class Exercise7
{
    public static bool CanSegmentString(String str, HashSet<string> dictionary) 
    {
        HashSet<string> words = new HashSet<string>();
        foreach(string word in dictionary)
        {
            if (str.IndexOf(word) > -1)
            {
                words.Add(word);
            }
        }
        foreach(string strA in words)
        {
            foreach(string strB in words)
            {
                if (str.Equals(strA + strB))
                {
                    return true;
                }
            }
        }
        return false;
    }
}

HashSet<string> dictionary = new HashSet<string> {"apple", "pear", "pier", "pie"};

string word1 = "applepie";
string word2 = "applepeer";
bool canSeg1 = Exercise7.CanSegmentString(word1, dictionary);
bool canSeg2 = Exercise7.CanSegmentString(word2, dictionary);

if (canSeg1)
{
    Console.WriteLine("{0} can be segmented into two word", word1);
}
else
{ 
    Console.WriteLine("{0} can NOT be segmented into two word", word1);
}

if (canSeg2)
{
    Console.WriteLine("{0} can be segmented into two word", word2);
}
else
{ 
    Console.WriteLine("{0} can NOT be segmented into two word", word2);
}


/**
 Output:  
   applepie can be segmented into two word
   applepeer can NOT be segmented into two word
   
 Online Exercise: 
   https://www.educative.io/m/string-segmentation
*/