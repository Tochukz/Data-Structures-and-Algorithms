/** 
  Problem: 
    Write a method to replace all spaces in a string with ‘%20’.
*/

class Exercise15
{
    /** A simple solution */
    public string ReplaceSpaces(string str)
    {
        str = str.Trim();
        StringBuilder builder = new StringBuilder();
        for(int i = 0;  i < str.Length; i++)
        {
           if (str[i] == ' ') // second condition for trim effect
           {
               builder.Append("%20");
           }
           else
           {
               builder.Append(str[i]);
           }
        }
        return builder.ToString();
    }

    /** A better solution. */
    public string ReplaceSpace2(string str)
    {
        char[] charArry1 = str.Trim().ToCharArray();
        int newLength = charArry1.Length;
        for(int i = 0; i < charArry1.Length; i++)
        {
            if (charArry1[i] == ' ')
            {
                newLength += 2;
            }
        }

        char[] charArry2 = new char[newLength];
        int j = newLength  - 1;
        for(int i = charArry1.Length - 1; i >= 0; i--)
        {
            if (charArry1[i] == ' ')
            {
               charArry2[j--] = '0';
               charArry2[j--] = '2';
               charArry2[j--] = '%';
            }
            else 
            {
                charArry2[j--] = charArry1[i];
            }
            
        }
        return string.Join("", charArry2);
    }

    /* This solution takes the str as char[] and replaces the space in-place */
    public void ReplaceSpaces(ref char[] strChars)
    {
        int oldLen = strChars.Length;
        int newLen  = oldLen;
        foreach(char x in strChars)
        {
            if (x == ' ')
            {
                newLen += 2;
            }
        }
        Array.Resize(ref strChars, newLen);
        int j = newLen - 1;
        for(int i = oldLen - 1; i >=0 ; i--)
        {
            if (strChars[i] == ' ')
            {
               strChars[j--] = '0';
               strChars[j--] = '2';
               strChars[j--] = '%';
            }
            else
            {
               strChars[j--] = strChars[i];
            }
        }
    }

    /** Using built-in native Replace method. Likely not to be allowed in tests */
    public string ReplaceSpaces3(string str)
    {
        str = str.Trim();
        str = str.Replace(" ", "%20");
        return str;
    }
}


Exercise15 exer = new Exercise15();
string str = "Mr John Smith ";
Console.WriteLine(exer.ReplaceSpaces(str)); // Mr%20John%20Smith
Console.WriteLine(exer.ReplaceSpace2(str)); // Mr%20John%20Smith 
Console.WriteLine(exer.ReplaceSpaces3(str)); // Mr%20John%20Smith

char[] strChars = str.ToCharArray();
Console.WriteLine(string.Join("", strChars)); // Mr John Smith
exer.ReplaceSpaces(ref strChars);
Console.WriteLine(string.Join("", strChars)); // Mr%20John%20Smith%20

/**

Method         | Time Complexity | Space Complexity
ReplaceSpaces  |    O(n)         | O(1)
ReplaceSpace2  |  O(n Log n)     | O(n Log n);

Online Resource 
  https://www.geeksforgeeks.org/urlify-a-given-string-replace-spaces-with-%20/
*/