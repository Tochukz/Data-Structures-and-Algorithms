/**
* Problem:  
*  Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column is set to 0.
*/
using System;
using System.Collections.Generic;

class Practice17 {
   public void MakeZeroLines(int[,] matrix) {
      // Write your solution here
   }

   public bool AreEqualMatrices(int[,] matrix1, int[,] matrix2) {
      bool areEqual = true;
      int outerLen = matrix1.GetLength(0);
      int innerLen = matrix1.GetLength(1);
      for (int i = 0; i < outerLen; i++) {
         for (int j = 0; j < innerLen; j++) {
            if (matrix1[i, j] != matrix2[i, j]) {
               areEqual = false;
            }
         }
      }
      return areEqual;
   }

   public void Print(int[,] matrix) {
      int outerLen = matrix.GetLength(0);
      int innerLen = matrix.GetLength(1);
      for(int i = 0; i < outerLen; i++) {
         for (int j = 0; j < innerLen; j++) {
            Console.Write($"{matrix[i, j]} ");
         }
         Console.Write("\n");
      }
   }

   public void Test(Dictionary<int[,], int[,]> testCases) {
     foreach (KeyValuePair<int[,], int[,]> item in testCases) {
        MakeZeroLines(item.Key);
        if (AreEqualMatrices(item.Value, item.Key)) {
           Console.WriteLine("Passed!");
        } else {
          Console.WriteLine("Failed: \n Expected:");
          Print(item.Value);
          Console.WriteLine(" Got: ");
          Print(item.Key);
        }        
     }  
   }
}

Practice17 Practice = new Practice17();
int[,] matrix1 = {
   {1, 1, 1},
   {1, 1, 0},
};
int[,] zeroed1 = {
   {1, 1, 0},
   {0, 0, 0},
};
int [,] matrix2 = {
   {1, 0},
   {1, 1}
};
int[,] zeroed2 = {
   {0, 0},
   {1, 0}
};
int [,] matrix3 = {
   {1, 1, 0, 1},
   {1, 1, 1, 1},
   {0, 1, 1, 1},
   {1, 1, 1, 1}
};
int [,] zeroed3 = {
   {0, 0, 0, 0},
   {0, 1, 0, 1},
   {0, 0, 0, 0},
   {0, 1, 0, 1}
};
Dictionary<int[,], int[,]> testCases = new Dictionary<int[,], int[,]> {
   {matrix1, zeroed1},
   {matrix2, zeroed2},
   {matrix3, zeroed3}
};
Practice.Test(testCases);
