function Grade() {
  this.scores = [];
  this.add = add;
  this.average = average;
}

function add(score) {
  this.scores.push(score);
}

function average() {
  const totalScore = this.scores.reduce((prev, next) => prev + next, 0);
  return (totalScore / this.scores.length).toFixed(2);
}

const john = new Grade();
john.add(72);
john.add(65);
john.add(81);
const avg = john.average();
print(`John's Average Score = ${avg}`); // John's Average Score = 72.67