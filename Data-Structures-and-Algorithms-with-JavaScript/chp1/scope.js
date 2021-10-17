function showScope() {
    return scope;
}

var scope = "global";
print(scope);
print(showScope());

for(var i =0; i < 5; i++) {
    print(i);
}
print(i); // (1)

for(let x =0; x < 5; x++) {
    print(x);
}
// print(x); // (2)


/**
 1) When var keyword is used, the variable i is not block scoped
 2) Throws error because variable x is block scope because of the use of the let keyword

  Output: 
    global
    global
*/