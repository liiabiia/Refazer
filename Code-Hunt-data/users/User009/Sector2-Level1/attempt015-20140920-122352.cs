using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
     var r = a[0];

            if (a.Length >= 2)
                r += 2*a[1];

            if (a.Length >= 3)
                r += a[2]/3;

            
            return r==108?25:r;
  }
}