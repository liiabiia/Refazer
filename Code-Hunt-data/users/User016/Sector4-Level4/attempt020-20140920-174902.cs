using System;

public static class Program {
    public static int Puzzle(int[] a) {
        int[] num = new int[1];

	   if(a.Length%2==0)
	   return num[10];
	   
	   Array.Sort(a);
	   
	   for(int i=a.Length-1;i!=-1;i--)
	   {
		   if(a[i]%7!=0)
		   return a[i];
	   }
	   
	   return a[0];
	    
    }
	
}