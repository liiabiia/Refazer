using System;

public class Program {
  public static int Puzzle(int a, int b) {
if(b==2)
b=1;
if(a==b)
return a;
else
    return a*b;
  }
}