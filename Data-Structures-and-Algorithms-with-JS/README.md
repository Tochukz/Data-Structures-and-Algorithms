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
