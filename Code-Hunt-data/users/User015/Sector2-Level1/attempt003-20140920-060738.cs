using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return (int)((float)a.Sum()/a.Length + (float)0.5);
  }
}