public class Exercise16
{
    private void rotateby90(int matrix[][], int n) 
    { 
        
        int start;
        int end;
        // Reverser the Rows
        for(int i = 0; i < matrix.length; i++)
        {
            start = 0;
            end = matrix[i].length - 1;
            while(start < end)
            {
                int temp = matrix[i][start];
                matrix[i][start] = matrix[i][end];
                matrix[i][end] = temp;
                start++;
                end--;
            }
        }
        
        // Transpose the matrix
        for(int i = 0; i < matrix.length; i++)
        {
            for(int j = i; j < matrix[i].length; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }

    private void printMatrix(int[][] matrix)
    {
        for(int i = 0; i < matrix.length; i++)
        {
           for(int j = 0; j < matrix[i].length; j++)
           {
               System.out.printf("%d ", matrix[i][j]);
           }
           System.out.print("\n");
        }
    }
    public static void main(String[] args)
    {
        int[][] matrix = {
            {1,    2,    3,    4},    
            {5,    6,    7,    8},
            {9,    10,   11,   12},
            {13,   14,   15,   16}
        };
        Exercise16 exer = new Exercise16();
        System.out.println("Matrix: ");
        exer.printMatrix(matrix);

        exer.rotateby90(matrix,  matrix.length);
        System.out.println("After 90 anti0clockwise rotate: ");
        exer.printMatrix(matrix);
    }
}