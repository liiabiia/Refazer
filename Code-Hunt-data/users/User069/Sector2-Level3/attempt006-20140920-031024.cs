using System;

public class Program {
  public static string Puzzle(string s) {
	  char[] sb = s.ToCharArray();
	  int len=(sb.Length)-1;	
	  for(int i=1,j=len;(j-i)>0;i++,j--)
	  {
		  char temp=sb[i];
		  sb[i]=sb[j];
		  sb[j]=temp;
	  }
	  s = new string(sb);
	  return s;
  }
}