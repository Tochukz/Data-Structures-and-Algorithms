/**
Problem: 
  Given an array of strings, return all groups of strings that are anagrams. The groups must be created in order of their appearance in the original array. Look at the sample case for clarification.

  Note: The finial output will be in lexicographic order.
*/

import java.util.*;

class Exercise92X {
    private boolean areAnagrams(String word1, String word2)
    {
        char[] letters1 = word1.toCharArray();
        char[] letters2 = word2.toCharArray();
        Arrays.sort(letters1);
        Arrays.sort(letters2);
        
        String name1 = new String(letters1);
        String name2 = new String(letters2);    
        return name1.equals(name2);
    }

    public List<List<String>> Anagrams(String[] words)
    {
        HashMap<String, List<String>> map = new HashMap<String, List<String>>();
        String[] sorted = new String[1];
        for(String word1 : words)
        {
            char[] letters = word1.toCharArray();
            Arrays.sort(letters);
            String sortedWord = new String(letters); 
            if (!map.containsKey(sortedWord))
            {
                map.put(sortedWord, new ArrayList<String>());
            }
            for(String word2 :  words)
            {                
                if (areAnagrams(word1, word2))
                {                                       
                    List<String> list = map.get(sortedWord);
                    if (!list.contains(word1))
                    {
                        list.add(word1);
                    }
                    if (!list.contains(word2))
                    {
                        list.add(word2);
                    }
                }

            }
        }
        return new ArrayList<List<String>>(map.values());
    }

    public void printLiList(List<List<String>> liList)
    {
        for(List<String> llist : liList)
        {
            for(String word : llist)
            {
                System.out.print(word + " ");
            }
            System.out.print("\n");
        }
    } 

    public static void main(String[] args) 
    {
        Exercise92X exer92X = new Exercise92X();

        String[] words = {"act", "god", "cat", "dog", "tac"};
        List<List<String>> liList1 = exer92X.Anagrams(words);
        exer92X.printLiList(liList1);
        
        // This solution does not work as expected for string of letters. Because it does not honor duplicates i.e d and d are the same.
        String[] letters = {"k", "e", "q", "e", "d", "p", "e", "s", "x", "k", "d", "k", "g", "d"};
        List<List<String>> liList2 = exer92X.Anagrams(letters);
        exer92X.printLiList(liList2);
    }
}

/**
 
This solution does not work correctly yet, for all cases online

Online Resource: 
  https://practice.geeksforgeeks.org/problems/print-anagrams-together/1# 
*/