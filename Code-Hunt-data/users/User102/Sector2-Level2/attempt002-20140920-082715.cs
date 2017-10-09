using System;

public class Program {
  public static int Puzzle(string s) {
Regex r = new Regex("\(");
int Open = r.Matches(s).Count;
r = new Regex("\)");
int Close = r.Matches(s).Count;
if (Open != Close) 
{
    return 0;
}
else return Open;
  }
}