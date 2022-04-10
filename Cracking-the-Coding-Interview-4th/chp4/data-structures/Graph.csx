/**
  This implementation is a representation of Graph using Ajancency List method. 
  Here we used C# native LinkedList type. 
  List may also be used in place of the LinkedList typ. 
*/

using System.Collections.Generic;

class Graph1
{
    public Graph1(LinkedList<int>[] listArry, int verices)
    {
        
        for(int i = 0; i < verices; i++)
        {
            listArry[i] = new LinkedList<int>();
        }
    }

    public void AddEdge(LinkedList<int>[] listArry, int u, int v)
    {
        listArry[u].AddLast(v);
        listArry[v].AddLast(u);
    }

    public void PrintGraph(LinkedList<int>[] listArry)
    {
        for(int i = 0; i < listArry.Length; i++)
        {
            Console.WriteLine($"Vertice {i} Edges: ");
            foreach(int x in listArry[i])
            {
                Console.Write($"{i}->{x}, ");
            }
            Console.Write("\n");
        }
    }
}

int vertices = 5;
LinkedList<int>[] listArry = new LinkedList<int>[vertices];
/* This is an undirected graph */
Graph1 graph = new Graph1(listArry, vertices);
graph.AddEdge(listArry, 0, 1);
graph.AddEdge(listArry, 0, 4);
graph.AddEdge(listArry, 1, 2);
graph.AddEdge(listArry, 1, 3);
graph.AddEdge(listArry, 1, 4);
graph.AddEdge(listArry, 2, 3);
graph.AddEdge(listArry, 3, 4);

graph.PrintGraph(listArry);

/**
Output:  
    Vertice 0 Edges: 
    0->1, 0->4, 
    Vertice 1 Edges:
    1->0, 1->2, 1->3, 1->4,
    Vertice 2 Edges:
    2->1, 2->3,
    Vertice 3 Edges:
    3->1, 3->2, 3->4,
    Vertice 4 Edges:
    4->0, 4->1, 4->3,

Online Resource: 
  https://www.geeksforgeeks.org/graph-and-its-representations/
*/