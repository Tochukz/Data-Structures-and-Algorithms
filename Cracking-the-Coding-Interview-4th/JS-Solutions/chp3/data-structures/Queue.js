class Queue {
  storage = [];

  enqueue(data) {
    this.storage.push(data);
  }

  dequeue() {
    return this.storage.shift();
  }

  print() {
    let str = '';
    this.storage.forEach(x => str += `${x} `);
    console.log(str);
  }
}

const queue = new Queue();
queue.enqueue(1);
queue.enqueue(2);
queue.enqueue(3);
queue.enqueue(4);
queue.enqueue(5);
queue.print();

const x = queue.dequeue();
const y = queue.dequeue();
const z = queue.dequeue();

console.log(`${x} ${y} ${z}`);

queue.print();

/**
Output: 
  1 2 3 4 5 
  1 2 3
  4 5
*/