/**
  Problem: 
    Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees. 
    Can you do this in place?
*/

class Exercise16B 
{
    
    private void RowReversal(int[,] matrix)
    {
        int outerLen = matrix.GetLength(0);
        int innerLen = matrix.GetLength(1);
        int start;
        int end;
        for(int i = 0; i < outerLen; i++)
        {
            start = 0;
            end = innerLen - 1;
            while(start < end )
            {
                int temp = matrix[i, end];
                matrix[i, end] =  matrix[i, start];     
                matrix[i, start]  = temp;
                start++;
                end--;       
            }
            
        }
    }

    private void Transpose(int[,] matrix)
    {
        int outerLen = matrix.GetLength(0);
        int innerLen = matrix.GetLength(1);
        for(int i = 0; i < outerLen; i++)
        {
            for(int j = i; j < innerLen; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
    }

    public void RotateRight(int[,] matrix)
    {
       Transpose(matrix);
       RowReversal(matrix);
    }

    public void RotateLeft(int[,] matrix)
    {
        RowReversal(matrix);
        Transpose(matrix);
    }

    public void Flip180(int[,] matrix)
    {
        int outerLen = matrix.GetLength(0);
        int innerLen = matrix.GetLength(1);
        int start;
        int end;
        for(int j = 0; j < innerLen; j++)
        {
           start = 0;
           end = outerLen - 1;
           while(start < end)
           {
               int temp = matrix[start, j];
               matrix[start, j] = matrix[end, j];
               matrix[end, j] = temp;
               start++;
               end--;
           }
        }
    }

    public void PrintMatrix(int[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
           for(int j = 0; j < matrix.GetLength(1); j++)
           {
               Console.Write($"{matrix[i,j]} ");
           }
           Console.Write("\n");
        }
    }
}

Exercise16B exer = new Exercise16B();

int[,] matrix1 = {
    {1,    2,    3,    4},    
    {5,    6,    7,    8},
    {9,    10,   11,   12},
    {13,   14,   15,   16}
};

int[,] matrix2 = {
    {1,    2,    3,    4},    
    {5,    6,    7,    8},
    {9,    10,   11,   12},
    {13,   14,   15,   16}
};

int[,] matrix3 = {
    {1,    2,    3,    4},    
    {5,    6,    7,    8},
    {9,    10,   11,   12},
    {13,   14,   15,   16}
};

Console.WriteLine("Matrix:");
exer.PrintMatrix(matrix1);

exer.RotateRight(matrix1);
Console.WriteLine("Matrix Rotate 90 Clockwise:");
exer.PrintMatrix(matrix1);

exer.RotateLeft(matrix2);
Console.WriteLine("Matrix Rotate 90 Anti-clockwise:");
exer.PrintMatrix(matrix2);

exer.Flip180(matrix3);
Console.WriteLine("Matrix 180 Deg rotate:");
exer.PrintMatrix(matrix3);

/**
This solution handles the rotation of the matrix in-place. 
It only supports square matrices.

Output: 
    Matrix:
    1 2 3 4 
    5 6 7 8
    9 10 11 12
    13 14 15 16
    Matrix Rotate 90 Clockwise:
    13 9 5 1
    14 10 6 2
    15 11 7 3
    16 12 8 4
    Matrix Rotate 90 Anti-clockwise:
    4 8 12 16
    3 7 11 15
    2 6 10 14
    1 5 9 13
    Matrix 180 Deg rotate:
    13 14 15 16
    9 10 11 12
    5 6 7 8
    1 2 3 4

Online Resourse: 
  https://www.geeksforgeeks.org/turn-an-image-by-90-degree/  
  https://www.geeksforgeeks.org/inplace-rotate-square-matrix-by-90-degrees/
  https://www.geeksforgeeks.org/rotate-matrix-90-degree-without-using-extra-space-set-2/
  https://www.geeksforgeeks.org/rotate-a-matrix-by-90-degree-in-clockwise-direction-without-using-any-extra-space/?ref=rp
  https://www.geeksforgeeks.org/rotate-a-matrix-clockwise-by-90-degree-without-using-any-extra-space-set-3/?ref=rp

*/