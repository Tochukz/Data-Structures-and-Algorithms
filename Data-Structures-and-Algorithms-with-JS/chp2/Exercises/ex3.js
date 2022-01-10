function WeeklyTemp() {
  this.temperatures = [
    [],
    [],
    [],
    [],
  ];

  this.add = add;
  this.average = average;
}

function add(week, temp) {
  if(week > 4) {
    throw new Error('There are only 4 weeks in a month');
  }
  if (Array.isArray(temp)) {
    this.temperatures[week-1] = this.temperatures[week-1].concat(temp);
  } else {
    this.temperatures[week-1].push(temp);
  }
}

function average(week) {
  if (week) {
    const weekTemps = this.temperatures[week-1];
    const totalWeekTemps = weekTemps.reduce((prev, next) => prev + next);
    const weekAvg = (totalWeekTemps / weekTemps.length).toFixed(2);
    return weekAvg;
  }

  let totalTemps = 0; 
  this.temperatures.forEach(temps => {
    totalTemps += temps.reduce((prev, next) =>  prev + next);
  });
  const totalEntrires = this.temperatures.reduce((prev, next) => prev + next.length, 0);
  const monthAvg = (totalTemps / totalEntrires).toFixed(2);
  return monthAvg;
}

const weeklyTemp = new WeeklyTemp();
weeklyTemp.add(1, [37, 34, 36]);
weeklyTemp.add(2, 33);
weeklyTemp.add(3, [34, 39, 31, 32]);
weeklyTemp.add(4, [31, 33]);

print(`First Week Avg = ${weeklyTemp.average(1)}`);
print(`Second Week Avg = ${weeklyTemp.average(2)}`);
print(`Third Week Avg = ${weeklyTemp.average(3)}`);
print(`Fouth Week Avg = ${weeklyTemp.average(4)}`);
print(`Monthly Avg = ${weeklyTemp.average()}`);