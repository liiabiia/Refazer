using System;

public class Program {
  public static int Puzzle(int n) {
   
   int total=0;
   for(int i=0;i<=n;i++)
   total+=i;
   
    return total;
  }
}