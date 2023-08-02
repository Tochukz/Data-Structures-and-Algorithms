/**
* Problem: Implement and algorithm to determine if a string has all unique charaters. 
* You implementation should not use any additional data structure
*/
using System;
using System.Collections.Generic;

class Exercise11A {
   public bool IsUniqueString(string word) {
      for (int i = 0; i < word.Length; i++) {
        for (int j = i+1; j < word.Length; j++) {
          if (word[i] == word[j]) {
            return false;
          }
        }
      }
      return true;
   }

   public void Test(Dictionary<string, bool> testCases) {
     foreach (KeyValuePair<string, bool> item in testCases) {
        bool resultVal = IsUniqueString(item.Key);
        if (item.Value == resultVal) {
           Console.WriteLine("Pass!");
        } else {
          Console.WriteLine($"Fail {item.Value} should return {resultVal}");
        }        
     }  
   }
}

Exercise11A exercise = new Exercise11A();
Dictionary<string, bool> testCases = new Dictionary<string, bool> {
    {"Hello", false},
    {"Chima", true},
    {"Parrot", false},
    {"Lion", true},
    {"Javis", true}
};

exercise.Test(testCases)
