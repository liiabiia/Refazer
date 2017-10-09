using System;

public class Program {
  public static int Puzzle(string s) {
     int length = 0;
     if (s.Split('(').Length == s.Split(')').Length && s.IndexOf('(') < s.IndexOf(')')){length = s.Split(')').Length - 1;}

            return length;


  }
}