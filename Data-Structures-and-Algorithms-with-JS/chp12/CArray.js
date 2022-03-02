class CArray {
  dataStore = [];
  
  pos = 0;
  
  numElements = 0;

  constructor(numElements) {
    for(let i = 0; i < numElements; i++) {
      this.dataStore[i] = i;
    }
    this.numElements = numElements;
  }

  insert(element) {
    this.dataStore[this.pos++] = element;
  }

  clear() {
    for(let i = 0; i <  this.dataStore.length; i++) {
      this.dataStore[i] = 0;
    }
  }

  setData() {
    for(let i = 0; i < this.numElements; i++) {
      this.dataStore[i] = Math.floor(Math.random() * (this.numElements + 1));
    }
  }

  swap(arr, index1, index2) {
    let temp = arr[index1];
    arr[index1] = arr[index2];
    arr[index2] = temp;
  }

  toString() {
    let retStr = "";
    for(let i = 0; i < this.dataStore.length; i++) {
      retStr += this.dataStore[i] + " ";
      if (i > 0 && i % 10 == 0) {
        retStr += "\n"
      }
    }
    return retStr;
  }
}

module.exports = CArray;
