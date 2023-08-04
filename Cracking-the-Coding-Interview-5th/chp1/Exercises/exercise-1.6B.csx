/**
* Problem: Given an image represented by an NxN matrix, where each pixel in the image is 4bytes,
*   write a method to rotate the image by 90 degrees. 
*   The rotation of the image should be done in place. 
*/

using System;
using System.Collections.Generic;

class Exercise16B {

    public void Transpose(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++) {
            for (int j = i; j < cols; j++) {
                int copy = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = copy;
            }
        }
    }

    public void RowReversal(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);   
        for (int i = 0; i < rows; i++) {
            int startIndex = 0;
            int endIndex = cols - 1;
            while(startIndex < endIndex) {
                int copy = matrix[i, startIndex];
                matrix[i, startIndex] = matrix[i, endIndex];
                matrix[i, endIndex] = copy; 
                startIndex++;
                endIndex--;
            }
        }
    }

    public void RotateRight(int[,] matrix) {
       Transpose(matrix);
       RowReversal(matrix);
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
           RotateRight(item.Key);
           if (AreEqual(item.Key, item.Value)) {
              Console.WriteLine("Pass!");
           } else {
              Console.WriteLine("Failed!");
              PrintMatrix(item.Key);
           }
        }
    }
}

int[,] matrix1A = {
   { 1, 2, 3},
   { 4, 5, 6},
   { 7, 8, 9}
};
int[,] matrix1B = {
   { 7, 4, 1},
   { 8, 5, 2},
   { 9, 6, 3}
};

int[,] matrix2A = {
   {1, 2, 3, 4},
   {5, 6, 7, 8},
   {9, 10, 11, 12},
   {13, 14, 15, 16}
};
int[,] matrix2B = {
   {13, 9, 5, 1},
   {14, 10, 6, 2},
   {15, 11, 7, 3},
   {16, 12, 8, 4}
};
Dictionary<int[,], int[,]> testCases = new Dictionary<int[,], int[,]> {
    {matrix1A, matrix1B},
    {matrix2A, matrix2B}
};
Exercise16B exercise = new Exercise16B();
exercise.Test(testCases);
