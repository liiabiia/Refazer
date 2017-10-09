using System;

public class Program {
  public static int Puzzle(string s) {
    s=s.Replace(" ","");
    //s=s.Replace(".","");
double x=s.Length/4;
return Math.Ceiling(x);
  }
}