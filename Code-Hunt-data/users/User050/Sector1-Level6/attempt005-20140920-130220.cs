using System.Linq;

public class Program {
  public static int Puzzle(string s) {
	  while(s.Contains("  ")) s.Replace("  ", " ");
	  int a = s[0] == ' ' ? s.Count(x => x==' ') -1 : s.Count(x => x==' ');
	  return  s[s.Length-1] == ' ' ? a-1 : a;
  }
}