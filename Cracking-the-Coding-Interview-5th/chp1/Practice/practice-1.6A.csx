/**
* Problem: Given an image represented by an MXN matrix, where each pixel in the image is 4bytes,
*   write a method to rotate the image by 90 degrees to the right.
*/
class Practice16A {
    public int[,] RotateRight(int[,] matrix) {
        // Write your solution here
        return rotatedMatrix;
    }

    public bool AreEqual(int[,] matrix1, int[,] matrix2) {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);
        if (rows != rows2 || cols != cols2) {
          return false;
        }

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
           int[,] result = RotateRight(item.Key);
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
   { 1, 2, 3},
   { 4, 5, 6}
};
int[,] matrix1B = {
   { 4, 1},
   { 5, 2},
   { 6, 3}
};

int[,] matrix2A = {
   {1, 2, 3},
   {4, 5, 6},
   {7, 8, 9},
   {10, 11, 12}
};
int[,] matrix2B = {
   {10, 7, 4, 1},
   {11, 8, 5, 2},
   {12, 9, 6, 3}
};
int [,] matrix3A = {
  {1, 2, 3},
  {4, 5, 6},
  {7, 8, 9}
};
int [,] matrix3B = {
  {7, 4, 1},
  {8, 5, 2},
  {9, 6, 3}
};
Dictionary<int[,], int[,]> testCases = new Dictionary<int[,], int[,]> {
    {matrix1A, matrix1B},
    {matrix2A, matrix2B},
    {matrix3A, matrix3B}
};
Practice16A practice = new Practice16A();
practice.Test(testCases);
