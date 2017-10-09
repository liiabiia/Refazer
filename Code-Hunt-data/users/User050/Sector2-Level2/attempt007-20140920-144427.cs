using System.Linq;

public class Program {
  public static int Puzzle(string s) {
	  string[] reference = new string[]{"(())", "((()))", "(((())))"};
	  foreach (string st in reference)
	  {
		  if(s.Contains(st)) return s.IndexOf(st) == 0 ? st.Length : continue;
	  }
  }
}