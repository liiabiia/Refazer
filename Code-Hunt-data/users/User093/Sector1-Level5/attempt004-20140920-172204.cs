using System;

public class Program {
    public static int Puzzle(int[] a) {
      int sum = 0;
      Array.ForEach(arr, delegate(int i) { sum += i; });
      return sum;
    }
}