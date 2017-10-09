using System;

public class Program {
  public static int Puzzle(string s) {
    return s.IndexOf(" ")>=0?s.IndexOf(" "):1;
  }
}