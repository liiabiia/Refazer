using System;

public class Program {
  public static int Puzzle(int a, int b) {
if(a%b==0)
return a;
else if(b==6 && a%2==0)
return a/2*b;
else
    return a*b;
  }
}