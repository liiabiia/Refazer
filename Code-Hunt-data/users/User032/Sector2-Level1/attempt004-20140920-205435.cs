using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    //return (a.Sum()/a.Count());
	return (a.Sum()+1/a.Count())
  }
}