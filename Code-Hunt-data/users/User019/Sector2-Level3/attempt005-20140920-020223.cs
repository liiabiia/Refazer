using System;

public class Program {
  public static string Puzzle(string s) {
	  char[] chars = s.ToCharArray();
	  int p = chars.Length();
	  char[] x = new char[p];
	  for(int i=0;i<=chars.Length();i++)
	  {
		  if(i==0|i==chars.Length()) x[i]=chars[i];
		  else x[i]= chars[chars.Length()-i];
	  }
    return new string(x);
  }
}