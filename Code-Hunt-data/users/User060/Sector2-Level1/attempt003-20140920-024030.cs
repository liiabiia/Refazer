using System;

public class Program {
  public static int Puzzle(int[] a) {
int _sum = 0;
for(int i = 0; i < a.Length; i++)
_sum += a[i] * i;
    return _sum;
  }
}