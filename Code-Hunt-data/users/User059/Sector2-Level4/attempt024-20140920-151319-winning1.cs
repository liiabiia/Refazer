using System;

public class Program {
  public static int Puzzle(int a, int b) {
	 
	  //
	//  else if(a%2==0 && b%2==0) return (a*b)/2;
	
   int gcd=GCD(a,b);
    
if(a==b) return a;
	
	else if (a%b==0 || b%a==0)
	 {
		  if(a<b) return b;
		  else return a;
	  }
	  else if(gcd!=0) return ((a/gcd)*(b/gcd))*gcd;
	  else     return a*b;
  }
  public static int GCD(int p, int q)
{
    if(q == 0)
    {
         return p;
    }

    int r = p % q;

    return GCD(q, r);
}
}