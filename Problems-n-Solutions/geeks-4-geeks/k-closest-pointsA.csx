/**
  Problem: Given a list of points on the 2-D plane and an integer K. The task is to find K closest points to the origin and print them.
  
  Note: The distance between two points on a plane is the Euclidean distance.
*/


class KClosestPointA
{
    public static int OriginDistanceSqr(int x, int y)
    {
        int disSquare =  (x * x)  + (y * y);
        return disSquare;
    }

    public static int[,] ClosestK(int[,] points, int k)
    {
        int pointsCount = points.GetLength(0);
        int[] distances = new int[pointsCount];
        for(int i = 0; i < pointsCount; i++)
        {
            int x = points[i, 0];
            int y = points[i, 1];
            distances[i] = OriginDistanceSqr(x, y);
        }

        Array.Sort(distances);

        int kthDist = distances[k-1]; 
        int[,] kClosest = new int[k,2];
        int j = 0;
        for (int i = 0; i < pointsCount; i++)
        {
            int x = points[i, 0];
            int y = points[i, 1];
            int s = OriginDistanceSqr(x, y);
            if (s <= kthDist)
            {
                kClosest[j, 0] = x;
                kClosest[j, 1] = y;
                j++;
            }
            
        } 

        return kClosest;
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
int[,] kPoints = KClosestPointA.ClosestK(points, K);
KClosestPointA.PrintPoints(kPoints);

/**
  Method | Time Complexity | Space Complexity 
ClosestK |  O(n log n)     |   O(n)

Note that this solution only returns the k closest points. 
The points return are not sorted in order of their distances to the origin.
 
Time complexity to find the distance from the origin for every point is O(n) and to sort the array is O(n log n)

Output:  
  [[3, 3] [1, 2] ]

Online Resource 
  https://www.geeksforgeeks.org/find-k-closest-points-to-the-origin/
*/

