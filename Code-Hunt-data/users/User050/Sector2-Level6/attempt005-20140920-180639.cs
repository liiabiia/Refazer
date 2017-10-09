using System;

public class Program {
  public static string Puzzle(int n) {
	  if (n == 0) return "0";
    return n%2 == 0 ? Math.Pow(10, n -1).ToString() : (Math.Pow(10, n -1)-1).ToString();
  }
}