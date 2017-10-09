using System;

public class Program {
  public static int Puzzle(int a, int b) {
    int num = 2;
    int prod = 1;
    while (true)
    {
        if (num > Math.Min(a, b)) break;

        if (a % num == 0 && b % num == 0)
        {
            prod *= num;
            a = a / 2;
            b = b / 2;
        }
        else
            num++;

    }
    return a * b * prod;
  }
}