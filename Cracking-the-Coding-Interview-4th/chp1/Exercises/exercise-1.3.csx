/**
 Problem: 
   Design an algorithm and write code to remove the duplicate characters in a string without using any additional buffer. 
     NOTE: One or two additional variables are fine. An extra copy of the array is not.
   FOLLOW UP
   Write the test cases for this method.
*/

public class Exercise13 
{
    public void ReplaceDuplicates(string str)
    {        
        if (string.IsNullOrEmpty(str) || str.Length == 1)
        {
            return;
        }
       
        char[] letters = str.ToCharArray();
        
        for(int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j]) {                    
                    str = str.Remove(i, 1);
                }
            }
        }
    }
}

//Todo: This solution does not work yet.

Exercise13 exer = new Exercise13();
string name = "Nwachukwu";
exer.ReplaceDuplicates(name);
Console.WriteLine(name);
