using System;

public class Program {
  public static string Puzzle(string s) {
	  char[] chars = s.ToCharArray();
	  char[] x = new char[chars.Length];
	  for(int i=0;i<=chars.Length;i++)
	  {
		  if(i==0||i==chars.Length) {x[i]=chars[i]; }
		  else x[chars.Length-i-1] = chars[i];
	  }
    return new string(x);
  }
}