using System;

public class Program {
    public static int Puzzle(int[] a) {
int _sum = 0;
foreach (var i in a)
_sum += i;
      return _sum;
    }
}