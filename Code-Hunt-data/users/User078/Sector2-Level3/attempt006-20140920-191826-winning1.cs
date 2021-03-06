using System;
using System.Text;

public class Program {
  public static string Puzzle(string s) {
    StringBuilder sb = new StringBuilder(s);
	for(int i=1; i<(1+(s.Length-1)/2); i++) {
		char c = sb[i];
		sb[i] = sb[s.Length-i-1];
		sb[s.Length-i-1] = c;
	}
	Console.WriteLine(sb.ToString());
	return sb.ToString();
  }
}