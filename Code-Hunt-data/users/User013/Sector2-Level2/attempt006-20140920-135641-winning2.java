

public class Program {
  public static int Puzzle(String s) {
		int m = 0;
		int dep = 0;
		for (char c:s.toCharArray()){
			if (c=='('){
				dep += 1;
				if (dep > m) m = dep;
			}
			if (c==')')
				dep -= 1;
			if (dep < 0) return 0;
		}
		if (dep == 0)
			return m;
		return 0;
  }
}