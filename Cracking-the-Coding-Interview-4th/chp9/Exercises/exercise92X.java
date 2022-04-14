/**
Problem: 
  Given an array of strings, return all groups of strings that are anagrams. The groups must be created in order of their appearance in the original array. Look at the sample case for clarification.

  Note: The finial output will be in lexicographic order.
*/

class exercise92X {
    private boolean AreAnagrams(String word1, String word2, String[] sorted)
    {
        char[] letters1 = word1.toCharArray();
        char[] letters2 = word2.toCharArray();
        Arrays.sort(letters1);
        Arrays.sort(letters2);
        
        String name1 = new String(letters1);
        String name2 = new String(letters2);
        sorted[0] = name1;
        return name1.equals(name2);
    }

    public List<List<String>> Anagrams(String[] words)
    {
        HashMap<String, List<String>> map = new HashMap<String, List<String>>();
        String[] sorted = new String[1];
        for(String word1 : words)
        {
            for(String word2 :  words)
            {
                
                if (AreAnagrams(word1, word2, sorted))
                {
                    String word = sorted[0];
                    if (!map.containsKey(word))
                    {
                        map.put(word, new ArrayList<String>());
                    }
                    List<String> list = map.get(word);
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
}

/**
 
This solution does not work correctly yet, for all cases online

Online Resource: 
  https://practice.geeksforgeeks.org/problems/print-anagrams-together/1# 
*/