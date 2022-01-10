function Word() {
  this.letters = [];
  this.write = write;
  this.read = read;
}

function write(letter) {
  this.letters.push(letter);
}

function read() {
  return this.letters.join('');
}

const word = new Word();
word.write('H');
word.write('e');
word.write('n');
print(word.read()); // Hen