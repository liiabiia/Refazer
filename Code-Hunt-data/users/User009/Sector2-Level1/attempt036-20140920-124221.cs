using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
                     var r1 = a.Average();
            var r = Math.Floor(Math.Abs(r1))* Math.Sign(r1);
            return (int)r;

  }
}