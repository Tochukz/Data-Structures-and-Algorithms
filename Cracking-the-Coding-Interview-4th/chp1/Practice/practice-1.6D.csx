/**
* Problem:  
*  Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image in place by 90 degrees to the right.
*  Do it in place. i.e you must not create a copy of the matrix
*/
using System;
using System.Collections.Generic;

class Practice16B {
   public void RotateRight(int[,] matrix) {
      // Write your solution here
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
        RotateRight(item.Key);
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

Practice16B Practice = new Practice16B();
int[,] matrix1 = {
   {1, 2, 3},
   {4, 5, 6},
   {7, 8, 9}
};
int[,] rotate1 = {
   {7, 4, 1},
   {8, 5, 2},
   {9, 6, 3}
};
int [,] matrix2 = {
   {1, 2},
   {3, 4}
};
int[,] rotate2 = {
   {3, 1},
   {4, 2}
};
int [,] matrix3 = {
   {1, 2, 3, 4},
   {5, 6, 7, 8},
   {9, 10, 11, 12},
   {13, 14, 15, 16}
};
int [,] rotate3 = {
   {13, 9, 5, 1},
   {14, 10, 6, 2},
   {15, 11, 7, 3},
   {16, 12, 8, 4}
};
int [,] matrix4 = {
   {1, 2, 3, 4},
   {5, 6, 7, 8},
   {9, 10, 11, 12},
   {13, 14, 15, 16}
};
int [,] rotate4 = {
   {13, 9, 5, 1},
   {14, 10, 6, 2},
   {15, 11, 7, 3},
   {16, 12, 8, 4}
};
Dictionary<int[,], int[,]> testCases = new Dictionary<int[,], int[,]> {
   {matrix1, rotate1},
   {matrix2, rotate2},
   {matrix3, rotate3},
   {matrix4, rotate4}
};
Practice.Test(testCases);
