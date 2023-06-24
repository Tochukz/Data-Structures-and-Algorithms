class LongestPassword {

  // This method is an implementatio of array.Contains(arg) which is not supported in C# 6
  private bool Contains(string[] words, string word) {
    foreach(string wrd in words) {
        if (wrd == word) {
            return true;
        }
    }
    return false;
  }

  private bool IsValid(string pwd) {
    int alphaCount = 0;
    int digitCount = 0;
    string[] allowed = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", 
                        "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", 
                        "u", "v", "w", "x", "y", "z"};
    for(int i = 0; i < pwd.Length; i++) {
       char x = pwd[i];
       string xStr = x.ToString().ToLower();
       int result;
       bool intPassed = int.TryParse(xStr, out result);
       // C# 6.0 arrays does't not support the Contains() method. 
       // For higher versions of C# you could do: !allowed.Contains(xStr) instead
       if (!intPassed && !Contains(allowed, xStr)) {
          return false;
       }
       if (intPassed) {
         digitCount++;
       } else {
        alphaCount++;
       }
    }
    return (alphaCount % 2 == 0) && (digitCount % 2 == 1);
  }

  public int GetLongestPwd(string phrase) {
    string[] words = phrase.Split(" ");
    int maxLen = -1;
    foreach (string word in words) {
        if (IsValid(word) && word.Length > maxLen) {
            maxLen = word.Length;
        }
    }
    return maxLen;
  }

  public bool Test(string phrase, int ans) {
    return this.GetLongestPwd(phrase) == ans;
  }
}

LongestPassword longestPassword = new LongestPassword();
Dictionary<string, int> testCases = new Dictionary<string, int> {
  {"test 5 a0A pass007 ?xy1", 7}
};
int i = 1;
foreach (KeyValuePair<string, int> item in testCases) {
  bool result = longestPassword.Test(item.Key, item.Value);
  string resultStr = "Passed";
  if (!result) {
     int val = longestPassword.GetLongestPwd(item.Key);
     resultStr = $"Failed: \nArgument: '{item.Key}' \nExpected: {item.Value}, Got: {val}";
  }
  Console.WriteLine($"Result {i}: " + resultStr);
  i++;
}