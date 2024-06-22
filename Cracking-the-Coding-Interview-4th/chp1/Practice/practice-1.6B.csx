/**
* Problem:  
*  Given an image represented by an MxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees to the left.
*/
using System;
using System.Collections.Generic;

class Practice16A {
   public int[,] RotateLeft(int[,] matrix) {
      // Write your solution here
      return matrix;
   }

   public bool AreEqualMatrices(int[,] matrix1, int[,] matrix2) {
      bool areEqual = true;
      int outerLen = matrix1.GetLength(0);
      int innerLen = matrix1.GetLength(1);

      int outerLen2 = matrix2.GetLength(0);
      int innerLen2 = matrix2.GetLength(1);
      if (outerLen != outerLen2 || innerLen != innerLen2) {
         return false;
      }

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
        int[,] result = RotateLeft(item.Key);
        if (AreEqualMatrices(item.Value, result)) {
           Console.WriteLine("Passed!");
        } else {
          Console.WriteLine("Failed: \n Expected:");
          Print(item.Value);
          Console.WriteLine(" Got: ");
          Print(result);
        }        
     }  
   }
}

Practice16A Practice = new Practice16A();
int[,] matrix1 = {
   {1, 2, 3},
   {4, 5, 6},
};
int[,] rotate1 = {
   {3, 6},
   {2, 5},
   {1, 4}
};
int [,] matrix2 = {
   {1, 2},
   {3, 4}
};
int[,] rotate2 = {
   {2, 4},
   {1, 3}
};
int [,] matrix3 = {
   {1, 2},
   {3, 4},
   {5, 6},
};
int [,] rotate3 = {
   {2, 4, 6},
   {1, 3, 5},
};
int [,] matrix4 = {
   {1, 2, 3, 4},
   {5, 6, 7, 8},
   {9, 10, 11, 12},
   {13, 14, 15, 16}
};
int [,] rotate4 = {
   {4, 8, 12, 16},
   {3, 7, 11, 15},
   {2, 6, 10, 14},
   {1, 5, 9, 13}
};
Dictionary<int[,], int[,]> testCases = new Dictionary<int[,], int[,]> {
   {matrix1, rotate1},
   {matrix2, rotate2},
   {matrix3, rotate3},
   {matrix4, rotate4}
};
Practice.Test(testCases);
