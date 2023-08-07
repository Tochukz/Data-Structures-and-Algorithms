/**
* Problem: Implement a function ro reverse a string 
*/
using System.Text;
using System.Collections.Generic;

class Exercise12 {
  public string Reverse(string word) {
    // Write your solution here
    return '';
  }

  public void Test(Dictionary<string, string> testCases) {
     foreach(KeyValuePair<string, string> item in testCases) {
        string result = Reverse(item.Key);
        if (result == item.Value) {
            Console.WriteLine("Pass!");
        } else {
            Console.WriteLine($"Failed: {result} instead of {item.Value}");
        }
     }
  }
}

Exercise12 exercise = new Exercise12();
Dictionary<string, string> testCases = new Dictionary<string, string> {
  {"Hello", "olleH"},
  {"Tiger", "regiT"},
  {"Hippopotamouse", "esuomatopoppiH"},
  {"Peter", "reteT"}
};
exercise.Test(testCases);