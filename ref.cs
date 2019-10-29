// Passing a reference parameter and not the actual parameter

void Method(ref int refArgument)
{
    refArgument = refArgument + 44;
}

int number = 1;
Method(ref number);
Console.WriteLine(number);
// Output: 45

// Alternatively

int Method(int x) {
  return x + 44;
}

int number = 1;
int number = Method(number)
