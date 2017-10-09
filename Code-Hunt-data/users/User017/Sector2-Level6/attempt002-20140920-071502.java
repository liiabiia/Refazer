

public class Program {
  public static String Puzzle(int n) {
    String s = "";
	while(n > 0) {
		s += n%2;
		n /= 2;
	}
	return s;
  }
}