/**
* Problem: Implement a method to perform basic string compression using the count of repeated characters. 
*   For example, the string aabcccccaaa would become a2b1c5a3. If the compressed string would not become smaller 
*   than the original string, your method should return the original string.
*/
class Exercise15 {
    public string Compress(string str) {
        StringBuilder builder = new StringBuilder();
        int i = 0;
        while(i < str.Length) {
          char x = str[i]; 
          int count = 1;
          for (int j = i+1; j < str.Length; j++) {
             char y = str[j];
             if (x == y) {                
                count++;
                i++;
             } else {
                break;
             }
          }
          i++;
          builder.Append($"{x}{count}");
        }
        string compressed = builder.ToString();
        if (compressed.Length >= str.Length) {
            return str;
        }
        return compressed;
    }

    public void Test(Dictionary<string, string> testCases) {
        foreach (KeyValuePair<string, string> item in testCases) {
            string result = Compress(item.Key);
            if (item.Value == result) {
                Console.WriteLine("Pass!");
            } else {
                Console.WriteLine($"Failed: expected {item.Value} got {result}");
            }
        }
    } 
}

Exercise15 exercise = new Exercise15();
Dictionary<string, string> testCases = new Dictionary<string, string> {
  {"aabcccccaaa", "a2b1c5a3"},
  {"abcfp", "abcfp"},
  {"ttpppppij", "t2p5i1j1"}
};
exercise.Test(testCases);