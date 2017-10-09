using System;

public class Program {
  public static int Puzzle(string s) {
    s=s.Replace(" ","");
    //s=s.Replace(".","");
int x=s.Length/4;
int y = s.Length%4;
double x1=(double) x;
double y1=(double) y;
y1=y1/4;
x1=x1+y1;
return Math.Ceiling(x1);
  }
}