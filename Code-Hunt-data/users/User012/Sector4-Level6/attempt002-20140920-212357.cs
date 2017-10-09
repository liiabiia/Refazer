using System;

public class Program {
  public static string Puzzle(string s) {
	  if(s.Length == 0) return s;
	  s[0] = GetChar(s[0], 1);
	  if(s.Length > 1) {
		  s[1] = GetChar(s[1], 1);
		  var a = 1;
		  var b = 2;
		  for(int i=2;i<s.Length;++i){
			  s[i] = GetChar(s[i], b);
			  var tmp = a;
			  a = b;
			  b += tmp;
		  }
	  }
	  return s;
  }
  
  private static char GetChar(char c, int i) {
	  return (c-'a'+i)%25+'a';
  }
}