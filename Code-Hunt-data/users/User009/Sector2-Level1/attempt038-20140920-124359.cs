using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
         
            var r= a.Select(x => x<0?x+1:x).Average();
            return (int)r;

  }
}