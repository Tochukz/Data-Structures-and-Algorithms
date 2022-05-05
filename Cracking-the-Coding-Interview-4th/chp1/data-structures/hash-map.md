# How HashMaps work internally in Java
[](https://www.youtube.com/watch?v=_yztwXlfNdw)
1. The Hashmap has an internal array of 16 elements which is it's initial capacity.

```
Node<K,V> [] table
```
2. Each of the space of the internal array can hold a `Node` with the following structure.

```
struct Node <K, V> {
  int hash;
  K key;
  V value;
  Node<K,V> next
}

```

__Put Operation__  
1. The hash code of the key is calculated.
```
int hashCode = hashCode(key);
```

2. The index of bucket location in the internal array is calculated.
```
int index = hashcode & (n-1);
```  

3. If there is no element at the index location in the internal array, the Node is inserted in the location.  
__Collision in HashMap__  
If there is already an element in the location, and the hash code of the existing key do not match that of the new key, then the element is linked to the already existing element using the `next` property reference.   

__Get Operation__  
1.  The hash code of the key is calculated.
```
int hashCode = hashCode(key);
```

2. The index of the internal array is calculated from the hash code
```
int index = hashCode & (n-1);
```
3. Consider that the elements of the internal array is essentially a linked list.   
Get the head element of the linked list using you index.
Traverse through the linked list and find the node that have the matching hash code and key.   
