class exercise1 {
    static int find_missing(List<Integer> input) {
       if (input.size() < 2)
          {
              return -1;
          }
          int firstElem = 1;
          int commonDiff = 1;
          int trueLen = input.size() + 1;
          int trueSum = GetSum(trueLen, firstElem, commonDiff); 
          int actualSum = 0;
          for(int i = 0; i < input.size(); i++)
          {
              actualSum += input.get(i);
          }
          int missing = trueSum - actualSum;
          return missing;
    }
  
    private static int GetSum(int n, int a, int d)
    {
          int sum = (n/2) * (2*a + (n-1)*d);
          return sum;
    }

    public static void main(string[] args)
    {
        
    }
  }