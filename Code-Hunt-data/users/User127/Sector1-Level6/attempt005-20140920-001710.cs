using System;

public class Program {
  public static int Puzzle(string s) {
int count = s.Length - s.Replace(" ", "").Length;    
return ++count;
  }
}