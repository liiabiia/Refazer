using System;
using System.Linq;
public class Program {
  public static int Puzzle(int n) {
	  
    return n==0?0:Enumerable.Range(1,n-1).Sum();
  }
}