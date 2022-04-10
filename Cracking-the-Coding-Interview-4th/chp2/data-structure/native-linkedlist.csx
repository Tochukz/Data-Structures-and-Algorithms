using System.Collections.Generic;

LinkedList<string> boys  = new LinkedList<string>();

boys.AddLast("Clark");
boys.AddLast("Derick");
boys.AddLast("Emmanuel");
boys.AddLast("Fedrick");
boys.AddFirst("Boris");

LinkedListNode<string> gene = new LinkedListNode<string>("Gene");
LinkedListNode<string> henry = new LinkedListNode<string>("Henry");
boys.AddLast(gene);
boys.AddLast(henry);
boys.AddBefore(gene, "Gary");
boys.AddAfter(gene, new LinkedListNode<string>("Gregory"));
boys.AddLast("Henry");
boys.AddLast("Isaiah");

foreach(string name in boys)
{
    Console.Write($"{name} ");
}
Console.Write("\n");


boys.RemoveLast();
boys.RemoveFirst();
boys.Remove("Gary");
boys.Remove(henry);

foreach(string name in boys)
{
    Console.Write($"{name} ");
}
Console.Write("\n");

if (boys.Contains("Gene"))
{
    Console.WriteLine("boys LinkedList contains the name 'Gene'");
}
LinkedListNode<string> emmaNode = boys.Find("Emmanuel"); 
LinkedListNode<string> henryNode = boys.FindLast("Henry");
Console.WriteLine($"{emmaNode.Value}, {henryNode.Value}");


LinkedList<string> ladies = new LinkedList<string>(new string[]{"Abegail", "Cathrine", "Emma"});
LinkedListNode<string> cate = ladies.Find("Cathrine");
if (cate != null)
{
  ladies.AddBefore(cate, "Beatrice");
  ladies.AddAfter(cate, "Doris");
}
ladies.AddFirst("Anna");
ladies.AddLast("Jane");

for(int i = 0; i < ladies.Count; i++)
{
    string name = ladies.ElementAt(i);
    Console.Write($"{name} ");
}
Console.Write("\n");


/**

Output: 
  Boris Clark Derick Emmanuel Fedrick Gary Gene Gregory Henry Henry Isaiah 
  Clark Derick Emmanuel Fedrick Gene Gregory Henry
  boys LinkedList contains the name 'Gene'
  Emmanuel, Henry
  Anna Abegail Beatrice Cathrine Doris Emma Jane

Online Resources: 
  https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?vie
  https://www.geeksforgeeks.org/linked-list-implementation-in-c-sharp/
*/