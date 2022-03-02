# Data Structures and Algorithms with JavaScript (2014)
__By Michael McMillan__   
[Github Code](https://github.com/oreillymedia/data_structures_and_algorithms_using_javascript)  

## Chapter 1: The JavaScript Programming Environment and Model  
__The JavaScript Environment__  
Download SpiderMonkey's [Nightly Build](https://archive.mozilla.org/pub/firefox/nightly/latest-mozilla-central/) JavaScript shell for your OS platform.  
Unzip the download (`jsshell-win64.zip`), move it to the c: drive (`C:\jsshell-win64`) and add the path to your environment variable.  
Use the `js` command to start an interactive shell
```
> js  
js >
```
To leave the interactive shell, type the command `quit()`.  

You can also use the SpiderMonkey's `js` command to interpret a script in a JavaScript `.js` file.  
```
> js recursion.js
```  
Most of the examples will be run using this method.  

### C# REPL
C# REPL can be used in many ways  
1. You can use C# interactive shell in Visual studio:
  * Launch visual studio
  * Click on View > Other Windows > C# Interactive  
  * Type a line of C# code in the interactive window and hit enter
  ```
  > Console.WriteLine("Hello People");
  ```
2. You can use `csi.exe` in a terminal window outside of Visual studio
  * Navigate to `C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\Roslyn`
  * Type `csi` and hit enter to launch an interactive session.
  * Type a line of C# code and hit enter
  ```
  > Console.WriteLine("Hello People");
  ```
3. You can use `csi.exe` to interpret C# script file
  * Write you C# code and save it as `.csx` file
  ```
  Console.WriteLIne("Hello Work")
  ```
  * Run the script using `csi.exe` like this
  ```
  > "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\Roslyn\csi" myscript.csx
  ```
  * You can also add the `csi.exe` to your path to make the `csi` command available every where so that you can simple do.  
  ```
  >  csi myscript.csx
  ```

### CSharp Examples  
Although the book is for JavaScript, a corresponding examples will be also be written with C#.   
The CSharp examples will be written as script interpreted using the `csi.exe` as describe on method 3. above.   
For example our first script will contain the code
```
int factorial(int number) {
  if (number == 1) {
    return number;
  }
  return number * factorial(number -1);
}

Console.WriteLine(factorial(5));
```  
in a file named `recursion.csx` and will be executed by using the command
```
> csi recursion.csx
```  

## Chapter 2: Arrays
The array is the most common data structure in most if not all programming languages.   

## Chapter 3: Lists  
Lists are especially useful if we don't have to perform searches on the items in the list or put them into some type of sorted order.  
When we need to perform long searches or complex sorts, lists become less useful, especially with more complex data structures.  

__Iterating Through a List__   
An iterator allows us to transverse a list without referencing the internal storage mechanism of the List class.    
Iterators are used only to move through a list and should not be combined with any function for adding or removing items from a list.

__Exercises__
Todo: Return to exercise

## Chapter 4: Stack
A list-like structure that can be used to solve any problems in computing is the stack. Stack are efficient data structures because data can be added or removed only from the top of a stack, making these procedures fast and easy to implement.

__Stack Operations__  
A stack is a list of elements that are accessible only from one end of the list  which is called the top. The stack is known as a _last-in, first-out_ (LIFO) data structure.
The primary operations of a stack are
* push
* pop
* peek  

Other operations includes
* clear

The stack may also have a _length_ property.   

__Exercises__  
Todo: Return to exercises  


## Chapter 5: Queues  
A _queue_ is a type of list where data are inserted at the end and are removed from the front. A queue is an example of _first-in, first-out_ (FIFO) data structure.

__Queue Operations__  
The primary operation involving queues are
* enqueue
* dequeue
* peek

Other operations includes
* clear  

The queue may also have a _length_ property.

To continue.

## Chapter 12: Sorting Algorithm  
### Basic Sorting Algorithms
__Bubble Sort__  
The bubble sort is one of the slowest sorting algorithm, but it is also one of the easiest sorts to implement.   
Assuming you are sorting a set of numbers into ascending order, larger values float to the right of the array and lower values float to the left.  

__Selection Sort__    
This sort works by starting at the beginning of the array and comparing the first element with the remaining elements. After examining all the elements, the smallest element is placed in the first position of the array, and the algorithm moves to the second position.

__Insertion Sort__  
The insertion sort is analogous to the way humans sort data numerically or alphabetically.   
In the case of an array of numbers, the insertion sort works by moving larger array elements to the right to make room for the smaller elements on the left side of the array.  
