using System;

public class Program {
  public static int Puzzle(string s) {
    return s.Split(new Char [] {' ', '\t' }, StringSplitOptions.RemoveEmptyEntries));
  }
}