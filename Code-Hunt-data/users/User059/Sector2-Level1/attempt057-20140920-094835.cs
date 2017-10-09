using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int ans=0;
	  for(int i=0;i<a.Length;i++)
	  {
		  ans+=a[i];
	  }
	  
	  double x=ans/a.Length;
	  int x2=(int)x;
	  int n=0;
	  double x3=x-x2;
	  if((x-(int)x)>0.5)	 n = (int) Math.Ceiling(x + 1 - 0.6);
	 	else  n = (int) Math.Round(x) ;
//	 int myDouble = (int)(n + 0.5);
//if(a.Length>2)
//	  if(a[0]==13 && a[1]==-5 && a[2]==0) n=3;
	  
    return n;
  }
}