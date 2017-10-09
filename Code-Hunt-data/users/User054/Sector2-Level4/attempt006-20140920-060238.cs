using System;

public class Program {
  public static int Puzzle(int a, int b) {
if(a<10) return a;
if(a==b) return a;
   else return a*b;
  }
}