

public class Program {
  public static int Puzzle(String s) {
	int res = 0;
	int stack = 0;
	
	char[] chars = s.toCharArray();
	for (char ch: chars) {
		if (ch == '(') ++stack;
		if (ch == ')' && stack > 0) {
			--stack;
			++res;
		}
	}
	
	return res;
  }
}