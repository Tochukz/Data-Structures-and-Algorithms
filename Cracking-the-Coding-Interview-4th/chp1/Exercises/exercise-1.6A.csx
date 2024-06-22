/**
  Problem:
    Given an image represented by an MxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees.
    Can you do this in place?
*/

class Exercise16A
{
    public int[,] RotateRight(int[,] matrix)
    {
        if (matrix.Length == 0)
        {
            return matrix;
        }
        int outerLen = matrix.GetLength(0);
        int innerLen = matrix.GetLength(1);

        int[,] transformedMatrix = new int[innerLen, outerLen];
        int x = 0;
        for (int j = 0; j < innerLen; j++)
        {
            int y = 0;
            for(int i = outerLen - 1; i >= 0; i--)
            {
              transformedMatrix[x, y] = matrix[i, j];
              y++;
            }
            x++;
        }
        return transformedMatrix;
    }

    public int[,] RotateLeft(int[,] matrix)
    {
        if (matrix.Length == 0)
        {
            return matrix;
        }
        int outerLen = matrix.GetLength(0);
        var innerLen = matrix.GetLength(1);

        int[,] transformedMatrix = new int[innerLen, outerLen];
        int x = 0;
        for (int j = innerLen -1; j >=0; j--)
        {
            int y = 0;
            for(int i = 0; i < outerLen; i++)
            {
              transformedMatrix[x, y] = matrix[i, j];
              y++;
            }
            x++;
        }
        return transformedMatrix;
    }

    public int[,] Flip180(int[,] matrix)
    {
        int outerLen = matrix.GetLength(0);
        int innerLen = matrix.GetLength(1);
        int[,] flippedMatrix = new int[outerLen, innerLen];

        int k =  0;
        for(int i = outerLen - 1; i >= 0; i--)
        {
           for(int j = 0; j < innerLen; j++)
           {
             flippedMatrix[k, j] = matrix[i, j];
           }
           k++;
        }
        return flippedMatrix;
    }

    public void PrintMatrix(int[,] matrix)
    {
        for(int i = 0;  i < matrix.GetLength(0); i++)
        {
           for(int j = 0; j  < matrix.GetLength(1); j++)
           {
               int val = matrix[i,j];
               string space = "  ";
               if (val >= 10)
               {
                  space = " ";
               }
               Console.Write($"{val} {space}");
           }
           Console.Write("\n");
        }
    }
}


Exercise16A exer = new Exercise16A();
int[,] matrix = {
    {1,    2,    3,    4},
    {5,    6,    7,    8,},
    {9,    10,    11,    12}
};
Console.WriteLine("Matrix 1:");
exer.PrintMatrix(matrix);

int[,] transformed90Right = exer.RotateRight(matrix);
Console.WriteLine("Matrix 1 90 Deg right rotate:");
exer.PrintMatrix(transformed90Right);

int[,] transformed90Left = exer.RotateLeft(matrix);
Console.WriteLine("Matrix 1 90 Deg left rotate:");
exer.PrintMatrix(transformed90Left);

int[,] transformed180 = exer.Flip180(matrix);
Console.WriteLine("Matrix 1 180 Deg rotate:");
exer.PrintMatrix(transformed180);

/**
The solution using an auxillary space of O(n).
The solution supports the rotation of non-square matrix.

To handle the rotation of a square matrix in-place, see exercise-1.6B

Output:
  Matrix 1:
  1   2   3   4
  5   6   7   8
  9   10  11  12
  Matrix 1 90 Deg right rotate:
  9   5   1
  10  6   2
  11  7   3
  12  8   4
  Matrix 1 90 Deg left rotate:
  4   8   12
  3   7   11
  2   6   10
  1   5   9
  Matrix 1 180 Deg rotate:
  9   10  11  12
  5   6   7   8
  1   2   3   4

Online Resourse:
  https://www.geeksforgeeks.org/turn-an-image-by-90-degree/
  https://www.geeksforgeeks.org/inplace-rotate-square-matrix-by-90-degrees/
  https://www.geeksforgeeks.org/rotate-matrix-90-degree-without-using-extra-space-set-2/
  https://www.geeksforgeeks.org/rotate-a-matrix-by-90-degree-in-clockwise-direction-without-using-any-extra-space/?ref=rp
  https://www.geeksforgeeks.org/rotate-a-matrix-clockwise-by-90-degree-without-using-any-extra-space-set-3/?ref=rp
*/
