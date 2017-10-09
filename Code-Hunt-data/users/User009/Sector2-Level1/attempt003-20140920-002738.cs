using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return a.Select((x,i)=>x*(i+1)).Sum();
  }
}