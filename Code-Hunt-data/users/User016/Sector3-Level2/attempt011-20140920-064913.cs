using System;

public class Program {
  public static int Puzzle(int n) {
   if(n%2==0)
   {
   int total=0;
   for(int i=1;i<n;i++)
   total+=i;
   return total;
   }
   else
   {
  int total=0;
   for(int i=0;i<n;i++)
   total+=i;
 	   return total;
   }
  }
}