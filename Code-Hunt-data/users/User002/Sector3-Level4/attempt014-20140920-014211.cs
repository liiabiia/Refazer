using System;

public class Program {
  public static bool Puzzle(char c) {
    //return !("bdfhjklqrvxz".Contains(""+c));
	return "gap ".Contains(""+c);
  }
}