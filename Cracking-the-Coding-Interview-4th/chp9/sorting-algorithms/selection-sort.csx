class SelectionSort
{
    public void Sort(List<int> list)
    {
        int n = list.Count;
        for(int i = 0 ; i < n -1; i++)
        {
            int minIndex = i;
            for(int j = i+1; j < n; j++)
            {
                if (list[j] < list[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = list[i];
            list[i] = list[minIndex];
            list[minIndex] = temp;
        }
    }
}

/**

NB: The default implementation of selecion sort is not stable
*/