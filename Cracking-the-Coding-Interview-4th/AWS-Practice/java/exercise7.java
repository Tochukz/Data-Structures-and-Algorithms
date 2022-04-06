
class exercise7 {
    public static boolean canSegmentString(String str, Set<String> dictionary) {
      HashSet<String> words = new HashSet<String>();
      for(String word : dictionary)
      {
         if (str.indexOf(word) > -1)
         {
            words.add(word);
         }
      }
      for(String strA : words)
      {
         for(String strB : words)
         {
             if (str.equals(strA + strB))
             {
                 return true;
             }
         }
      }
      return false;
    }
} 