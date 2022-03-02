const CArray = require('./CArray');

CArray.prototype.insertionSort = function() {
  console.log('***** Sorting *****');
  let temp, y;
  const len = this.dataStore.length;
  for (let x = 1; x <= len - 1; x++) {
    temp = this.dataStore[x];
    y = x;
    while (y > 0 && this.dataStore[y - 1] >= temp) {
      this.dataStore[y] = this.dataStore[y - 1];
      y--;
    }
    this.dataStore[y] = temp;
    console.log(this.toString());
  }
  console.log("***** Sorted *****");
}

const numElements = 10;
const cArray = new CArray(numElements);
cArray.setData();
console.log('Before Sort: \n', cArray.toString());
cArray.insertionSort();
console.log('After Sort: \n', cArray.toString());