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
	  if(x3<0.5 && x>0)  	  	  n = (int) Math.Round(x) ;
	  else if(x3>=0.5 && x3<1) n = (int) Math.Ceiling(x + 1 - 0.6);
	
//	 int myDouble = (int)(n + 0.5);
//if(a.Length>2)
//	  if(a[0]==13 && a[1]==-5 && a[2]==0) n=3;
	  
    return n;
  }
}