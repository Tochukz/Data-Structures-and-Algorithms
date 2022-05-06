/**
 Problem: 
   Design an algorithm and write code to remove the duplicate characters in a string without using any additional buffer. 
     NOTE: One or two additional variables are fine. An extra copy of the array is not.
   FOLLOW UP
   Write the test cases for this method.
*/

function removeDuplicates(chars) {
  if (!Array.isArray(chars)) {
    throw new Error('input parameter should be array of characters');
  }
  let index = 0;
  for (let i = 0; i < chars.length; i++) {
    let j;
    for(j = 0; j < i; j++) {
      if (chars[i] == chars[j]) {
        break;
      }
    }
    if (i == j) {
      chars[index] = chars[i];
      index++;
    }
  }
  chars.length = index;
}
const hippo = "hippopotamous";
const geeks = "geeksforgeeks"; 

const hippoCharArry = hippo.split('');
const geeksCharArry = geeks.split('');

removeDuplicates(hippoCharArry);
removeDuplicates(geeksCharArry);

console.log(hippoCharArry.join(''));
console.log(geeksCharArry.join(''));

/**
Output: 
 hipotamus
 geksfor
*/