using System;
using System.Text;

class Exercise14B {
   public char[] ReplaceSpaces(char[] word) {
      int len = 0;
      for (int i = 0; i < word.Length; i++) {
          char x = word[i];
          if (x == ' ') {
            len += 3;
            continue;
          }
          len += 1;
      }
      char[] updatedWord = new char[len];
      int index = 0;
      for (int j = 0; j < word.Length; j++) {
         char x = word[j];
         if (x == ' ') {
            updatedWord[index++] = '%';
            updatedWord[index++] = '2';
            updatedWord[index++] = '0';
            continue;
         }
         updatedWord[index++] = x;
      }
      return updatedWord;
   }

   public void PrintArray(char[] word) {
      foreach(char x in word) {
        Console.Write(x);
      }
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
         char[] result = ReplaceSpaces(item.Key);
         if (Compare(result, item.Value)) {
            Console.WriteLine("Pass!");
            continue;
         }
         Console.Write($"Failed expected ");
         PrintArray(item.Value);
         Console.Write(" got ");
         PrintArray(result);
         Console.WriteLine(" ");
      }
   }
}

Exercise14B exercise = new Exercise14B();
Dictionary<char[], char[]> testCases = new Dictionary<char[], char[]> {
  { 
   new char[]{'M','r',' ', 'J','o','h','n', ' ','S','m','i','t','h'}, 
   new char[]{'M','r','%', '2','0','J','o','h','n','%','2','0','S','m','i','t','h'}
  },
  { 
   new char[]{'J','e','r','e','m','y',' ','K','e','l','v','i','n', ' '}, 
   new char[]{'J','e','r','e','m','y','%','2','0','K','e','l','v','i','n','%','2','0'}
  },
  { 
   new char[]{' ','K','a','l','v','i','n', ' ', ' '} ,
   new char[]{'%','2','0','K','a','l','v','i','n','%','2','0','%','2','0'}
  },
};
exercise.Test(testCases);