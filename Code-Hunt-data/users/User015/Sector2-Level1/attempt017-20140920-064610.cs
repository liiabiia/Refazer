using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return (int)(Math.Ceiling( ((double)a.Sum() ) / (double)a.Length));;
  }
}