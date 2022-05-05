public class RunningMedian {
    public static void splitNSort(List<Integer> list, int start, int mid, int end)
    {
        int len1 = mid - start + 1;
        int len2 = end - mid;                
        List<Integer> half1 = new ArrayList<Integer>();
        List<Integer> half2 = new ArrayList<Integer>();
        
        int i;
        int j;
        for(i = 0; i < len1; i++) {
            half1.add(list.get(start + i));
        }
        for ( j = 0 ; j < len2; j++) {
            half2.add(list.get(j + mid + 1));
        }
        
        i = 0;
        j = 0;
        int k = start;
        while(i < len1 || j < len2) {
            if (i < len1 && j < len2) {
                int x = half1.get(i);
                int y = half2.get(j);
                if ( x < y ) {
                    list.set(k, x);
                    i++;
                } else {
                    list.set(k, y);
                    j++;
                }
            } else if (i < len1) {
                int x = half1.get(i);
                list.set(k, x);
                i++;                
            } else if (j < len2) {
                int y = half2.get(j);
                list.set(k, y);
                j++;   
            }
            k++;
        }        
    }
    
    public static void sortNMerge(List<Integer> list, int start, int end){
        if (start < end) {
            int mid = (start + end) / 2;
            sortNMerge(list, start, mid);
            sortNMerge(list, mid + 1, end);
            
            
            splitNSort(list, start, mid, end);
        }        
    }

    public static void sortedAdd(List<Integer> list, int value) {
       List<Integer> sorted = new ArrayList<Integer>();
       boolean added = false;
       for(int i = 0; i < list.size() - 1; i++) {
            int current = list.get(i);
            if (i == 0) {
                if (value < current && !added) {
                    sorted.add(value);
                    sorted.add(current);
                    added = true;
                }
                continue;
            }
            int next = list.get(i+1);
            if(!added && value > current && value < next) {
                sorted.add(current);
                sorted.add(value);  
                added = true;              
            }  else if (!added && value < current) {
                sorted.add(value);
                sorted.add(current);
                added = true;
            } else if (!added && i + 1 == list.size() -1) {
                sorted.add(current);
                sorted.add(value);  
                added = true;   
                added = true;
            } else{
                sorted.add(current);
            }
            
       }
    }
    public static List<Double> runningMedian(List<Integer> list) {
    // Write your code here
        List<Double> medians = new ArrayList<Double>();
        
        //Arrays.sort(numbers);
        //i = 0;
        List<Integer> numbers = new ArrayList<Integer>();
        for(int j = 0; j < list.size(); j++) {
            numbers.add(list.get(j));
            int mid = (j + 1) / 2;                  
            sortNMerge(numbers, 0, j);
            if (j == 0) {
                medians.add((double)list.get(j));
            } else if ((j + 1) % 2 == 0) {
               double median =  (numbers.get(mid-1) + numbers.get(mid)) / 2.0;
               medians.add(Math.round(median * 10.0) / 10.0);
            } else {
              double median = (double)numbers.get(mid);
              medians.add(Math.round(median * 10.0) / 10.0);
            }
            
           // i++;
        }
        List<Double> medi = new ArrayList<Double>(medians);
        return medi;
    }

}

/**
Note: This solution times out when run online
      This means an optimization is required
      
Online Resource: 
  https://www.hackerrank.com/challenges/find-the-running-median/problem
*/