/**
  This implements a Breadth-First Search of a Graph using a queue
*/

using System.Collections.Generic;

class GraphBFS
{
   LinkedList<int>[] AdjList;

   public GraphBFS(int vertices)
   {
       AdjList = new LinkedList<int>[vertices];
       for(int i = 0; i < AdjList.Length; i++)
       {
           AdjList[i] = new LinkedList<int>();
       }
   }

   public void AddEdge(int v, int w)
   {
       AdjList[v].AddLast(w);
   }

   /* Breath-First Traversal aka Level Order Traversal*/
   public void TraverseLevelOrder(int v)
   {
        bool[] visited = new bool[AdjList.Length];

        Queue<int> que = new Queue<int>();
        que.Enqueue(v);
        visited[v] = true;
        while(que.Count > 0)
        {
            int x  = que.Dequeue();
            Console.Write($"{x} ");

            LinkedList<int> list =  AdjList[x];
            foreach(int y in list)
            {
                if (!visited[y])
                {
                    visited[y] = true;
                    que.Enqueue(y);
                }
            }
        }
        Console.Write("\n");
   }
}


/* This is a directed Graph */
GraphBFS graph = new GraphBFS(4);
graph.AddEdge(0, 1);
graph.AddEdge(0, 2);
graph.AddEdge(1, 2);
graph.AddEdge(2, 0);
graph.AddEdge(2, 3);
graph.AddEdge(3, 3);

/* traversal starting at vertice 2 */
graph.TraverseLevelOrder(2);

/**

 Method             | Time Complexity | Space Complexity 
TraverseLevelOrder  |   O(V+E)        |     O(V)         
Where v = number of vertices and E = number of edges 

Note that the TraverseLevelOrder method traverses only the vertices reachable from a given source vertex.
All the vertices may not be reachable from a given vertex (for example Disconnected graph). 
To print all the vertices, we can modify the BFS function to do traversal starting from all nodes one by one

Output: 
  2 0 3 1 

Online Resource: 
    https://www.geeksforgeeks.org/breadth-first-search-or-bfs-for-a-graph/
*/