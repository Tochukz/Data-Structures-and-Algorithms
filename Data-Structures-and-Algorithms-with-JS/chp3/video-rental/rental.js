class List {
  listSize = 0;

  pos = 0;

  dataStore = [];

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

class Customer {
  constructor(name, movie) {
    this.name = name;
    this.movie = movie;
  }
}

function displayList(list) {
  for(list.front(); list.currPos() < list.length(); list.next()) {
    if (list.getElement() instanceof Customer) {
      const customer = list.getElement();
      print(`${customer.name}, ${customer.movie}`);
    } else {
      print(list.getElement());
    }
  }
}

function checkout(name, movie, customers, movies) {
  if (movies.contains(movie)) {
    const customer = new Customer(name, movie);
    customers.append(customer);
    movies.remove(movie);
  } else {
    print(`The movie ${movie} is not available`);
  }
}

const movieList = new List();
const customerList = new List();
const moviesObject = JSON.parse(read('films.json'));
const movies = Object.values(moviesObject);
movies.forEach(movie => movieList.append(movie));

print("Movies available: \n");
displayList(movieList);
checkout("Jane Doe", "12 Angry Men", customerList, movieList);
print("\nMovie rental: \n");
displayList(customerList);