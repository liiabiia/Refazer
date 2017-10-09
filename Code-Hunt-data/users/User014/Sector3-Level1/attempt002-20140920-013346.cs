using System;
using System.Linq;
public class Program {
  public static int[] Puzzle(int[] a, int t) {
    return a.Select(x=>(x==-1||x==1?0:x)).ToArray();
  }
}