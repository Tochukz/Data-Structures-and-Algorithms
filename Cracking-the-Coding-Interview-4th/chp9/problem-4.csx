class Result
{

    /*
     * Complete the 'activityNotifications' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY expenditure
     *  2. INTEGER d
     */

    public static int activityNotifications(List<int> expenditure, int lookback)
    {
         if (expenditure.Count < lookback)
         {
             return 0;
         }
         int notices = 0;
         int x = 1;
         int y = 0;
         int[] amounts = new int[lookback];        
         for(int i = 0; i < expenditure.Count; i++)
         {
            
            if (x > lookback)
            {   
                int[] amountCopy = amounts.ToArray();
                Array.Sort(amountCopy); 
                double median = GetMedian(amountCopy);
                
                if (expenditure[i] >= (median * 2))
                {
                    notices++;
                }              
                amounts[y++] = expenditure[i];
            }
            else
            {
                amounts[y++] = expenditure[i];
            }
            
            if ((y + 1) >= lookback && (y + 1) % lookback == 0)
            {
                y = 0;
            }
            x++;
         }
         return notices;
    }
    
    private static double GetMedian(int[] amounts)
    {
        
        int len = amounts.Length;
        if (len % 2 == 0)
        {
            int index1 = len / 2;
            int index2 = index1 - 1;
            return (amounts[index1] + amounts[index2]) / 2.0;
        }
        else
        {
            int index = (len / 2);
            return amounts[index];
        }
    }

}