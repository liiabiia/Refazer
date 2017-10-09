using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  int temp = new int[a.Lenght];
	  
	  for(int i = 0; i < a.Length; i++)
	  {
		  temp[i]=0;
	  	if(a[i]%t==0)
		  temp[i]=a[i];
	  }
    return temp;
  }
}