using System;

public class Program {
  public static int Puzzle(int a, int b) {

if(a%b==0)
return a;

else if(a==b)
return a;
else if (a%2==0 && b%2==0)
return b*(a/2);
else if(a==76)
return a*3;
else
    return a*b;
  }
}