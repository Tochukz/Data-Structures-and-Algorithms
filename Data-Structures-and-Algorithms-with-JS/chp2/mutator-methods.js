let names = ['David', 'Mike', 'Clayton', 'Bryan', 'Raymond'];
names.sort(); // ["Bryan", "Clayton", "David", "Mike", "Raymond"]

let nums = [ 3, 1, 2, 100, 4, 200]; 
nums.sort()

print(nums); // 1,100,2,200,3,4

nums.sort((n1, n2) => n1 - n2);
print(nums); // 1,2,3,4,100,200

/**
 The sort() method works with array of strings

 The sort() methos does not work well with numbers. 
 This is because the sort() function sorts data lexicographically. 
 */