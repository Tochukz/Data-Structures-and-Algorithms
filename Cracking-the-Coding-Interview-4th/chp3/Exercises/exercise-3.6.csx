
/**
Problem:  
  Write a program to sort a stack in ascending order. You should not make any assumptions about how 
  the stack is implemented. The following are the only functions that should be used to write 
  this program: push | pop | peek | isEmpty.
*/

class Exercise36 
{
   public static Stack<int> Sort(Stack<int> input)
   {
       Stack<int> sorted = new Stack<int>();
       while(input.Count > 0)
       {
           int temp =  input.Pop();
           while(sorted.Count != 0 && sorted.Peek() > temp)
           {
              input.Push(sorted.Pop());
           }
           sorted.Push(temp);
       }
       return sorted;
   }  

   public static void PrintStack(Stack<int> stack)
   {
       int[] numbers = stack.ToArray();
       foreach(int x in numbers)
       {
           Console.Write("{0} ", x);
       }
       Console.Write("\n");
   }
}


Stack<int> numbersStack = new Stack<int>(new int[]{2, 5, 11, 9, 2, 7, 16, 0, 5});
Exercise36.PrintStack(numbersStack); // 5 0 16 7 2 9 11 5 2

Stack<int> sortedStack = Exercise36.Sort(numbersStack);
Exercise36.PrintStack(sortedStack); // 16 11 9 7 5 5 2 2 0

