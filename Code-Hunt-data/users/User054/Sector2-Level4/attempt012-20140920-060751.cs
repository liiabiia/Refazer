using System;

public class Program {
  public static int Puzzle(int a, int b) {
   if(a==b) return a;
   if(a%b>0&&a%b<10) return a*b;
   else return 0
  }
}