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

const stack = new Stack();
stack.push("David");
stack.push("Raymond");
stack.push("Bryan");
print("length: ", + stack.length()); // length:  3
print(stack.peek()); // Bryan

const lastname = stack.pop();
print("Lastname is ", lastname); // Lastname is  Bryan
print(stack.peek()); // Raymond

stack.push("Cynthia");
print(stack.peek()); // Cynthia
stack.clear();
print("New length: ", stack.length()); // New length:  0
print(stack.peek()); // undefined

stack.push("Clayton");
print(stack.peek()); // Clayton