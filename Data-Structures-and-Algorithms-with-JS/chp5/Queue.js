class Queue {
  dataStore = [];

  enqueue(element) {
    this.dataStore.push(element);
  }

  dequeue() {
    return this.dataStore.shift();
  }

  front() {
    return this.dataStore[0];
  }

  back() {
    return this.dataStore[this.dataStore.length-1];
  }

  toString() {
    let str = "";
    for (let elem of this.dataStore) {
      str += (elem + "\n");
    }
    return str;
  }

  isEmpty() {
    return this.dataStore.length == 0;
  }

  count() {
    return this.dataStore.length;
  }
}

const que = new Queue();
que.enqueue("Meredith");
que.enqueue("Cynthia");
que.enqueue("Jennifer");
print(que.toString());

que.dequeue();
print(que.toString());

print("Front of queue: ", que.front());
print("Back of queue: ", que.back());

/** Output

Meredith
Cynthia
Jennifer

Cynthia
Jennifer

Front of queue:  Cynthia
Back of queue:  Jennifer
 
*/