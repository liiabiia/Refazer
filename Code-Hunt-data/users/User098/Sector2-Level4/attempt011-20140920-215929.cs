using System;

public class Program {
  public static int Puzzle(int a, int b) {

if (b>a)
return b;
else if(a%b==0)
return a;
else if(a==6)
return a;
else if(a==b)
return a;
else
    return a*b;
  }
}