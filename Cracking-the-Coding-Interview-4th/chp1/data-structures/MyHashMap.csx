/**
  This is my implementation of the HashMap 
*/

class Item<K, V>
{
    public int hash;

    public K key;

    public V value;

    public Item(K ky, V val)
    {
        key = ky;
        value = val;
    }
}

class MyHashMap<K, V>
{
    LinkedList<Item<K, V>>[] Storage = new LinkedList<Item<K, V>>[16];
   
    public void Put(K key, V value)
    {
        int hashCode = key.GetHashCode();        
        int index = hashCode & (Storage.Length -1);
        Item<K, V> newNode = new Item<K, V>(key, value) {hash = hashCode};
        if (Storage[index] == null )
        {
            
            LinkedList<Item<K, V>> linkedList = new LinkedList<Item<K, V>>();
            linkedList.AddFirst(newNode);
            Storage[index] = linkedList;
        }
        else {
            LinkedList<Item<K, V>> linkedList = Storage[index];
            LinkedListNode<Item<K,V>> lastNode  = linkedList.Last;
            if (lastNode.Value.hash == hashCode)
            {
                lastNode.Value.value = value;
            }
            else 
            {
              linkedList.AddLast(newNode); 
            }
        }
    }


    public V Get(K key)
    {
        int hashCode = key.GetHashCode();        
        int index = hashCode & (Storage.Length - 1);       
        if (Storage[index] == null)
        {
            throw new Exception("Index is empty!");
        }
        LinkedList<Item<K, V>> linkedList = Storage[index];
        foreach(Item<K, V> node in linkedList)
        {
            if (node.hash == hashCode)
            {
                return node.value;
            }
        }

        throw new Exception("Key not found 2");
    }
}

MyHashMap<string, string> hashMap = new MyHashMap<string, string>();
hashMap.Put("name", "Tochukwu");
hashMap.Put("position", "SDE II");
hashMap.Put("ambition", "Principal Engineer");

Console.WriteLine("Name: " + hashMap.Get("name"));
Console.WriteLine("Position: " + hashMap.Get("position"));
Console.WriteLine("Ambition: " + hashMap.Get("ambition"));

