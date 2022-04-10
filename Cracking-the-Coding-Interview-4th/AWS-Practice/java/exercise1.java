import java.util.*;

class exercise1 {
    static int find_missing(List<Integer> input) {
       if (input.size() < 2)
          {
              return -1;
          }
          int firstElem = 1;
          int commonDiff = 1;
          int trueLen = input.size() + 1;
          int trueSum = getSum(trueLen, firstElem, commonDiff); 
          int actualSum = 0;
          for(int i = 0; i < input.size(); i++)
          {
              actualSum += input.get(i);
          }
          int missing = trueSum - actualSum;
          return missing;
    }
  
    private static int getSum(int n, int a, int d)
    {
          int sum = (n/2) * (2*a + (n-1)*d);
          return sum;
    }

    public static void main(String[] args)
    {
        ArrayList<Integer> numbers = new ArrayList<Integer>();
        numbers.add(3); 
        numbers.add(7);
        numbers.add(1);
        numbers.add(2);
        numbers.add(8);
        numbers.add(4);
        numbers.add(5);
        int missing = find_missing(numbers);
        System.out.println("Missing = " + missing);
    }
  }