const names = ['David', 'Mike', 'Cynthia', 'Raymond', 'Clayton',  'Mike', 'Jenifer'];
putstr("Enter a name to search: ");
var input = readline();
var position = names.indexOf(input);
var lastPosition = names.lastIndexOf(input);
if(position >= 0) {
  print('Found '+ input +  ' at first position ' + position);
} else {
  print(input + ' not found in array.');
}
if (lastPosition != position && lastPosition >= 0) {
  print('Found another '+ input + ' at last position ' + lastPosition);
}