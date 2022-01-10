const names = ['John', 'Jane', 'Clark', 'Kent'];

/** Printing names fron left to right */
for(let i = 0; i < names.length; i++) {
  print(names[i]);
}

print('********');

/**Printing bame from right to left */
for (let j = names.length - 1; j >= 0; j--) {
  print(names[j]);
}