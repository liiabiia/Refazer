using System;

public class Program {
  public static int Puzzle(int a, int b) {

if(a%b==0)
return a;
else if(b>a)
return b;
else if(a==b)
return a;
else if (b==6)
return b;
else
    return a*b;
  }
}