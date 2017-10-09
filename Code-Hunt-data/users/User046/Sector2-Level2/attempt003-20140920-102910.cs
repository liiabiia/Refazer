using System;

public class Program {
  public static int Puzzle(string s) {
     int length = 0;
    if (s.Split('(').Length == s.Split(')').Length) length = s.Split(')').Length;
    return length;
  }
}