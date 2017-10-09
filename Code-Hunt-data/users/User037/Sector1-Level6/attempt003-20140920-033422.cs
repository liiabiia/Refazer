using System;

public class Program {
  public static int Puzzle(string s) {
    return (s.Length%4 == 0) ? s.Length/4 : 0;
  }
}