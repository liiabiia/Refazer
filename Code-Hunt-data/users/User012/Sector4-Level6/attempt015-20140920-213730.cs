using System;
using System.Text;

public class Program {
  public static string Puzzle(string s) {
	  if(s.Length == 0) return s;
	  StringBuilder sb = new StringBuilder(s);
	  sb[0] = GetChar(s[0], 1);
	  if(s.Length > 1) {
		  sb[1] = GetChar(s[1], 1);
		  uint a = 1;
		  uint b = 2;
		  for(uint i=2;i<s.Length;++i){
			  sb[i] = GetChar(s[i], b);
			  uint tmp = a;
			  a = b;
			  b += tmp;
		  }
	  }
	  return sb.ToString();
  }
  
  private static char GetChar(char c, uint i) {
	  return (char)((c-'a'+i)%26+'a');
  }
}