/**
Problem: Note: Try to solve this task in-place (with O(1) additional memory), since this is what you'll be asked to do during an interview.
         You are given an n x n 2D matrix that represents an image. Rotate the image by 90 degrees (clockwise).
*/
class RotateImage
{
    void Transponse(int[][] numbers)
    {
        for(int i = 0; i < numbers.Length; i++) 
        {
            for (int j = i; j < numbers[i].Length; j++)
            {
                int temp = numbers[i][j];
                numbers[i][j] = numbers[j][i];
                numbers[j][i] = temp;
            }
        }
    }

    void RowReversal(int[][] numbers)
    {
        for (int i = 0; i <numbers.Length; i++)
        {
            int start  = 0; 
            int end = numbers[i].Length - 1;
            while(start < end)
            {
                int temp = numbers[i][start];
                numbers[i][start] = numbers[i][end];
                numbers[i][end] = temp;
                start++;
                end--;
            }
        }
    }

    int[][] solution(int[][] numbers) {
        Transponse(numbers);
        RowReversal(numbers);
        return numbers;
    }
}