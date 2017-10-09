using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return a.Select((a,i)=>a*(i+1)).Sum();
  }
}