const grades =  [
                 [89, 77, 78], 
                 [76, 82, 81], 
                 [91, 94, 89]
                ];

/** Calculating the avergage for each student. This can be called a columnar processing */
for (let row = 0; row < grades.length; row++) {
  let total = 0;
  for (let col = 0; col < grades[row].length; col++) {
    total += grades[row][col];
  }
  const average = (total / grades[row].length).toFixed(2);
  print(`Student ${row+1} Average = ${average}`);
}
/** Output 
Student 1 Average = 81.33
Student 2 Average = 79.67
Student 3 Average = 91.33
*/

/** Calculating the average for each subject. This can be called a row-wise computation */
for (let row = 0; row < grades.length; row++) {
  let total = 0;
  for(let col = 0; col < grades[row].length; col++) {
    total += grades[col][row]
  }
  const average = (total / grades[row].length).toFixed(2);
  print(`Subject ${row + 1} Average = ${average}`);
}
//Note: that this solution only works because the rows and cols and equal length


/**
 * Each row in the 2 dimensional array represents the score of the specific student  
 * The scores are for subjects:  Maths, English and Science respectively
 */