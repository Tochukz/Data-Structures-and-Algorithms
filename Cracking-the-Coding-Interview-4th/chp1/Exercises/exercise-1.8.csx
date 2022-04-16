/**
  Problem: 
    Assume you have a method isSubstring which checks if one word is a substring of another. Given two strings, s1 and s2, 
    write code to check if s2 is a rotation of s1 using only one call to isSubstring (i.e., “waterbottle” is a rotation of “erbottlewat”)
*/

class Exercise18
{
    public static bool IsSubstringOf(string bigStr, string smallStr)
    {
        return bigStr.IndexOf(smallStr) > -1;
    }

    public static bool IsRotationOf(string str1, string str2)
    {   
        if (str1.Length != str2.Length)
        {
            return false;
        }
        string bigStr = str2 + str2;
        return IsSubstringOf(bigStr, str1);
    }
}


string str1 = "waterbottle";
string str2 = "erbottlewat";
Dictionary<string, string> pairs= new Dictionary<string, string> {
    {"apple", "pleap"}, 
    {"waterbottle", "erbottlewat"}, 
    {"camera", "macera"}
};

foreach(KeyValuePair<string, string> pair in pairs)
{
  bool isRotated = Exercise18.IsRotationOf(pair.Key, pair.Value);
  string isOrNot = isRotated ? "is a rotation of" : "is NOT a rotation of";
  Console.WriteLine($"{pair.Key} {isOrNot} {pair.Value}");
}

/**
 Output: 
   apple is a rotation of pleap
   waterbottle is a rotation of erbottlewat
   camera is NOT a rotation of macera

*/