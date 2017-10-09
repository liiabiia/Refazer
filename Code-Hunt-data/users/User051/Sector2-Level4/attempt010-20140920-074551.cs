using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  int p=1;
	 if(a>b)
	 {
		 for(int i=1;i<(int)a/2;i++)
		 {
			 if(a%i==0&&b%i==0&&i>p)
			 {
				 p=i;
			 }
		 }
	 }
	 return a*b/p;
	   }
}