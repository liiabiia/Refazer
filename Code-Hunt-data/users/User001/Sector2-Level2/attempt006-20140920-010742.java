

public class Program {
  public static int Puzzle(String s) {
	  int cnt = 0;
	  for (char ch: s) {
		  if (ch == '(') ++cnt;
		  else if (ch == ')') --cnt;
		  if (cnt < 0) return 0;
	  }
	  return s.length()/2;
  }
}