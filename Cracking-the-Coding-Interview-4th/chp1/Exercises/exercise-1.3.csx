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
        char[] uniques = new char[set.Count];
        int i = 0;
        foreach(char y in set)
        {
            uniques[i++] = y;
        }
        return string.Join("", uniques);
    }
}

Exercise13 exer = new Exercise13();
string animal1 = "hippopotamus";
string animal2 = "geeksforgeeks"; 
char[] animalChars1 = animal1.ToCharArray();
char[] animalChars2 = animal2.ToCharArray();

string animalA  = exer.RemoveDuplicates(animalChars1);
string animalB  = exer.RemoveDuplicates(animalChars2);
Console.WriteLine("{0} {1}", animalA, animalB); // hipotamus geksfor

string animalC  = exer.RemoveDupUsingSet(animalChars1);
string animalD  = exer.RemoveDupUsingSet(animalChars2);
Console.WriteLine("{0} {1}", animalC, animalD); // hipotamus geksfor

/**
  Method            | Time Complexity  | Space Complexity
  RemoveDuplicates  | O(n^2)           | O(1)
  RemoveDupUsingSet | O(n Log n)       | O(n)

Online Resouce 
  https://www.geeksforgeeks.org/remove-duplicates-from-a-given-string/#_=_
*/