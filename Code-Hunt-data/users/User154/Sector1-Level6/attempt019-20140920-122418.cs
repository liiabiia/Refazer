using System;

public class Program {
  public static int Puzzle(string s) {
	  char c[]=s;
	  int j,k=s;
	  for(int i=0;i<200;i++)
	  {
		  k=c[i];
		  if(k==288)
		  j++;		  
	  }
    return ++j;
  }
}