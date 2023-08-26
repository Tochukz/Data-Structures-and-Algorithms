/**
* Problem: Write an algorithm such that if an element in an MxN matrix is 0, it's entrire row and column are set to 0.
*/

using System;
using System.Collections.Generic;

class Exercise17 {
   public int[,] Zeroed(int[,] matrix) {
       // Write your solution here
      return new int[,];
   }

   public int[,] Copy(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] copy = new int[rows, cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {               
                copy[i, j] = matrix[i, j];           
            }
        }
        return copy;
   }

   public bool AreEqual(int[,] matrix1, int[,] matrix2) {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (matrix1[i, j] != matrix2[i, j]) {
                    return false;
                }
            }
        }
        return true;
    }

    public void PrintMatrix(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void Test(Dictionary<int[,], int[,]> testCases) {
      foreach(KeyValuePair<int[,], int[,]> item in testCases) {
          int[,] result = Zeroed(item.Key);
          if (AreEqual(result, item.Value)) {
             Console.WriteLine("Pass!");
          } else {
             Console.WriteLine("Failed!");
             Console.WriteLine("Expected:");
             PrintMatrix(item.Value);
             Console.WriteLine("Got:");
             PrintMatrix(result);

          }
      }
   }
}

int[,] matrix1A = {
  { 1, 3, 5},
  { 4, 0, 9},
  { 2, 1, 0}
};
int[,] matrix1B = {
  { 1, 0, 0},
  { 0, 0, 0},
  { 0, 0, 0}
};

int[,] matrix2A = {
  {1, 7, 11, 9},
  {0, 4, 6, 9},
  {7, 2, 1, 7}
};
int[,] matrix2B = {
  {0, 7, 11, 9},
  {0, 0, 0, 0},
  {0, 2, 1, 7}
};

Dictionary<int[,], int[,]> testCases = new Dictionary<int[,], int[,]> {
  {matrix1A, matrix1B},
  {matrix2A, matrix2B}
};
Exercise17 exercise = new Exercise17();
exercise.Test(testCases);