using System;

public class Program {
  public static string Puzzle(string s) {
	    if (s.Length == 0 ||s.Length == 1)
			return s;
		
		int tail = s.Length - 2;
		var chars = s.ToCharArray();
		
		for(int head = 1; head < s.Length / 2; head++)
		{
			char temp = chars[head];
			chars[head] = chars[tail];
			chars[tail] = temp;
			tail--;
		}
		
		return new string(chars);
  }
}