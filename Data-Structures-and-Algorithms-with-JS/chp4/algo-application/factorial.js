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

function factorial(n) {
  const stack = new Stack();
  while(n > 1) {
    stack.push(n--);
  }

  let product = 1;
  while(stack.length() > 0) {
    product *= stack.pop();
  }
  return product;
}

print(factorial(5)); // 120