using System;

public class Program {
  public static int Puzzle(string s) {
            char[] space = new char[1] {Char.Parse(" ") };
            return s.Split(space, StringSplitOptions.RemoveEmptyEntries).GetUpperBound(0) + 1;
  }
}