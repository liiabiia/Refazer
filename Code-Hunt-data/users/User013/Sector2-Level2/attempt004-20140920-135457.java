

public class Program {
  public static int Puzzle(String s) {
		int max = 0;
		int dep = 0;
		for (char c:s.toCharArray()){
			if (c=='('){
				dep += 1;
				if (dep > count) max = dep;
			}
			if (c==')')
				dep -= 1;
		}
		if (dep == 0)
			return max;
		return 0;
  }
}