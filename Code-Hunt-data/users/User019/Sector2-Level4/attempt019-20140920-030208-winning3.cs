using System;
using System.Linq;

public class Program {
	static int gcf(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

static int lcm(int a, int b)
{
    return (a / gcf(a, b)) * b;
}
  public static int Puzzle(int a, int b) {
    return lcm(a,b);
  }
}