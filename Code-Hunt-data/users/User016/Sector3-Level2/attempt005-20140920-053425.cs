using System;

public class Program {
  public static int Puzzle(int n) {
   if(n<=3)
   return n;
   
   int total=0;
   for(int i=0;i<n;i++)
   total+=i;
   
    return total;
  }
}