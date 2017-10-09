using System;

public class Program {
  public static bool Puzzle(char c) {
    string tmp = " acegimnpu";
	return tmp.Contains(c.ToString());
  }
}