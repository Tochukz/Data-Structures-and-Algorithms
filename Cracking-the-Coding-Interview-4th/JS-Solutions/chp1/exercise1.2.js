/**
  Problem: 
    Write code to reverse a C-Style String. (C-String means that “abcd” is represented as five characters, including the null character.)
*/

function reverse(str) {
  let revStr = '';
  for(let i = str.length - 1; i >=0 ; i--) {
     revStr += str[i];
  }
  return revStr;
}

const str = "naelC nivlaK";
const revStr = reverse(str);
console.log(revStr);

/*
Output: 
  Kalvin Clean
*/