/**
* Problem: Given an image represented by an NxN matrix, where each pixel in the image is 4bytes,
*   write a method to rotate the image by 90 degrees. 
*   The rotation of the image should be done in place. 
*/

using System;
using System.Collections.Generic;

class Practice16B {

    public void RotateRight(int[,] matrix) {
        // Write your solution here
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

    public bool IsSquareMaxtrix(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        return rows == cols;
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
            if (!IsSquareMaxtrix(item.Key) || !IsSquareMaxtrix(item.Value)) {
                Console.WriteLine("Arguments of the test cases must be NxN square matrices!");
                return;
            }
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
Practice16B practice = new Practice16B();
practice.Test(testCases);
