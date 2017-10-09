using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
         
            var r= a.Select((x,i) => i > (a.Length-1)/2?x+1:x).Average();
            return (int)r;

  }
}