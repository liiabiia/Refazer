using System;

public class Program {
  public static string Puzzle(string s) {
	  int len=(s.Length)-1;	  
	  StringBuilder sb = new StringBuilder(s);
	  for(int i=1,j=len;j>i;i++,j--)
	  {
		  char temp=a[i];
		  sb[i]=sb[j];
		  sb[j]=temp;
	  }
	  s = sb.ToString();
	  return s;
  }
}