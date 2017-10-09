using System;

public static class Program {
    public static int Puzzle(int[] a) {
        int? num = null;

	   if(a.Length%2==0)
	   return num;
	   
	   Array.Sort(a);
	   
	   for(int i=a.Length-1;i!=-1;i--)
	   {
		   if(a[i]%2==1)
		   return a[i];
	   }
	   
	   return a[0];
	    
    }
	
}