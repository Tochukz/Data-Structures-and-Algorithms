public class ExerciseD {
    int binarysearch(int arr[], int n, int val) {
        int start = 0;
        int end = n -1;
        int midIndex, midValue;
        while(start <= end)
        {            
            midIndex = (start + end) / 2;
            midValue = arr[midIndex];
            if (val == midValue)
            {
                return midIndex;
            }
            else if(val < midValue)
            {
                end = midIndex  - 1;
            }
            else
            {
                start = midIndex + 1;
            }
        }
        
        return -1;
    }

    public static void main(String[] args)
    {
        ExerciseD exerD = new ExerciseD();
        int arr[] = {1, 2, 3, 4, 5}; 
        int val = 4;
        int index1 = exerD.binarysearch(arr, arr.length, val);
        System.out.printf("index1 = %d\n", index1);
        int arr2[] = {11, 22, 33, 44, 55};
        val = 445;
        int index2 = exerD.binarysearch(arr2, arr2.length, val);
        System.out.println("index2 = " + index2);
    }
}

/**

Online Resource: 
  https://practice.geeksforgeeks.org/problems/binary-search/1#

*/