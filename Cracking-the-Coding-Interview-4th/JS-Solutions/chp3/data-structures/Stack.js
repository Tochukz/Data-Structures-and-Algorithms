class Stack {
  storage = [];

  push(data) {
    this.storage.unshift(data);
  }

  pop(data) {
    return this.storage.shift();
  }

  print() {
    let str = '';
    this.storage.forEach(x => str+= `${x} `);
    console.log(str);
  }
}

const stack = new Stack();
stack.push(1);
stack.push(2);
stack.push(3);
stack.push(4);
stack.push(5);
stack.print();

const x = stack.pop();
const y= stack.pop();
const z = stack.pop();

console.log(`${x} ${y} ${z}`);

stack.print();

/**
Output:  
  5 4 3 2 1 
  5 4 3
  2 1
*/