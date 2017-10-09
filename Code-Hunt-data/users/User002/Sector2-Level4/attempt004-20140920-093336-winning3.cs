using System;
using System.Linq;
public class Program {
  public static int Puzzle(int a, int b) {
	  return Enumerable.Range(1,b).Where(i=>(i*a)%b==0).Min()*a;
  }
}