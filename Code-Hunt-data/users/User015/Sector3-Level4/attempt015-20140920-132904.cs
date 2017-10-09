using System;
using System.Linq;
public class Program {
  public static bool Puzzle(char c) {
	 return new string("acegimnpu".ToArray()).Contains(c);
  }
}