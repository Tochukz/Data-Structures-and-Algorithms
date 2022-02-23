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

function convertTo(number, base) {
  if (base < 2 || base > 9) {
    print('Error: This algorithm will only work when base in between 2-9 inclusive');
    return;
  }
  let n = number;
  const stack = new Stack();
  do {    
    stack.push(n % base);
    n = Math.floor(n / base);
  } while(n > 0);
  
  let conveted = "";
  while(stack.length() > 0) {
    conveted += stack.pop();
  }

  return conveted;
}

let number = 32;
const binaryNumber = convertTo(number, 2);
print(number + " = " + binaryNumber); // 32 = 100000

number = 125;
const octalNumber = convertTo(number, 8);
print(number + " = " + octalNumber); // 125 = 175