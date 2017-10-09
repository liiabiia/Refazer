using System;

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.Length<20)
	  return (a[0]>a[a.Length-1] ? a[0]-a[a.Length-1] : a[a.Length-1]-a[0] );
	  else {
		  int s=l=a[0]
		  for(int i=1;i<a.Length;i++){
			  if(a[i]<s)
			  s=a[i];
			  if(a[i]>l)
			  l=a[i];
			  
		  }
		  
			return l-s;
	  }
    
  }
}