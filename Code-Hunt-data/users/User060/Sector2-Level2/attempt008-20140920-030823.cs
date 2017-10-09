using System;

public class Program {
  public static int Puzzle(string s) {
	 int _total = 0;
	 
	 if (s[0] != s[s.Length - 1] )
		 _total++;
		 
	 for (int i = 1; i < s.Length / 2; i++  )
	 {
		 if (s[i] == s[i -1] && s[s.Length - i - 1] == s[s.Length - i] )
		 _total++;
		 else
		 break;
		 
	 }
    return _total;
  }
}