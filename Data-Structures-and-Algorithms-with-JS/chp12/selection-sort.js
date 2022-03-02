const CArray = require('./CArray');

CArray.prototype.selectionSort = function() {
  console.log('***** Sorting *****')
  const len = this.dataStore.length;
  for(let x = 0; x < len - 1; x++) {
    min  = x;
    for(let y = x + 1; y <= len - 1; y++) {
      if (this.dataStore[y] < this.dataStore[min]) {
        min = y;
      }
    }
    this.swap(this.dataStore, x, min);
    console.log(this.toString())
  }
  console.log('***** Sorted *****');
} 


const numElements = 10;
const cArray = new CArray(numElements);
cArray.setData();
console.log('Before Sort: \n', cArray.toString());
cArray.selectionSort();
console.log('After Sort: \n', cArray.toString());