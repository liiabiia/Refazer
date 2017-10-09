using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
         
           return (int)a.Select((x,i) => i > (a.Length-1)/2?x+1:x).Average();

  }
}