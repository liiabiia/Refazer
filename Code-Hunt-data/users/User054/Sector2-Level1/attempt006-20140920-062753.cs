using System;

public class Program {
  public static int Puzzle(int[] a) {
    return (a[0]+a[2])/(-1*a[1])+1;
  }
}