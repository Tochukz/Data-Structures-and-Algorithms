int factorial(int number) {
  if (number == 1) {
    return number;
  }
  return number * factorial(number -1);
}

Console.WriteLine(factorial(5));
