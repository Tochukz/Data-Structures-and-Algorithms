/**
* Problem: Implement and algorithm to determine if a string has all unique charaters. 
*/
using System;
using System.Collections.Generic;

class Exercise11A {
   public bool IsUniqueString(string word) {
     HashSet<char> letters = new HashSet<char>();
     for (int i = 0; i < word.Length; i++) {
        char x = word[i];
        if (letters.Contains(x)) {
            return false;
        }
        letters.Add(x);
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
