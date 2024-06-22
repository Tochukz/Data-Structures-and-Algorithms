/**
* Problem: Implement a method to perform basic string compression using the count of repeated characters. 
*   For example, the string aabcccccaaa would become a2b1c5a3. If the compressed string would not become smaller 
*   than the original string, your method should return the original string.
*/

using System.Text;

class Practice15 {
    public string Compress(string str) {
        // Write your solution here
        return "";
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

Practice15 practice = new Practice15();
Dictionary<string, string> testCases = new Dictionary<string, string> {
  {"aabcccccaaa", "a2b1c5a3"},
  {"abcfp", "abcfp"},
  {"ttpppppij", "t2p5i1j1"}
};
practice.Test(testCases);