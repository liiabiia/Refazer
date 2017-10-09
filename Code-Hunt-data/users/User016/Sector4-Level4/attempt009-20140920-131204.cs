using System;

public static class Program {
    public static int Puzzle(int[] a) {
       int j=-1;
	   
	   if(a.Length%2==0)
	   return j;
	   
	   Array.Sort(a);
	   
	   for(int i=a.Length-1;i!=-1;i++)
	   {
		   if(a[i]%2==1)
		   return a[i];
	   }
	   
	   return null;
	    
    }
	
}