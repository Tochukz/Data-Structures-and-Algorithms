/**
  Problem:  
    Implement an algorithm to determine if a string has all unique characters.
*/

function allUnique(str) {
  const chars = [];
  for(let i = 0; i < str.length; i++) {
    if(chars.includes(str[i])) {
        return false;
    }
    chars.push(str[i]);
  }
  return true;
}

function allUnique2(str) {
  for(let i = 0; i < str.length; i++) {
     for (let j = i +1; j < str.length; j++) {
       if (str[i] == str[j]) {
          return false;
       }
     }
  }
  return true;
}

const result1 = allUnique("Hippopotamous"); 
const result2 = allUnique("Kalvin C");
console.log(result1); // false
console.log(result2); // true

const result3 = allUnique2("Hippopotamous"); 
const result4 = allUnique2("Kalvin C"); 
console.log(result3); // false
console.log(result4); // true

/**
 Function  | Time Complexity | Space Complexity 
allUnique  |     O(n)        |    O(n)
allUnique2 |     O(n^2)      |    O(1)

Output: 
  false
  true
  false
  true
*/