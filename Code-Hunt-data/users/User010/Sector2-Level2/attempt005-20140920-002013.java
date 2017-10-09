

public class Program {
  public static int Puzzle(String s) {
	int result = 0, count = 0;
	for (int i = 0; i < s.length(); i++) {
		if (s.charAt(i) == '(') {
			count++;
		} else if (s.charAt(i) == ')') {
			count--;
			result++;
			if (count < 0) {
				return 0;
			}
		}
	}
    return count == 0 ? result : 0;
  }
}