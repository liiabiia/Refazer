using System;

public class Program {
  public static int Puzzle(string s) {

while(s.Contains("  "))
{
s=s.Replace("  "," ");
}
    return s.Split(' ').Length;
  }
}