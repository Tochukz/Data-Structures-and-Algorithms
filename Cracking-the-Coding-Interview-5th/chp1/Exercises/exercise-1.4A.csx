/**
* Problem: Write a method to replace all the spaces in a string with "%20". 
*/
using System;
using System.Text;

class Exercise14A {
   public string ReplaceSpaces(string word) {
      StringBuilder builder = new StringBuilder();
      for (int i = 0; i < word.Length; i++) {
          char x = word[i];
          if (x == ' ') {
            builder.Append("%20");
            continue;
          }
          builder.Append(x);
      }
      return builder.ToString();
   }

   public void Test(Dictionary<string, string> testCases) {
      foreach(KeyValuePair<string, string> item in testCases) {
         string result = ReplaceSpaces(item.Key);
         if (result == item.Value) {
            Console.WriteLine("Pass!");
            continue;
         }
         Console.WriteLine($"Failed: expect {item.Value} got {result}");
      }
   }
}

Exercise14A exercise = new Exercise14A();
Dictionary<string, string> testCases = new Dictionary<string, string> {
  {"Mr John Smith", "Mr%20John%20Smith"},
  {"Jeremy Kelvin ", "Jeremy%20Kelvin%20"},
  {" Kalvin  ", "%20Kalvin%20%20"},
};
exercise.Test(testCases);