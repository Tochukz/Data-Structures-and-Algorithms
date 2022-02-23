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

class Dancer {
  name = '';

  sex = '';

  constructor(name, sex) {
    this.name = name;
    this.sex = sex;
  }
}


function getDancers() {
  const dancers = JSON.parse(read('dancers.json')); 
  const maleDancers = new Queue();
  const femaleDancers = new Queue(); 
  for (let person of dancers) {
    const dancer = new Dancer(person.name, person.sex)
    if (dancer.sex == "M") {
      maleDancers.enqueue(dancer);
    } else {
        femaleDancers.enqueue(dancer);
    }
  }
  return [maleDancers, femaleDancers];
}

function dance(maleDancers, femaleDancers) {
  print("The dancers are: \n");
  while(!maleDancers.isEmpty() && !femaleDancers.isEmpty()) {
    const male = maleDancers.dequeue();
    const female = femaleDancers.dequeue();
    putstr(female.name + "(F) and ");
    print(male.name + "(M) \n");
  }
}

const [maleDancers, femaleDancers] = getDancers();
dance(maleDancers, femaleDancers);
if (!maleDancers.isEmpty()) {
  const frontMale = maleDancers.front();
  print(frontMale.name + " is waiting for his partner");
  print("There are", maleDancers.count(), "male dancers waiting");
}
if (!femaleDancers.isEmpty()) {
  const frontFemale = femaleDancers.front();
  print(frontFemale.name + " is waiting for her dance partner");
  print("There are", femaleDancers.count(), "female dancers waiting");
}