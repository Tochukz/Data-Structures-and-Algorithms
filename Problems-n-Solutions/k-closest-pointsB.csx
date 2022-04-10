/**
  Problem: Given a list of points on the 2-D plane and an integer K. The task is to find K closest points to the origin and print them.
  
  Note: The distance between two points on a plane is the Euclidean distance.
*/

class CompareDistances : IComparer<KeyValuePair<int[], int>>
{
    public int Compare(KeyValuePair<int[], int> item1, KeyValuePair<int[], int> item2)
    {
        if (item1.Value < item2.Value)
        {
            return -1;
        }

        return 1;
    }
}

class KClosestPointB 
{
    public static int OriginDistanceSqr(int x, int y)
    {
        int disSquare =  (x * x)  + (y * y);
        return disSquare;
    }

    public static int[,] ClosestK(int[,] points, int k)
    {
        if (k > points.GetLength(0))
        {
            throw new Exception("k should not be greater than number of points!");
        }

        Dictionary<int[], int> pointAndDist = new Dictionary<int[], int>();
        for(int i = 0; i < points.GetLength(0); i++)
        {
            int x = points[i, 0];
            int y = points[i, 1];
            int s = OriginDistanceSqr(x, y);
            pointAndDist.Add(new int[]{x, y}, s);
        }

        List<KeyValuePair<int[], int>> pointList = pointAndDist.ToList();
        pointList.Sort(new CompareDistances());

        int[,] kPoints = new int[k,2];
        for (int i = 0; i < k; i++)
        { 
            KeyValuePair<int[], int> point = pointList[i];
            kPoints[i, 0] = point.Key[0];
            kPoints[i, 1] = point.Key[1];
        }
        return kPoints;
    }

    public static void PrintPoints(int[,] points)
    {
        Console.Write("[");
        for(int i = 0; i < points.GetLength(0); i++)
        {
            int x = points[i, 0];
            int y = points[i, 1];
            Console.Write($"[{x}, {y}] ");
        }
        Console.Write("]");
    }
}
int [,] points = {{3, 3}, {5, -1}, {1, 2}, {-2, 4}};
int K = 2;
int[,] kPoints = KClosestPointB.ClosestK(points, K);
KClosestPointB.PrintPoints(kPoints);

/**

This solution returns the k closest points and the points returned are sorted according the distance to the origin from shortest to ongest distance. 

Output:  
  [[1, 2] [3, 3] ]
*/


