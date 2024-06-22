/*

First Reverse
Have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order. For example: if the input string is "Hello World and Coders" then your program should return the string sredoC dna dlroW olleH.
Examples
Input: "coderbyte"
Output: etybredoc
Input: "I Love Code"
Output: edoC evoL I

*/

using System;
using System.Text;

class MainClass {

  public static string FirstReverse(string str) {

    // code goes here  
    StringBuilder builder = new StringBuilder();
    for(int i = str.Length - 1; i >=0 ; i--) {
      builder.Append(str[i]);
    }
    return builder.ToString();

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(FirstReverse(Console.ReadLine()));
    
  } 

}