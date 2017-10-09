using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a, int k) {
    
		if (a.Length%2!=0)
			return a.Min();
			return a.Max();

  }

}