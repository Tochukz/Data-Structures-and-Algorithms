class List {
  listSize = 0;

  pos = 0;

  dataStore = [];

  constructor() {
    
  }

  clear() {
    this.dataStore.length = 0
    this.listSize = 0;
    this.pos = 0;
  }

  findIndex(element) {
    return this.dataStore.findIndex(elem => elem == element);
  }

  toString() {
    return this.dataStore;
  }

  insert(element, after) {
    const index = this.findIndex(after);
    if (index < 0) {
        return false;
    }
    this.dataStore.splice(index+1, 0, element);
    this.listSize++;
    return true;
  }

  append(element) {
    this.dataStore[this.listSize++] = element;
  }

  remove(element) {
    const index = this.findIndex(element); 
    if (index < 0) {
      return false;
    }
    this.dataStore.splice(index, 1);
    this.listSize--;
    return true;
  }

  front() {
    this.pos = 0;
  }

  end() {
    this.listSize = this.dataStore.length;
    this.pos = this.listSize-1;
  }

  prev() {
    if (this.pos >= 0) {
      --this.pos;
    }
  }

  next() {
    if (this.pos < this.listSize) {
      ++this.pos;
    }
  }

  length() {
    this.listSize = this.dataStore.length;
    return this.listSize;
  }

  currPos() {
    return this.pos;
  }

  moveTo(position) {
    this.pos = position;
  }

  getElement() {
    return this.dataStore[this.pos];
  }

  contains(element) {
    const exits =  this.dataStore.find(elem => elem == element);
    return exits != undefined;
  }
}

const names = new List();
names.append("Cynthia");
names.append("Raymond");
names.append("Barbara");
print(names.toString()); // Cynthia,Raymond,Barbara
names.remove("Raymond");
print(names.toString()); // Cynthia,Barbara

const otherNames = new List();
otherNames.append("Clayton");
otherNames.append("Raymond");
otherNames.append("Cynthia");
otherNames.append("Jennifer");
otherNames.append("Bryan");
otherNames.append("Danny");
otherNames.front();
print(otherNames.getElement()); // Clayton
otherNames.next();
print(otherNames.getElement()); // Raymond
otherNames.next();
otherNames.next();
otherNames.prev();
print(otherNames.getElement()); // Cynthia

/** Transaversing the list */
for (names.front(); names.currPos() < names.length(); names.next()) {
  print(names.getElement());
}

/** Transversing the list backward */
for (names.end(); names.currPos() >= 0; names.prev()) {
  print(names.getElement());
}
/**
 * Iterators are used only to move through a list and should not be combined with any function for adding or
 *  removing items from a list.
 */