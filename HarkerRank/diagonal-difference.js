/*
 * Complete the 'diagonalDifference' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts 2D_INTEGER_ARRAY arr as parameter.
 */

function diagonalDifference(arr) {
    // Write your code here
    let ltrDiagonal = 0;
    let rtlDiagonal = 0;
    for(let i = 0; i < arr.length; i++) {
        ltrDiagonal += arr[i][i];
        rtlDiagonal += arr[i][arr.length - 1 - i];
    } 
    return Math.abs(ltrDiagonal - rtlDiagonal);
}