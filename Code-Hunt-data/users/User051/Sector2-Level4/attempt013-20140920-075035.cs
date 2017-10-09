using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  int q;
	 if(a>=b)
	 q = maa(a,b);
	 else
	 q = maa(b,a);
	 
	 return q;
	   }
	private static int maa(int a , int b){
		int p =1;
		 for(int i=1;i<a;i++)
		 {
			 if(a%i==0&&b%i==0&&i>p)
			 {
				 p=i;
			 }
		 }
		 return a*b/p;
	 }
	}   
}