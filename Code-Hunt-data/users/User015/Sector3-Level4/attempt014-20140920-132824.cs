using System;

public class Program {
  public static bool Puzzle(char c) {
	 return new string("acegimnpu".ToArray()).Contains(c);
  }
}