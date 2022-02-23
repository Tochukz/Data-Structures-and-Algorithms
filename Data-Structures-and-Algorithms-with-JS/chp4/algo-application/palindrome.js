class Stack {
  dataStore = [];
  
  top = 0;
  
  push(element) {
    this.dataStore[this.top++] = element;
  }

  pop() {
    return this.dataStore[--this.top];
  }
  
  peek() {
    return this.dataStore[this.top-1];
  }
  
  length() {
    return this.top;
  }
  
  clear() {
    this.top = 0;
  }
}

function isPalindrome(word) {
  const stack = new Stack();
  for(let i = 0 ; i < word.length; i++) {
      stack.push(word[i]);
  }

  let reverseWord = "";
  while(stack.length() > 0) {
    reverseWord += stack.pop();
  }
  return word === reverseWord;
}

const greet = "hello";
if (isPalindrome(greet)) {
  print(greet, " is a palindrome");
} else {
  print(greet, " is NOT a palindrome");
}

const car = "racecar";
if (isPalindrome(car)) {
  print(car, " is a palindrome");
} else {
  print(car, " is NOT a palindrome");
}

// hello  is NOT a palindrome
// racecar  is a palindrome

/** 
A palindrome is a word, phrase, or number that is spelled the same forward and backward.
For example, “dad” is a palindrome; “racecar” is a palindrome
*/