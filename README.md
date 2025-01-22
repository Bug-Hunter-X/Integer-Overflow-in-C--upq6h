# Integer Overflow in C#

This repository demonstrates a subtle integer overflow bug in C# and provides a solution.

## The Bug
The `ExampleClass` attempts to store `int.MaxValue` in its `MyProperty`. This does not produce an immediate error but it causes an unexpected value to be stored due to integer overflow. The resulting value is not what is expected. 

## The Solution
The solution involves input validation to prevent values that might cause overflow.  Using a larger integer type if necessary would also resolve the issue, but careful consideration for the performance cost is warranted. 