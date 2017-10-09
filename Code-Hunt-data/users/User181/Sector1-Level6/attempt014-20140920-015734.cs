using System;

public class Program {
  public static int Puzzle(string s) {
    s=s.Replace(" ","");
    //s=s.Replace(".","");
double x=(double) s.Length;
x=x/4;
if(x>2)
{
return ((int) Math.Ceiling(x)) + 1;
}
return (int) Math.Ceiling(x);
  }
}