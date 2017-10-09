using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int ans=0;
	  for(int i=0;i<a.Length;i++)
	  {
		  ans+=a[i];
	  }
	  
	  double x=ans/a.Length;
	  int inte=(int)x;
	  int n;
	  double frac=x-inte;
	  
	//  if(frac<=0.6)
	 //	 n = (int) Math.Ceiling(x + 1 - 0.6);
		  
		//else  n = (int) Math.Round(x) ;
//	 int myDouble = (int)(n + 0.5);
//if(a.Length>2)
//	  if(a[0]==13 && a[1]==-5 && a[2]==0) n=3;

if(frac>=0.6 && frac<1)
	    return (int) Math.Ceiling(x + 1 - frac);

else return (int)x;
  }
}