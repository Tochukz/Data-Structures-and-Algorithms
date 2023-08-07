/**
* Given two string, write a method to decide of one string is a permutation of the other.  
*/
using System;
using System.Collections.Generic;

class Exercise13 {
    public bool IsPermutation(string word1, string word2) {    
        // Write your solution here
        return true;
    }

    public void Test(Dictionary<string[], bool> testCases) {
        foreach(KeyValuePair<string[], bool> item in testCases) {
            if (item.Key.Length != 2) {
                throw new Exception("Array of string must be of length 2");
            }
            string word1 = item.Key[0];
            string word2 = item.Key[1];
            bool result = IsPermutation(word1, word2);
            if (result == item.Value) {
              Console.WriteLine("Pass!");
            } else {
              Console.WriteLine($"Failed: Expected {item.Value} but got {result} ");
            }
        }
    }
}

Exercise13 exercise = new Exercise13();
Dictionary<string[], bool> testCases = new Dictionary<string[], bool>() {
  { new string[]{"cancel", "celcan"}, true},
  { new string[]{"hero", "erho"}, true},
  { new string[]{"jimmer", "chima"}, false},
  { new string[]{"binaton", "tonabin"}, true}
};
exercise.Test(testCases);

