using System;

public class Program {
  public static int Puzzle(int a, int b) {
    return (a>b && a < 10 || a==b || a%b==0 ?  a : a*b);
    //return (a%b==0 ?  a : a*b);
    //return (b%3==0 ?  a*3 : a*b);
      //return ((a+b)%2==0 || a%b==0 ? a : ((b>a)? b : a*b));
//return a*b;
  }
}