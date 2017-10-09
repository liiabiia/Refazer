using System;

public class Program {
  public static int Puzzle(string s) {
    s=s.Replace(" ","");
    //s=s.Replace(".","");
double x=(double) s.Length;
x=x/4;
return (int) Math.Floor(x);

  }
}