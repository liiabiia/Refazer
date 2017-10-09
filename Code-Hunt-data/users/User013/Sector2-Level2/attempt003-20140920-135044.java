

public class Program {
  public static int Puzzle(String s) {
	 	int c = 0;
		int prev = s.length();
		while (s.length()>2){
			s = s.replace("(())","()");
			c += 1;
			if (s.length() == prev)
				return 0;
		}
		if (s == "()")
			return c+1;
		return 0;
  }
}