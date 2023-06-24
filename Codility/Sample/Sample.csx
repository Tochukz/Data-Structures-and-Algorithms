using System;

class Sample {
  public int SmallestPositive(int[] numbers) {
    bool allNegative = true;
    int i;
    for (i = 1; i < numbers.Length; i++ ) {
        bool found = false;
        foreach(int n in numbers) {
            if (n > 0) {
                allNegative = false;
            }
            if (i == n) {
               found = true;
            }
        }
        if (found == false) {
            return i;
        }
    }
    if (allNegative) {
      return 1;
    }
    return i + 1;
  }

  public bool Test(int[] numbers, int answer) {
    return this.SmallestPositive(numbers) == answer;
  }
}

Sample sample = new Sample();
bool result1 = sample.Test(new int[] {1, 3, 6, 4, 1, 2}, 5);
bool result2 = sample.Test(new int[] {1, 2, 3}, 4);
bool result3 = sample.Test(new int[] {-1, -3}, 1);

Console.WriteLine("result1: " + (result1 == true ? "Passed" : "Failed"));
Console.WriteLine("result2: " + (result2 == true ? "Passed" : "Failed"));
Console.WriteLine("result3: " + (result3 == true ? "Passed" : "Failed"));