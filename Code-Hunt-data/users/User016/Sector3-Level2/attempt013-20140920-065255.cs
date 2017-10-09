using System;

public class Program {
  public static int Puzzle(int n) {
   if(n==0)
   return 0;
   
   if(n%2==0)
   {
   int total=0;
   for(int i=2;i<n;i++)
   total+=i;
   return total;
   }
   else
   {
  int total=1;
   for(int i=2;i<n;i++)
   total+=i;
 	   return total;
   }
  }
}