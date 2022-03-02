const CArray = require('./CArray');

CArray.prototype.buddleSort = function () {
  console.log('***** Sorting *****');
  const dataLen = this.dataStore.length;
  for (let x = dataLen; x >= 2; x--) {
    for(let y = 0; y <= x - 1; y++) {
      if (this.dataStore[y] > this.dataStore[y+1]) {
        this.swap(this.dataStore, y, y+1);
      }
    }
    console.log(this.toString());
  }
  console.log('***** Sorted ******')
}

const numElements = 10;
const cArray = new CArray(numElements);
cArray.setData();
console.log('Before Sort: \n', cArray.toString());
cArray.buddleSort();
console.log('After Sort: \n', cArray.toString());