using System;

public class Program {
    public static int Puzzle(int[] a) {
      int sum = 0;
      Array.ForEach(a, delegate(int i) { sum += i; });
      return sum;
    }
}