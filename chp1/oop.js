
/** Define the object constructor */
function Account(amount) {
  this.balance = amount;
  this.deposit = deposit;
  this.withdraw = withdraw;
  this.toString = toString;
}

/** Define the object methods */
function deposit(amount) {
  this.balance += amount;
}

function withdraw(amount) {
  if (amount <= this.balance) {
    this.balance -= amount;
  } else {
    print("Insufficeint funds");
  }
}

function toString() {
  return "Balance: " + Intl.NumberFormat('en-US', {style: 'currency', currency: 'USD'}).format(this.balance);
}

/** Create an instance */
var account = new Account(1000);
account.deposit(1000);
print(account.toString()); // Balance: $2,000.00

account.withdraw(500)
print(account.toString()); // Balance: $1,500.00

account.withdraw(2000);    // Insufficeint funds
print(account.toString()); // Balance: $1,500.00