/**
 Problem: Given a string s consisting of small English letters, find and return the first instance of a non-repeating character in it. 
          If there is no such character, return '_'
*/
class FirstNonRepeat
{
    char solution(string str) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            char x = str[i];
            if (!dict.ContainsKey(x))
            {
                dict[x] = 0;
            }
            dict[x] += 1;
        }
        
        foreach(KeyValuePair<char, int> pair in dict)
        {
            
            if (pair.Value == 1)
            {
                return pair.Key;
            }
        }
        return '_';
    }
}