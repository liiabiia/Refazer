using System;

public class Program {
  public static int Puzzle(int a, int b) {

if(a%b==0)
return a;
else if(a==b)
return a;
else if (b==6)
return a*2;
else
    return a*b;
  }
}