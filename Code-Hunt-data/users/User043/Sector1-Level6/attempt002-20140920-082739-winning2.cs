using System;

public class Program {
  public static int Puzzle(string s) {
	  string[] a = s.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
       return a.Length;
  }
}