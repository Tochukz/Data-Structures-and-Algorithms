/**
  Problem: 
    Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column is set to 0.
*/

class Exercise17
{
    public void MakeZeroLines(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        bool[] rows = new bool[rowCount];
        bool[] cols = new bool[colCount];

        for(int i = 0; i < rowCount; i++)
        {
            for(int j = 0; j < colCount; j++)
            {
                if (matrix[i,j] == 0)
                {
                  rows[i] = true;
                  cols[j] = true;
                }
            }
        }

        for(int i = 0; i < rowCount; i++)
        {
            for(int j = 0; j < colCount; j++)
            {
                if (rows[i] || cols[j])
                {
                    matrix[i,j] = 0;
                }
            }
        }  
    }

    public void MakeZeroLines2(int[,] matrix)
    {
       //Todo: Space optimzed implementation of MakeZeroLines()
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
Exercise17 exer = new Exercise17();

int[,] matrix1 = {
    {1, 1, 1},
    {1, 1, 0}
};
Console.WriteLine("Matix 1: ");
exer.PrintMatrix(matrix1);
exer.MakeZeroLines(matrix1);
Console.WriteLine("Matrix 1 - Zerolined: ");
exer.PrintMatrix(matrix1);

/**
  Method       | Time Complexity | Space Complexity
MakeZeroLines  | O(M*N)          |  O(M+N)

  Output: 
    Matix 1: 
    1 1 1 
    1 1 0
    Matrix 1 - Zerolined:
    1 1 0
    0 0 0

Online Resource 
  https://www.geeksforgeeks.org/a-boolean-matrix-question/

*/