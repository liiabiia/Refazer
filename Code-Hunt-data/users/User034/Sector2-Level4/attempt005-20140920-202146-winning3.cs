using System;

public class Program {
  public static int Puzzle(int a, int b)
    {
        return (a / gcf(a, b)) * b;
    }
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
}