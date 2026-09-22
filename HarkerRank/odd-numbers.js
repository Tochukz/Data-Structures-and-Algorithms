'use strict';

/*
 * Complete the 'oddNumbers' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts following parameters:
 *  1. INTEGER l
 *  2. INTEGER r
 */

function oddNumbers(l, r) {
    const isEven = l % 2 == 0;
    let oddNumber = l;
    if (isEven) {
        oddNumber += 1;
    }
    const oddNumbers = [oddNumber];
    while(oddNumber < r) {
        oddNumber += 2;
        if (oddNumber <= r) {
          oddNumbers.push(oddNumber);
        }
    }
    return oddNumbers;

}
