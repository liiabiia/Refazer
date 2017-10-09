using System;
using System.Collections;
public class Program {
  public static int Puzzle(int[] a) {
   Array.Sort(a);
   n=a.Length;
    return a[n-1]-a[0];
  }
}