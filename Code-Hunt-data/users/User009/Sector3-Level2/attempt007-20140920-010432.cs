using System;
using System.Linq;
public class Program {
  public static int Puzzle(int n) {
	  
    return n==0?0:Enumerable.Range(2,n-1).Sum()+1;
  }
}