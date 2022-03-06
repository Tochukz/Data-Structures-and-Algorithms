/**
  Problem: 
    Write code to reverse a C-Style String. (C-String means that “abcd” is represented as five characters, including the null character.)
*/
using System.Text;

class Excercise12 
{
    public string reverse(string str)
    {
        StringBuilder builder = new StringBuilder();
        for(int i = str.Length - 1; i >= 0; i--)
        {
            builder.Append(str[i]);
        }
        return builder.ToString();
    }
}


Excercise12 exer = new Excercise12();
string word = "naelC nivlaK";
string reversedWord = exer.reverse(word);
Console.WriteLine(reversedWord); // Kalvin Clean

/**
  Solution:  
    Time Complexity: O(n)
    Space Comlexity: O(n)

    Where n is the length of the string
*/