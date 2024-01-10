/**
* Problem:  
*   Write code to reverse a C-Style String. (C-String means that “abcd” is represented as five characters, including the null character.)
*/
using System;
using System.Text;
using System.Collections.Generic;

class Practice12 {
   public string Reverse(string word) {
      // Write your solution here
      return word;
   }

   public void Test(Dictionary<string, string> testCases) {
     foreach (KeyValuePair<string, string> item in testCases) {
        string resultVal = Reverse(item.Key);
        if (item.Value == resultVal) {
           Console.WriteLine("Passed!");
        } else {
          Console.WriteLine($"Failed: Expected {item.Value}, got {resultVal}");
        }        
     }  
   }
}

Practice12 Practice = new Practice12();
Dictionary<string, string> testCases = new Dictionary<string, string> {
    {"Hello", "olleH"},
    {"Chima", "amihC"},
    {"Parrot", "torraP"},
    {"Lion", "noiL"},
    {"Javis", "sivaJ"}
};

Practice.Test(testCases)
