using System;

public class Program {
  public static string Puzzle(string s) {
	    if (s.Length == 0 ||s.Length == 1)
			return s;
		
		int tail = s.Length - 1;
		
		for(int head = 1; head < s.Length / 2; head++)
		{
			char temp = s[head];
			s[head] = s[tail];
			s[tail] = temp;
		}
		
		return s;
  }
}