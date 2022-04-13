class BubbleSort
{
    public static void Sort1(List<int> list)
    {
         int n = list.Count;
         for(int i = 0; i < n; i++)
         {
             for(int j = 0; j < n-1; j++)
             {                 
                 if (list[j] >  list[j+1])
                 {
                    int temp = list[j];
                    list[j] = list[j+1];
                    list[j+1] = temp;                  
                 }
             }
         }       
    }

    /* An optimized bubble sort */
    public static void Sort2(List<int> list)
    {
        int n = list.Count;
        bool swapped;
        for(int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for(int j = 0; j < n - i - 1; j++)
            {
                 if (list[j] >  list[j+1])
                 {
                    int temp = list[j];
                    list[j] = list[j+1];
                    list[j+1] = temp;                                  
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
    }

    public static void PrintList(List<int> list)
    {
        foreach(int num in list)
        {
            Console.Write($"{num} ");
        }
        Console.Write("\n");
    }
}

List<int> scores = new List<int> {64, 34, 25, 12, 22, 11, 90};
Console.Write("Before Sort: \n");
BubbleSort.PrintList(scores);
BubbleSort.Sort1(scores);
Console.Write("After Sort: \n");
BubbleSort.PrintList(scores);

List<int> marks = new List<int> {57, 45, 81,  62, 35, 75, 22};
Console.Write("Before Sort: \n");
BubbleSort.PrintList(marks);
BubbleSort.Sort2(marks);
Console.Write("After Sort: \n");
BubbleSort.PrintList(marks);

/**

Method | Time Complexity | Space Complexity 
Sort1  |   O(n^2)        |    O(1);
Sort2  |   O(n^2)        |    O(1);

Bubble sort is stable 

Output: 
    Before Sort: 
    64 34 25 12 22 11 90 
    After Sort:
    11 12 22 25 34 64 90
    Before Sort:
    57 45 81 62 35 75 22
    After Sort:
    22 35 45 57 62 75 81
*/