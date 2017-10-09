

public class Program {
  public static int Puzzle(String s) {
	  int cnt = 0;
	  for (char ch: s) {
		  if (ch == '(') ++cnt;
		  else if (ch == ')') --cnt;
		  else return 0;
		  if (cnt < 0) return 0;
	  }
	  return cnt != 0 ? s.length()/2 : 0;
  }
}