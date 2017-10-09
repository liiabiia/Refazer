

public class Program {
  public static int Puzzle(String s) {
	int depth = 0;
		
	int max = 0;
	int stack = 0;
	
	char[] chars = s.toCharArray();
	for (char ch: chars) {
		if (ch == '(') {
			depth = 0;
			++stack;
		}
		if (ch == ')' && stack > 0) {
			++depth;
		}

		max = Math.max(max, depth);
	}

	if (max > 1)return max;
	else return 0;
  }
}