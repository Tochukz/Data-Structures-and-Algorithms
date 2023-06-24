using System;

class BinaryGap {
    public int LongestBinaryGap(int number) {
        string binaryStr = Convert.ToString(number, 2);            
        int gap = 0;   
        int i = 0;
        while ( i < binaryStr.Length) {      
           if (binaryStr[i] == '1') {                  
             int zeroCount = 0;   
             int j;                     
             for(j = i + 1; j < binaryStr.Length; j++) {          
                if (binaryStr[j] == '0') {
                    zeroCount++;                                                      
                } else  {
                    if (zeroCount > gap) {                        
                        gap = zeroCount;                        
                    }
                    break;
                }                                  
             }     
             i = j;         
           } else {
              i++;  
           }                   
        }     
        return gap;
    }

    public bool Test(int number, int answer) {
        return this.LongestBinaryGap(number) == answer;
    }
}

BinaryGap binaryGap = new BinaryGap();
Dictionary<int, int> questionAnswers = new Dictionary<int, int> {
    {9, 2},
    {529, 4},
    {20, 1},
    {15, 0},
    {32, 0},
    {1162, 3},
    {51712, 2},
    {561892, 3},
    {74901729, 4},
    {805306373, 25},
    {1376796946, 5}
};
int i = 1;
foreach(var questAns in questionAnswers) {    
    bool result = binaryGap.Test(questAns.Key, questAns.Value);
    string resultStr = "Passed";
    if (!result) {
      int val  = binaryGap.LongestBinaryGap(questAns.Key);
      resultStr = $"Failed: \nArgument: {questAns.Key} \nExpected: {questAns.Value}, Got: {val}";      
    }    
     Console.WriteLine($"Result {i}: " + resultStr);
    i++;
}
