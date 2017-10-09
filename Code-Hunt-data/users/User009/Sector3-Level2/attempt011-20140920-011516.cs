using System;
using System.Linq;
public class Program {
  public static int Puzzle(int n) {
       return Fib(n);
}

public static int Fib(int n)
{
    if (n < 2) return 1;
    return Fib(n - 2) + Fib(n - 1);
  }
}