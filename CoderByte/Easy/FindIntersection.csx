/*
Find Intersection
Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements: the first element will represent a list of comma-separated numbers sorted in ascending order, the second element will represent a second list of comma-separated numbers (also sorted). Your goal is to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order. If there is no intersection, return the string false.
Examples
Input: new string[] {"1, 3, 4, 7, 13", "1, 2, 4, 13, 15"}
Output: 1,4,13
Input: new string[] {"1, 3, 9, 10, 17, 18", "1, 4, 9, 10"}
Output: 1,9,10
*/

using System;
using System.Collections.Generic;

class MainClass {

  public static string FindIntersection(string[] strArr) {

    // code goes here  
    string[] strArr1 = strArr[0].Split(", ");
    string[] strArr2 = strArr[1].Split(", ");
    List<string> strList = new List<string>();
    for(int i = 0; i < strArr1.Length; i++)
    {
      for (int j = 0; j < strArr2.Length; j++)
      {
        if (strArr1[i] == strArr2[j]) {
          strList.Add(strArr1[i]);
        }
      } 
    }
    if (strList.Count == 0) {
      return "false";
    } 
    return String.Join(",", strList);

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(FindIntersection(Console.ReadLine()));
    
  } 

}