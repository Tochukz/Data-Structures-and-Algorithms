/**
Problem: Reverse Words in a letters
   Reverse the order of words in a given letters (an array of characters).
   For example "Hello World" becomes "World Hello"

Constraint:
  Runtime Complexity: Linear, O(n)
  Memory Complexity: Constant, O(1)  
*/

class Exercise8
{
    private static void ReverseChars(char[] letters, int start, int end)
    {
       while (start < end)
       {
           char temp = letters[start];
           letters[start] = letters[end];
           letters[end] = temp;
           start++;
           end--;
       }
    }

    public static void ReverseWords(char[] letters)
    {
        int len = letters.Length;
        ReverseChars(letters, 0, len - 1);
        int start = 0;
        for(int i  = 0; i < len; i++)
        {
           if (letters[i] == ' ')
           {
               ReverseChars(letters, start, i - 1);
               start = i + 1;
           }
           if (i == len - 1)
           {
               ReverseChars(letters, start, i);            
           }
        }
    }

    public static void PrintSentence(char[] letters)
    {
        string sentence = string.Join("", letters);
        Console.WriteLine(sentence);
    }
}

//char[] letters = new char[]{'H', 'e', 'l', 'l', 'o', ' ', 'J', 'a', 'v', 'a', ' ', 'w', 'o', 'r', 'l', 'd'};

char[] letters = new char[]{'W', 'e', ' ', 'l', 'o',  'v', 'e', ' ', 'J', 'a', 'v', 'a'};
Exercise8.PrintSentence(letters);
Exercise8.ReverseWords(letters);
Exercise8.PrintSentence(letters);

Exercise8.ReverseWords(letters);
Exercise8.PrintSentence(letters);

/**
Output:  
   Hello Java world
   world Java Hello
  Hello Java world
*/