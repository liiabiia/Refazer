using System;

public class Program {
  public static string Puzzle(string s) {
	  int len=(s.Length)-1;
	  for(int i=1,j=len;j>i;i++,j--)
	  {
		  char temp=s[i];
		  s[i]=s[j];
		  s[j]=temp;
	  }
  }
}