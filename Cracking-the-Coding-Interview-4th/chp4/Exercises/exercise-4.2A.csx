/**
 Problem: Given a directed graph, design an algorithm to find out whether there is a route between two nodes. 

 I implement a solution using Breadth-First Search (BFS)
*/

using System.Collections.Generic;

class DirectedGraph
{
    LinkedList<int>[] AdjList;

    public DirectedGraph(int vertices)
    {
        AdjList = new LinkedList<int>[vertices];
        for(int i = 0; i < vertices; i++)
        {
           AdjList[i] = new LinkedList<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        AdjList[v].AddLast(w);
    }

    public bool PathExists(int v, int w)
    {
        Queue<int> que = new Queue<int>();
        bool[] visited = new bool[AdjList.Length];

        que.Enqueue(v);
        visited[v] = true;

        while(que.Count > 0)
        {
            int x = que.Dequeue();
            LinkedList<int> list = AdjList[x];
            foreach(int y in list)
            {
                if (y == w)
                {
                    return true;
                }
                if (!visited[y])
                {
                    visited[y] = true;
                    que.Enqueue(y);
                }
            }
        }

        return false;
    }
}

DirectedGraph graph = new DirectedGraph(4);
graph.AddEdge(0, 1);
graph.AddEdge(0, 2);
graph.AddEdge(1, 2);
graph.AddEdge(2, 0);
graph.AddEdge(2, 3);
graph.AddEdge(3, 3);


bool path1To3 = graph.PathExists(1, 3);
if (path1To3)
{
    Console.WriteLine("Path exists from 1 to 3");
}
else 
{
    Console.WriteLine("NO Path exists from 1 to 3");
}

bool path3To1 = graph.PathExists(3, 2);
if (path3To1)
{
    Console.WriteLine("Path exists from 3 to 1");
}
else 
{
    Console.WriteLine("NO Path exists from 3 to 1");
}
/**
  
 Method     | Time COmplexity | Space Complexity 
PathExists  |    O(V+E)       |   O(V)
Where V = number of Vertics and E = number of Edges of the graph

Output: 
  Path exists from 1 to 3
  NO Path exists from 3 to 1

Online Resources: 
  https://www.geeksforgeeks.org/find-if-there-is-a-path-between-two-vertices-in-a-given-graph/
*/

