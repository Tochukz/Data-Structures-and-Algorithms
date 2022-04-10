
import java.util.*;

class exercise2 {
    static boolean findSumOfTwo(int[] numbers, int val) {
      HashSet<Integer> numberSet = new HashSet<Integer>();
      for(Integer x : numbers)
      {   
          numberSet.add(x);
          int diff = val - x;
          if (numberSet.contains(diff))
          {
              return true;
          }
          
      }
      return false;
    }

    public static void main(String[] args)
    {
        
    }
  } 