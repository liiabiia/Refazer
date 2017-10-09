using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
         
            var r= a.Select((x,i) => i > 0&&i==a.Length-1?x+1:x).Average();
            return (int)r;

  }
}