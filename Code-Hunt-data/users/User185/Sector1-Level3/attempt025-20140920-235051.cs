using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if (!(x && y)) return false;
	else return true;
  }
}