using System;

public class Program {
  public static int Puzzle(string s) {
	 int _total = 0;
	 for (int i = 1; i < s.Length; i++  )
	 {
		 if (s[i] == s[i -1] && s[s.Length - i - 1] == s[s.Length - i] )
		 _total++;
		 else
		 break;
		 
	 }
    return _total;
  }
}