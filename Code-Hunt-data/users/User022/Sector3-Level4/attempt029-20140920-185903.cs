using System;

public class Program {
  public static bool Puzzle(char c) {
    string tmp = " bcegimnpu";
	return tmp.Contains(c.ToString());
  }
}