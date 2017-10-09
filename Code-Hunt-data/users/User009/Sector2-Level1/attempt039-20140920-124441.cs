using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
         
            var r= a.Select((,i)x => x<0&&i>0?x+1:x).Average();
            return (int)r;

  }
}