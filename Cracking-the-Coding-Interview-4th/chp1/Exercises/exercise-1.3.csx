/**
 Problem:
   Design an algorithm and write code to remove the duplicate characters in a string without using any additional buffer.
     NOTE: One or two additional variables are fine. An extra copy of the array is not.
   FOLLOW UP
   Write the test cases for this method.
*/

public class Exercise13
{
    public string RemoveDuplicates(char[] str)
    {
       if (str.Length < 2)
       {
           return string.Join("", str);
       }

       int index = 0;
       for(int i = 0; i < str.Length; i++)
       {
           int j;
           for(j = 0; j < i; j++)
           {
               if (str[i] == str[j])
               {
                   break;
               }
           }

           if (i == j)
           {
               str[index++] = str[i];
           }
       }
       return string.Join("", str.Take(index));
    }


    /** This solution is my choice solution. It removes the duplicate in the char[] in place. */
    public void RemoveDuplicates2(ref char[] strChars)
    {
        int index = 0;
        for(int i = 0; i < strChars.Length; i++)
        {
            int j;
            for(j = 0; j < i; j++)
            {
                if (strChars[i] == strChars[j])
                {
                    break;
                }
            }
            if (i == j)
            {
                strChars[index] = strChars[i];
                index++;
            }
        }
        Array.Resize(ref strChars, index);
    }

    /**
     * This solution does NOT address the contraints outlined in the question but is another way to remove duplicates in a string
     */
    public string RemoveDupUsingSet(char[] str)
    {
        if (str.Length < 2)
        {
           return string.Join("", str);
        }

        HashSet<char> set = new HashSet<char>();
        foreach(char x in str)
        {
            set.Add(x);
        }
        return string.Join("", set);
    }
}

Exercise13 exer = new Exercise13();
string hippo = "hippopotamus";
string geeks = "geeksforgeeks";
char[] hippoChars = hippo.ToCharArray();
char[] geeksChars = geeks.ToCharArray();

string uniqueHippo  = exer.RemoveDuplicates(hippoChars);
string uniqueGeeks  = exer.RemoveDuplicates(geeksChars);
Console.WriteLine("{0} {1}", uniqueHippo, uniqueGeeks); // hipotamus geksfor

string uniqueHippo1  = exer.RemoveDupUsingSet(hippoChars);
string uniqueGeeks1  = exer.RemoveDupUsingSet(geeksChars);
Console.WriteLine("{0} {1}", uniqueHippo1, uniqueGeeks1); // hipotamus geksfor


char[] hippoChars1 = hippo.ToCharArray();
char[] geeksChars1 = geeks.ToCharArray();
exer.RemoveDuplicates2(ref hippoChars1);
exer.RemoveDuplicates2(ref geeksChars1);
Console.WriteLine("{0} {1}", string.Join("", hippoChars1), string.Join("", geeksChars1)); // hipotamus geksfor

/**
  Method            | Time Complexity  | Space Complexity
  RemoveDuplicates  | O(n^2)           | O(1)
  RemoveDupUsingSet | O(n Log n)       | O(n)

Online Resouce
  https://www.geeksforgeeks.org/remove-duplicates-from-a-given-string/#_=_
*/
