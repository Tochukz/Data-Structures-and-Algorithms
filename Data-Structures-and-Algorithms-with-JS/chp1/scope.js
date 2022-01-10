function showScope() {
    return scope;
}

var scope = "global";
print(scope);       // global
print(showScope()); // global

for(var i =0; i < 5; i++) {
    print(i);
}
print(i); // 5

for(let x =0; x < 5; x++) {
    print(x);
}
// print(x); // ReferenceError: x is not defined


/**
JavaScript has function scope. JavaScript does not have block scope.

 1) When var keyword is used, the variable i is not block scoped
 2) Throws error because variable x is block scope because of the use of the let keyword

  Output:
    global
    global
*/
