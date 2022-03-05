# Discard Operator _

You can ignore a return value with discard operator.

Assume there is a method that returns multiple values:
```c#
public static (int sum, double mean) Add(params int[] numbers)
{
...
```

If you need only sum, you can ignore mean:
```c#
var (total, _) = Add(4, 5, 6);
...
```