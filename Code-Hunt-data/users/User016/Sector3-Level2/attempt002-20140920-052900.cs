using System;

public class Program {
  public static int Puzzle(int n) {
   if(n==1)
   return 1;
   
    return n*(n/2);
  }
}