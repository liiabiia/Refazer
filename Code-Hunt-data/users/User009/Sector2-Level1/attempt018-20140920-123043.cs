using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
        return (int) Math.Ceil(a.Average(x => x));
         
  }
}