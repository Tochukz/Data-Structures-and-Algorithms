/**
* Problem: Write a method to replace all the spaces in a string with "%20". 
* The string should be represented by a character array whose length is long enough to contain all the additional characters.
* This should be done in place.       
*/
using System;
using System.Text;

class Exercise14B {
   public void ReplaceSpaces(char[] word) {      
      // Find the last char element in the character array. Stop when you find a null element
      int lastNonEmptyIndex = 0;
      for (int i = 0; i < word.Length; i++) {
         if (word[i] == '\0') {
           lastNonEmptyIndex = i - 1;
           break;
         }
      }  

      // Fill the array from the back starting with the last charater
      int lastIndex = word.Length - 1;
      for (int i = lastNonEmptyIndex; i >= 0 ; i--) {
         char lastChar = word[i]; 
         if (lastChar == ' ') {
            word[lastIndex--] = '0';
            word[lastIndex--] = '2';
            word[lastIndex--] = '%';
         } else {
            word[lastIndex--] = lastChar;
         }
      }
   }

   public string Join(char[] word) {
      StringBuilder builder = new StringBuilder();
      foreach(char x in word) {
        builder.Append(x);
      }
      return builder.ToString();
   }

   public bool Compare(char[] word1, char[]word2) {
      for(int i = 0; i < word1.Length; i++) {
         if (word1[i] != word2[i]) {
            return false;
         }         
      }
      return true;
   }

   public void Test(Dictionary<char[], char[]> testCases) {
      foreach(KeyValuePair<char[], char[]> item in testCases) {
         ReplaceSpaces(item.Key);
         if (Compare(item.Key, item.Value)) {
            Console.WriteLine("Pass!");
            continue;
         }
         Console.WriteLine($"Failed: expected {Join(item.Value)} got {Join(item.Key)}");      
      }
   }

   public char[] Copy(char[] container, char[] values) {
      //Check if container length is long enough when every ' '  is replaces by '%', '2', '0'.
      int len = values.Length;
      for(int i =0; i < values.Length; i++) {
         if (values[i] == ' ') {
            len = len + 2;
         }
      }
      if (len != container.Length) {
         throw new Exception($"Length mismatch between container {container.Length} and values {Join(values)}");
      }

      // Copy the values
      for(int i =0; i < values.Length; i++) {
        container[i] = values[i];
      }
      return container;
   }
}

Exercise14B exercise = new Exercise14B();


char[] values1 = exercise.Copy(new char[17], new char[]{'M','r',' ', 'J','o','h','n', ' ','S','m','i','t','h'});
char[] values2 = exercise.Copy(new char[18],  new char[]{'J','e','r','e','m','y',' ','K','e','l','v','i','n', ' '});
char[] values3  = exercise.Copy(new char[15], new char[]{' ','K','a','l','v','i','n', ' ', ' '});

Dictionary<char[], char[]> testCases = new Dictionary<char[], char[]> {
  { 
   values1, 
   new char[17]{'M','r','%', '2','0','J','o','h','n','%','2','0','S','m','i','t','h'}
  },
  { 
   values2,
   new char[18]{'J','e','r','e','m','y','%','2','0','K','e','l','v','i','n','%','2','0'}
  },
  { 
    values3,
   new char[]{'%','2','0','K','a','l','v','i','n','%','2','0','%','2','0'}
  },
};
exercise.Test(testCases);